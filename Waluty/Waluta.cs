using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;

namespace Waluty
{
    class Waluta
    {
        public string SkrotWaluty { get; set; }
        public string Data { get; set; }
        public string Kurs { get; set; }
        public string NazwaWaluty { get; set; }

        public Waluta(string data, int skrotWaluty)
        {
            this.Data = data;
            if (skrotWaluty == 3)
                this.SkrotWaluty = "CHF";
            else if (skrotWaluty == 1)
                this.SkrotWaluty = "USD";
            else if (skrotWaluty == 2)
                this.SkrotWaluty = "GBP";
            else
                this.SkrotWaluty = "EUR";  
        }        
        public void PobierzDane()
        {
            WebClient klient = new WebClient();            
            RootObject root = new RootObject();
            // pobiera asynchronicznie dane w postaci stringa
            try
            {
                klient.Encoding = Encoding.UTF8; // ustawienie kodowania WebClienta na UTF8
                string daneZserwera = klient.DownloadString(AdresUrl());
                root = JsonConvert.DeserializeObject<RootObject>(daneZserwera);
                this.Kurs = Math.Round(root.rates[0].mid, 2).ToString();
                this.NazwaWaluty = root.currency.ToString();
            }
            // jeżeli string jest z kodem błedu to ustaw root objekt na brak danych
            catch (Exception e)
            {
                Kurs = e.Message;
            }
        }
        string AdresUrl()
        {
            string adres = "http://api.nbp.pl/api/exchangerates/rates/a/" + SkrotWaluty + "/" +
                Data + "/?format=json";
            return adres;
        }

    }
}
