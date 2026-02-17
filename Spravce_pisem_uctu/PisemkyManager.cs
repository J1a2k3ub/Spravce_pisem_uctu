using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Spravce_pisem_uctu
{
    public class PisemkyManager
    {
        public List<string> VerzePisemek = new List<string>();

        public void NactiPisemky(string slozka)
        {
            VerzePisemek.Clear();
            if (Directory.Exists(slozka)) VerzePisemek.AddRange(Directory.GetFiles(slozka));
        }

        public void KopirujZadaniStudentum(List<Student> studenti, string zaklad, Action<string> log)
        {
            if (VerzePisemek.Count == 0) { log("Žádná zadání!"); return; }
            var serazeni = studenti.OrderBy(s => s.Ucet).ToList();

            for (int i = 0; i < serazeni.Count; i++)
            {
                Student s = serazeni[i];
                string cesta = Path.Combine(zaklad, s.Ucet, s.Prijmeni);
                if (!Directory.Exists(cesta)) Directory.CreateDirectory(cesta);

                string verze = VerzePisemek[i % VerzePisemek.Count];
                try
                {
                    File.Copy(verze, Path.Combine(cesta, Path.GetFileName(verze)), true);
                    log($"Rozdáno: {s.Ucet} -> {Path.GetFileName(verze)}");
                }
                catch (Exception ex) { log($"Chyba {s.Ucet}: {ex.Message}"); }
            }
        }

        public void SebratPisemky(List<Student> studenti, string zaklad, string cil, Action<string> log)
        {
            if (!Directory.Exists(cil)) Directory.CreateDirectory(cil);

            foreach (Student s in studenti)
            {
                string zdroj = Path.Combine(zaklad, s.Ucet, s.Prijmeni);
                if (!Directory.Exists(zdroj)) continue;

                string nazev = $"{s.Ucet}_{s.Prijmeni.Replace("__", "")}";
                string cilDir = Path.Combine(cil, nazev);
                Directory.CreateDirectory(cilDir);

                foreach (string f in Directory.GetFiles(zdroj))
                {
                    try { File.Copy(f, Path.Combine(cilDir, Path.GetFileName(f)), true); } catch { }
                }
            }
        }

        public void VytvoritRedukovany(List<Student> studenti, string zaklad, string cil, string regexStr, Action<string> log)
        {
            if (!Directory.Exists(cil)) Directory.CreateDirectory(cil);
            Regex regex = null;
            if (!string.IsNullOrEmpty(regexStr)) try { regex = new Regex(regexStr); } catch { }

            foreach (Student s in studenti)
            {
                string zdroj = Path.Combine(zaklad, s.Ucet, s.Prijmeni);
                if (!Directory.Exists(zdroj)) continue;

                string nazev = $"{s.Ucet}_{s.Prijmeni.Replace("__", "")}";
                string cilDir = Path.Combine(cil, nazev);
                bool zalozeno = false;

                foreach (string f in Directory.GetFiles(zdroj))
                {
                    string ext = Path.GetExtension(f).ToLower();
                    
                    bool ok = (ext == ".cs" || ext == ".cpp");
                    if (regex != null && regex.IsMatch(Path.GetFileName(f))) ok = true;

                    if (ok)
                    {
                        if (!zalozeno) { Directory.CreateDirectory(cilDir); zalozeno = true; }
                        File.Copy(f, Path.Combine(cilDir, Path.GetFileName(f)), true);
                    }
                }
            }
        }

        public void SmazatObsahUctu(List<Student> studenti, string zaklad, Action<string> log)
        {
            foreach (Student s in studenti)
            {
                string dir = Path.Combine(zaklad, s.Ucet, s.Prijmeni);

                if (Directory.Exists(dir) && !string.IsNullOrEmpty(s.Prijmeni))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                        log($"Smazána složka: {s.Ucet}/{s.Prijmeni}");
                    }
                    catch (Exception ex)
                    {
                        log($"Chyba mazání {s.Ucet}: {ex.Message}");
                    }
                }
            }
        }
    }
}