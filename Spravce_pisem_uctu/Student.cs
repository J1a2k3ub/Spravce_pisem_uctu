using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spravce_pisem_uctu
{
    internal class Student
    {
        public string Prijmeni;
        public string Ucet;

        public Student(string prijmeni, string ucet)
        {
            Prijmeni = prijmeni;
            Ucet = ucet;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Ucet))
            {
                return Prijmeni + " (" + Ucet + ")";
            }
            return Prijmeni;
        }
    }
}
