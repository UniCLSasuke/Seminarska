using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dfhdfhfd
{
    class KlicServisa
    {
        public static async Task PopulateHusky(ObservableCollection<Slika> poti)
        {
            string url = "https://dog.ceo/api/breed/husky/images";
            Odgovor p = new Odgovor();
            using (HttpClient klient = new HttpClient())
            {
                var sp = await klient.GetAsync(url);
                p = await sp.Content.ReadAsAsync<Odgovor>();
            }

            foreach (string x in p.message)
            {
                Slika s = new Slika();
                s.Pot = x;
                poti.Add(s);
            }
        }
        public static async Task PopulateShiba(ObservableCollection<Slika> poti)
        {
            string url = "https://dog.ceo/api/breed/shiba/images";
            Odgovor p = new Odgovor();
            using (HttpClient klient = new HttpClient())
            {
                var sp = await klient.GetAsync(url);
                p = await sp.Content.ReadAsAsync<Odgovor>();
            }

            foreach (string x in p.message)
            {
                Slika s = new Slika();
                s.Pot = x;
                poti.Add(s);
            }
        }
        public static async Task PopulateGerman(ObservableCollection<Slika> poti)
        {
            string url = "https://dog.ceo/api/breed/germanshepherd/images";
            Odgovor p = new Odgovor();
            using (HttpClient klient = new HttpClient())
            {
                var sp = await klient.GetAsync(url);
                p = await sp.Content.ReadAsAsync<Odgovor>();
            }

            foreach (string x in p.message)
            {
                Slika s = new Slika();
                s.Pot = x;
                poti.Add(s);
            }
        }
    }
}
