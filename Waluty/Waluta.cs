using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Waluty
{
    class Waluta
    {
        public string SkrotWaluty { get; set; }
        public string Data { get; set; }

        public Waluta(string data, int skrotWaluty)
        {
            this.Data = data;
            if (skrotWaluty == 0)
                this.SkrotWaluty = "EUR";
            if (skrotWaluty == 1)
                this.SkrotWaluty = "USD";
            if (skrotWaluty == 2)
                this.SkrotWaluty = "GBR";
            if(skrotWaluty == 3)
                this.SkrotWaluty = "CHF";            
        }        
        public async void PobierzDane()
        {
            HttpClient klient = new HttpClient();            
            string daneZserwera = await klient.GetStringAsync(AdresUrl());
            RootObject root = new RootObject();
            root = JsonConvert.DeserializeObject<RootObject>(daneZserwera);
            Console.WriteLine(root.currency);
        }
        string AdresUrl()
        {
            string adres = "http://api.nbp.pl/api/exchangerates/rates/a/" + SkrotWaluty + "/" +
                Data.ToString() + "/?format=json";
            return adres;
        }

    }
}
