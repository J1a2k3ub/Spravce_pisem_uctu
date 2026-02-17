using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Spravce_pisem_uctu
{
    public partial class Form1 : Form
    {
        public ConfigManager cfg = new ConfigManager();
        public PisemkyManager pisemky = new PisemkyManager();
        public List<Student> studenti = new List<Student>();

        private string cestaConfig = "";
        private int zbyvajiciSekundy = 0;
        private DateTime casKonce;

        public Form1()
        {
            InitializeComponent();
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (studenti.Count == 0)
            {
                MessageBox.Show("Nejdříve načtěte studenty.", "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form3 adminOkno = new Form3(this.studenti, this.cfg, this.pisemky);
            adminOkno.ShowDialog();
        }

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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    studenti = StudentsLoader.NactiStudentyZeSouboru(ofd.FileName);
                    Log("Načten soubor: " + Path.GetFileName(ofd.FileName));

                    btnVytvoritAdresare.Visible = true;
                }
            }
            else
            {
                string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
                studenti = StudentsLoader.NactiStudentyZeSlozky(zaklad);
                Log("Naskenováno z disku.");

                btnVytvoritAdresare.Visible = false;
            }

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

        private void btnStartCasovac_Click_1(object sender, EventArgs e)
        {
            zbyvajiciSekundy = (int)numMinuty.Value * 60;
            casKonce = DateTime.Now.AddSeconds(zbyvajiciSekundy);

            timer.Start();
            Log($"Start: {numMinuty.Value} min.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nove = (int)(casKonce - DateTime.Now).TotalSeconds;
            if (nove < 0) nove = 0;
            zbyvajiciSekundy = nove;

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

        private void Log(string zprava)
        {
            listLog.Items.Add($"{DateTime.Now:HH:mm} - {zprava}");
            listLog.TopIndex = listLog.Items.Count - 1;
        }
    }
}