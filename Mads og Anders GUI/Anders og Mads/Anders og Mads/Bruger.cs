using System;
using System.Collections.Generic;
using System.Text;

namespace Anders_og_Mads
{
    public class Bruger
    {
        BrugerRepo BrugerRepoObj = new BrugerRepo();
        public string Navn { get; set; }
        public string BrugerNavn { get; set; }
        public string Adgangskode { get; set; }
        public string Stilling { get; set; }

        public void OpretBruger()
        {
            Console.WriteLine("Enter name: ");
            Navn = Console.ReadLine();

            Console.WriteLine("Enter username: ");
            BrugerNavn = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            Adgangskode = Console.ReadLine();

            Console.WriteLine("Enter stilling :");
            Stilling = Console.ReadLine();

        }

        public void TilføjBruger(string navn, string brugernavn, string adgangskode, string stilling)
        {
            BrugerRepoObj.BrugerListe.Add(new Bruger()
            {
                Navn = navn,
                BrugerNavn = brugernavn,
                Adgangskode = adgangskode,
                Stilling = stilling
            });
        }
    }
}
