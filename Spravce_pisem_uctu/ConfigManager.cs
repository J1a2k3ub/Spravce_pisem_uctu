using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Spravce_pisem_uctu
{
    public class ConfigManager
    {
        public Dictionary<string, string> Data = new Dictionary<string, string>();

        public void NactiConfig(string cesta)
        {
            this.Data.Clear();
            if (!File.Exists(cesta)) return;

            string[] radky = File.ReadAllLines(cesta, Encoding.UTF8);
            foreach (string radek in radky)
            {
                string r = radek.Trim();
                if (r.Length == 0 || r.StartsWith("#")) continue;

                int poz = r.IndexOf('=');
                if (poz > 0)
                {
                    string klic = r.Substring(0, poz).Trim();
                    string hodnota = r.Substring(poz + 1).Trim();
                    if (!Data.ContainsKey(klic)) Data.Add(klic, hodnota);
                }
            }
        }

        public string Get(string klic, string vychozi)
        {
            return Data.ContainsKey(klic) ? Data[klic] : vychozi;
        }
    }
}