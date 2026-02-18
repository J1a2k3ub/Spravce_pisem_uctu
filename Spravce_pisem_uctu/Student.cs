using System;

namespace Spravce_pisem_uctu
{
    // tohle je trida pro jednoho studenta, drzi jenom jeho jmeno a cislo uctu
    public class Student
    {
        public string Prijmeni { get; set; }
        public string Ucet { get; set; }

        // tohle se spusti kdyz vytvarim noveho studenta, ulozi to data
        public Student(string prijmeni, string ucet)
        {
            Prijmeni = prijmeni;
            Ucet = ucet;
        }

        // dulezity: tohle zaridi aby se v listboxu ukazalo "P01 (Novak)" a ne nejaky nesmysl
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