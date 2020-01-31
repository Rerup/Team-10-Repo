using System;

namespace Anders_og_Mads
{
    class Program
    {
        static void Main(string[] args)
        {
            Bruger test1 = new Bruger();
            BrugerRepo test3 = new BrugerRepo();

            test1.OpretBruger();
            test1.TilføjBruger(test1.Navn, test1.BrugerNavn, test1.Adgangskode, test1.Stilling);

            test1.OpretBruger();
            test1.TilføjBruger(test1.Navn, test1.BrugerNavn, test1.Adgangskode, test1.Stilling);

            foreach (Bruger bruger in test3.BrugerListe)
            {
                Console.WriteLine($"Bruger: {bruger.Navn}");
            }
            Console.ReadLine();



        }
    }
}
