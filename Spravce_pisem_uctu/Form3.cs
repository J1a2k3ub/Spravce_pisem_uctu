using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spravce_pisem_uctu
{
    public partial class Form3 : Form
    {
        private List<Student> studenti;
        private ConfigManager cfg;
        private PisemkyManager pisemky;

        // konstruktor - tady si prevezmu data z prvniho okna
        public Form3(List<Student> seznamStudentu, ConfigManager config, PisemkyManager manager)
        {
            InitializeComponent();
            this.studenti = seznamStudentu;
            this.cfg = config;
            this.pisemky = manager;
        }

        // zkopiruje vsechno od studentu k uciteli
        private void btnOdevzdat_Click(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            string cil = cfg.Get("CESTA_ODEVZDANI", "");

            if (string.IsNullOrEmpty(cil))
            {
                MessageBox.Show("Chyba v configu: CESTA_ODEVZDANI", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pisemky.SebratPisemky(studenti, zaklad, cil, (s) => { });

            MessageBox.Show($"Hotovo.\nPráce zkopírovány do:\n{cil}", "Odevzdáno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // zkopiruje jen kody a veci co projdou filtrem (regex)
        private void btnRedukovany_Click(object sender, EventArgs e)
        {
            string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
            string cil = cfg.Get("CESTA_REDUKOVANA", "");
            string regex = txtRegex.Text.Trim();

            if (string.IsNullOrEmpty(cil))
            {
                MessageBox.Show("Chyba v configu: CESTA_REDUKOVANA", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pisemky.VytvoritRedukovany(studenti, zaklad, cil, regex, (s) => { });

            MessageBox.Show($"Hotovo.\nSoubory (.cs, .cpp + filtr) jsou v:\n{cil}", "Redukováno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // smaze vsechno ve slozkach studentu, necha jen prazdne Pxx
        private void btnSmazat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Opravdu smazat obsah složek studentů?\nData budou ztracena!", "Varování", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string zaklad = cfg.Get("CESTA_STUDENTI_BASE", "");
                pisemky.SmazatObsahUctu(studenti, zaklad, (s) => { });
                MessageBox.Show("Složky vyčištěny.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnZpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}