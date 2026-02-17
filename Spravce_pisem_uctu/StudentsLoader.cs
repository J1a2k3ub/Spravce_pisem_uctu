using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Spravce_pisem_uctu
{
    public class StudentsLoader
    {
        public static List<Student> NactiStudentyZeSlozky(string zakladniCesta)
        {
            List<Student> vysledek = new List<Student>();
            if (!Directory.Exists(zakladniCesta)) return vysledek;

            string[] ucty = Directory.GetDirectories(zakladniCesta);
            foreach (string cestaUctu in ucty)
            {
                string ucetNazev = Path.GetFileName(cestaUctu);

                string[] podSlozky = Directory.GetDirectories(cestaUctu);
                foreach (string pod in podSlozky)
                {
                    string jmeno = Path.GetFileName(pod); 
                    if (jmeno.StartsWith("__"))
                    {
                        vysledek.Add(new Student(jmeno, ucetNazev));
                        break; 
                    }
                }
            }
            return vysledek;
        }

        public static List<Student> NactiStudentyZeSouboru(string cesta)
        {
            List<Student> vysledek = new List<Student>();
            if (!File.Exists(cesta)) return vysledek;

            string[] radky = File.ReadAllLines(cesta, Encoding.UTF8);
            foreach (string r in radky)
            {
                string radek = r.Trim();
                if (radek.Length == 0 || radek.StartsWith("#")) continue;

                string[] casti = radek.Split(';');
                string ucet = "";
                string jmeno = "";

                if (casti.Length >= 2)
                {
                    ucet = casti[0].Trim();
                    jmeno = casti[1].Trim();
                }
                else
                {
                    jmeno = casti[0].Trim();
                }

                if (!jmeno.StartsWith("__")) jmeno = "__" + jmeno;

                vysledek.Add(new Student(jmeno, ucet));
            }

            int pocitadlo = 1;
            foreach (Student s in vysledek)
            {
                if (string.IsNullOrEmpty(s.Ucet))
                {
                    string novyUcet;
                    do
                    {
                        novyUcet = "P" + pocitadlo.ToString("00");
                        pocitadlo++;
                    }
                    while (vysledek.Any(x => x.Ucet == novyUcet)); 

                    s.Ucet = novyUcet;
                }
            }
            return vysledek;
        }
    }
}