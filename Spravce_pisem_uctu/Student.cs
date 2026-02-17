using System;

namespace Spravce_pisem_uctu
{
    public class Student
    {
        public string Prijmeni { get; set; }
        public string Ucet { get; set; } 

        public Student(string prijmeni, string ucet)
        {
            Prijmeni = prijmeni;
            Ucet = ucet;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Ucet))
            {
                return Ucet + " (" + Prijmeni + ")";
            }
            return Prijmeni;
        }
    }
}