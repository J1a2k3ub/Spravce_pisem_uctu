using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Spravce_pisem_uctu
{
    public partial class Form1 : Form
    {
        // tady si vytvarim instance tech mych pomocnych trid
        public ConfigManager cfg = new ConfigManager();
        public PisemkyManager pisemky = new PisemkyManager();
        public List<Student> studenti = new List<Student>();

        private string cestaConfig = "";
        private int zbyvajiciSekundy = 0;
        private DateTime casKonce;

        public Form1()
        {
            InitializeComponent();
            // najdu kde lezi config.txt a nactu ho
            this.cestaConfig = Path.Combine(Application.StartupPath, "config.txt");
            this.NactiKonfiguraciPriStartu();
        }

        private void NactiKonfiguraciPriStartu()
        {
            if (File.Exists(cestaConfig))
            {
                Log("Načítám config...");
                cfg.NactiConfig(cestaConfig);
            }
            else
            {
                Log("config.txt nenalezen!");
            }
        }

        // otevre druhe okno pro odevzdavani
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (studenti.Count == 0)
            {
                MessageBox.Show("Nejdříve načtěte studenty.", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // musim mu predat seznam studentu a managery aby s nima mohl pracovat
            Form3 adminOkno = new Form3(this.studenti, this.cfg, this.pisemky);
            adminOkno.ShowDialog();
        }

        // nacte studenty bud ze souboru nebo ze slozek
        private void btnNacistStudenty_Click_1(object sender, EventArgs e)
        {
            DialogResult volba = MessageBox.Show(
                 "ANO = Načíst soubor students.txt (Vygeneruje Pxx -> Zobrazí tlačítko na tvorbu složek)\n" +
                 "NE = Načíst existující složky z disku (Studenti už mají složky -> Tlačítko se skryje)",
                 "Režim načítání", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (volba == DialogResult.Cancel) return;

            studenti.Clear();
            if (volba == DialogResult.Yes)
            {
                // rezim soubor: otevre dialog pro vyber souboru
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    studenti = StudentsLoader.NactiStudentyZeSouboru(ofd.FileName);
                    Log("Načten soubor: " + Path.GetFileName(ofd.FileName));

                    // zobrazim tlacitko na vytvoreni slozek protoze jeste nejsou
                    btnVytvoritAdresare.Visible = true;
                }
            }
            else
            {
                // rezim disk: proskenuje slozky Pxx
                string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
                studenti = StudentsLoader.NactiStudentyZeSlozky(zaklad);
                Log("Naskenováno z disku.");

                // skryju tlacitko protoze slozky uz jsou hotove
                btnVytvoritAdresare.Visible = false;
            }

            // vypisu studenty do listboxu na obrazovce
            listStudenti.Items.Clear();
            foreach (var s in studenti) listStudenti.Items.Add(s.ToString());
            Log($"Počet studentů: {studenti.Count}");
        }

        private void btnNacistPisemky_Click_1(object sender, EventArgs e)
        {
            string slozka = cfg.Get("CESTA_PISEMKY", "");
            pisemky.NactiPisemky(slozka);
            listPisemky.Items.Clear();
            foreach (var p in pisemky.VerzePisemek) listPisemky.Items.Add(Path.GetFileName(p));
            Log($"Písemek: {pisemky.VerzePisemek.Count}");
        }

        // fyzicky vytvori slozky P01/__Novak na disku
        private void btnVytvoritAdresare_Click_1(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            if (string.IsNullOrEmpty(zaklad) || studenti.Count == 0) return;
            if (!Directory.Exists(zaklad)) Directory.CreateDirectory(zaklad);

            foreach (Student s in studenti)
            {
                string pDir = Path.Combine(zaklad, s.Ucet);
                string sDir = Path.Combine(pDir, s.Prijmeni);
                if (!Directory.Exists(pDir)) Directory.CreateDirectory(pDir);
                if (!Directory.Exists(sDir)) Directory.CreateDirectory(sDir);
            }
            Log("Adresáře vytvořeny.");
        }

        private void btnKopirovatZadani_Click_1(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            pisemky.KopirujZadaniStudentum(studenti, zaklad, Log);
        }

        // spusti odpocet
        private void btnStartCasovac_Click_1(object sender, EventArgs e)
        {
            zbyvajiciSekundy = (int)numMinuty.Value * 60;
            casKonce = DateTime.Now.AddSeconds(zbyvajiciSekundy);

            timer.Start();
            Log($"Start: {numMinuty.Value} min.");
        }

        // tohle se deje kazdou sekundu
        private void timer1_Tick(object sender, EventArgs e)
        {
            int nove = (int)(casKonce - DateTime.Now).TotalSeconds;
            if (nove < 0) nove = 0;
            zbyvajiciSekundy = nove;

            // vypise cas ve formatu MM:SS
            lblCas.Text = $"Zbývá: {(zbyvajiciSekundy / 60):00}:{(zbyvajiciSekundy % 60):00}";

            if (zbyvajiciSekundy == 0)
            {
                timer.Stop();
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Konec času!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlus5_Click_1(object sender, EventArgs e)
        {
            casKonce = casKonce.AddMinutes(5);
            Log("+5 minut");
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            btnPlus5_Click_1(sender, e);
        }

        // pomocna metoda pro vypisovani zprav do listboxu
        private void Log(string zprava)
        {
            listLog.Items.Add($"{DateTime.Now:HH:mm} - {zprava}");
            listLog.TopIndex = listLog.Items.Count - 1;
        }
    }
}