using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravce_pisem_uctu
{
    public partial class Form1 : Form
    {
        private ConfigManager cfg = new ConfigManager();
        private PisemkyManager pisemky = new PisemkyManager();
        private List<Student> studenti = new List<Student>();

        private string cestaConfig = "";
        private string cestaStudentsTxt = "";
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
                Log("Načítám config.txt: " + cestaConfig);
                cfg.NactiConfig(cestaConfig);
            }
            else
            {
                Log("config.txt nenalezen – vytvořte prosím soubor.");
            }
        }

        private void btnNacistPisemky_Click(object sender, EventArgs e)
        {
            string slozka = cfg.Get("CESTA_PISEMKY", "");
            if (string.IsNullOrEmpty(slozka))
            {
                Log("CESTA_PISEMKY není v configu nastavena.");
                return;
            }
            if (!Directory.Exists(slozka))
            {
                Log("Složka s písemkami neexistuje: " + slozka);
                return;
            }

            pisemky.NactiPisemky(slozka);

            listPisemky.Items.Clear();
            for (int i = 0; i < pisemky.VerzePisemek.Count; i++)
            {
                string nazev = Path.GetFileName(pisemky.VerzePisemek[i]);
                listPisemky.Items.Add(nazev);
            }

            Log("Načteno verzí písemek: " + pisemky.VerzePisemek.Count);
        }

        private void btnNacistStudenty_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Vyberte students.txt";
            ofd.Filter = "Textové soubory (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cestaStudentsTxt = ofd.FileName;
                studenti = StudentsLoader.NactiStudenty(cestaStudentsTxt);

                listStudenti.Items.Clear();
                for (int i = 0; i < studenti.Count; i++)
                {
                    listStudenti.Items.Add(studenti[i].ToString());
                }

                Log("Načteno studentů: " + studenti.Count + " ze souboru: " + cestaStudentsTxt);
            }
        }

        private void btnVytvoritAdresare_Click(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            if (string.IsNullOrEmpty(zaklad))
            {
                Log("CESTA_STUDENTI_BASE není v configu nastavena.");
                return;
            }
            if (!Directory.Exists(zaklad))
            {
                Log("Složka se studentskými účty neexistuje: " + zaklad);
                return;
            }
            if (studenti == null || studenti.Count == 0)
            {
                Log("Nejprve načtěte studenty.");
                return;
            }

            int pocitadlo = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Student s = studenti[i];
                if (s == null) { continue; }
                if (string.IsNullOrEmpty(s.Prijmeni)) { continue; }

                string cil;
                if (!string.IsNullOrEmpty(s.Ucet))
                {
                    cil = Path.Combine(zaklad, s.Ucet, "XX" + s.Prijmeni);
                }
                else
                {
                    cil = Path.Combine(zaklad, "XX" + s.Prijmeni);
                }

                try
                {
                    Directory.CreateDirectory(cil);
                    pocitadlo = pocitadlo + 1;
                    Log("Vytvořen adresář: " + cil);
                }
                catch (Exception ex)
                {
                    Log("Chyba při vytváření: " + cil + " – " + ex.Message);
                }
            }

            Log("Hotovo. Vytvořeno adresářů: " + pocitadlo);
        }

        private void btnKopirovatZadani_Click(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            if (string.IsNullOrEmpty(zaklad) || !Directory.Exists(zaklad))
            {
                Log("Chybná cesta CESTA_STUDENTI_BASE v configu.");
                return;
            }

            pisemky.KopirujZadaniStudentum(studenti, zaklad, Log);
        }

        private void btnStartCasovac_Click(object sender, EventArgs e)
        {
            zbyvajiciSekundy = (int)numMinuty.Value * 60;
            casKonce = DateTime.Now.AddSeconds(zbyvajiciSekundy); 
            timer.Start();
            AktualizujCasLabel();
            Log("Časovač spuštěn na " + numMinuty.Value + " min.");
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            casKonce = casKonce.AddMinutes(5);
            Log("Přidáno +5 minut.");
        }
    
        private void AktualizujCasLabel()
        {
            int min = zbyvajiciSekundy / 60;
            int sec = zbyvajiciSekundy % 60;
            lblCas.Text = "Zbývá: " + min.ToString("00") + ":" + sec.ToString("00");
        }
        private void Log(string zprava)
        {
            string radek = DateTime.Now.ToString("HH:mm:ss") + " – " + zprava;
            listLog.Items.Add(radek);
            listLog.TopIndex = listLog.Items.Count - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int nove = (int)(casKonce - DateTime.Now).TotalSeconds;
            if (nove < 0) { nove = 0; }

            zbyvajiciSekundy = nove;
            AktualizujCasLabel();

            if (zbyvajiciSekundy == 0)
            {
                timer.Stop();
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Konec času!", "Časovač", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log("Konec času.");
            }
        }
    }
}
