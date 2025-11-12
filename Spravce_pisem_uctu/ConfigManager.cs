using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Spravce_pisem_uctu
{
    internal class ConfigManager
    {
        public Dictionary<string, string> Data = new Dictionary<string, string>(); //neco jako asociativni pole, je tam klic a hodnota

        public void NactiConfig(string cesta)
        {
            this.Data.Clear();
            if (!File.Exists(cesta))
            {
                return;
            }

            string[] radky = File.ReadAllLines(cesta, Encoding.UTF8);
            for (int i = 0; i < radky.Length; i++)
            {
                string r = radky[i].Trim();
                if (r.Length == 0) { continue; }
                if (r.StartsWith("#")) { continue; } //timto se ignoruji hashtagy, aby se mohly psat komentare

                int poz = r.IndexOf('='); //zde zacina cesta
                if (poz > 0)
                {
                    string klic = r.Substring(0, poz).Trim();
                    string hod = r.Substring(poz + 1).Trim();
                    if (!this.Data.ContainsKey(klic))
                    {
                        this.Data.Add(klic, hod);
                    }
                }
            }
        }

        public string Get(string klic, string vychozi)
        {
            if (this.Data.ContainsKey(klic))
            {
                return this.Data[klic];
            }
            return vychozi;
        }
    }
}
