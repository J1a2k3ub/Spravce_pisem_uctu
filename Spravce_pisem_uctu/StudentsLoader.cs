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

                string prijmeni = "";
                string ucet = "";

                string[] casti = r.Split(';');
                if (casti.Length >= 1) { prijmeni = casti[0].Trim(); }
                if (casti.Length >= 2) { ucet = casti[1].Trim(); }

                Student s = new Student(prijmeni, ucet);
                vysledek.Add(s);
            }

            return vysledek;
        }
    }
}
