using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spravce_pisem_uctu
{
    internal class PisemkyManager
    {
        public List<string> VerzePisemek = new List<string>();

        public void NactiPisemky(string slozka)
        {
            this.VerzePisemek.Clear();
            if (!Directory.Exists(slozka))
            {
                return;
            }

            string[] soubory = Directory.GetFiles(slozka);
            for (int i = 0; i < soubory.Length; i++)
            {
                this.VerzePisemek.Add(soubory[i]);
            }
        }

        public void KopirujZadaniStudentum(List<Student> studenti, string cilovyZaklad, System.Action<string> log)
        {
            if (studenti == null || studenti.Count == 0)
            {
                log("Seznam studentů je prázdný.");
                return;
            }
            if (this.VerzePisemek.Count == 0)
            {
                log("Nejsou načtené žádné písemky.");
                return;
            }
            if (!Directory.Exists(cilovyZaklad))
            {
                log("Cílová kořenová složka studentů neexistuje: " + cilovyZaklad);
                return;
            }
            if (this.VerzePisemek.Count == 1)
            {
                log("Pozor: je k dispozici jen jedna verze zadání.");
            }

            int pocet = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Student s = studenti[i];
                if (s == null) { continue; }
                if (string.IsNullOrEmpty(s.Prijmeni)) { continue; }

                string cilDir;
                if (!string.IsNullOrEmpty(s.Ucet))
                {
                    cilDir = Path.Combine(cilovyZaklad, s.Ucet, s.Prijmeni);
                }
                else
                {
                    cilDir = Path.Combine(cilovyZaklad, s.Prijmeni);
                }

                try
                {
                    Directory.CreateDirectory(cilDir);
                }
                catch (Exception ex)
                {   
                    log("Chyba při vytváření složky: " + cilDir + " – " + ex.Message);
                    continue;
                }

                int indexVerze = i % this.VerzePisemek.Count;
                string zdrojSoubor = this.VerzePisemek[indexVerze];
                string cilSoubor = Path.Combine(cilDir, Path.GetFileName(zdrojSoubor));

                try
                {
                    File.Copy(zdrojSoubor, cilSoubor, true);
                    pocet = pocet + 1;
                    log("Kopíruji: " + Path.GetFileName(zdrojSoubor) + " → " + cilDir);
                }
                catch (Exception ex)
                {
                    log("Chyba kopírování do " + cilDir + ": " + ex.Message);
                }
            }

            log("Hotovo. Zadaní zkopírováno u " + pocet + " účtů.");
        }
    }
}
