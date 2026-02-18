using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Spravce_pisem_uctu
{
    // tahle trida se stara o nacitani cest ze souboru config.txt
    public class ConfigManager
    {
        // slovnik = neco jako seznam, ale hledam v nem podle nazvu (klice)
        public Dictionary<string, string> Data = new Dictionary<string, string>();

        // nacte soubor radek po radku a ulozi to do slovniku
        public void NactiConfig(string cesta)
        {
            this.Data.Clear();
            if (!File.Exists(cesta)) return; // kdyz soubor neni, kaslem na to

            string[] radky = File.ReadAllLines(cesta, Encoding.UTF8);
            foreach (string radek in radky)
            {
                string r = radek.Trim();
                // preskakuju prazdne radky a komentare s krizkem
                if (r.Length == 0 || r.StartsWith("#")) continue;

                // hledam rovnitko, vlevo je nazev nastaveni, vpravo je cesta
                int poz = r.IndexOf('=');
                if (poz > 0)
                {
                    string klic = r.Substring(0, poz).Trim();
                    string hodnota = r.Substring(poz + 1).Trim();
                    if (!Data.ContainsKey(klic)) Data.Add(klic, hodnota);
                }
            }
        }

        // tohle pouzivam kdyz chci ziskat cestu, treba dej mi "CESTA_PISEMKY"
        public string Get(string klic, string vychozi)
        {
            return Data.ContainsKey(klic) ? Data[klic] : vychozi;
        }
    }
}