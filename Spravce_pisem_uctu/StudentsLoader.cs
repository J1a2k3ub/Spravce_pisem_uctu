using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    
namespace Spravce_pisem_uctu
{
    internal class StudentsLoader
    {
        public static List<Student> NactiStudenty(string cesta)
        {
            List<Student> vysledek = new List<Student>();
            if (!File.Exists(cesta))
            {
                return vysledek;
            }

            string[] radky = File.ReadAllLines(cesta, Encoding.UTF8);
            for (int i = 0; i < radky.Length; i++)
            {
                string r = radky[i].Trim();
                if (r.Length == 0) { continue; }
                if (r.StartsWith("#")) { continue; }

                // NOVĚ:
                // Očekáváme formát: P01;__Dolezal
                //  casti[0] = ucet (P01)
                //  casti[1] = "jméno/adresář" (__Dolezal)

                string ucet = "";
                string prijmeni = "";

                string[] casti = r.Split(';');
                if (casti.Length >= 1) { ucet = casti[0].Trim(); }
                if (casti.Length >= 2) { prijmeni = casti[1].Trim(); }

                // Student(prijmeni, ucet)
                // tedy napr. Student("__Dolezal", "P01")
                Student s = new Student(prijmeni, ucet);
                vysledek.Add(s);
            }

            // POZOR:
            // Program předpokládá, že soubor je napsaný v pořadí sezení:
            // P01 v prvním řádku, P02 v druhém, P03 ve třetím atd.
            // Tím pádem index v seznamu odpovídá "sousedům" (1,2,3,...)

            return vysledek;
        }
    }
}
