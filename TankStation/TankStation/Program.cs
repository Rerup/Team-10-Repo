using System;

namespace TankStation
{
    class Program
    {
        static void Main(string[] args)
        {
            KortStander kortStanderObj = new KortStander();
            Dækning DækningObj = new Dækning();
            Valg ValgObj = new Valg();
            Pumpe PumpeObj = new Pumpe();
            Betaling BetalingObj = new Betaling();
            Kvittering KvitteringObj = new Kvittering();
            Console.WriteLine("Hej og velkommen til Cirkel K \n" +
                "Vil du indsætte dit kort? \n\n" +
                "1. Indsæt kort \n" +
                "2. Få vejrudsigten");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();

            bool dækning = false;
            do
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Vælg enten visa eller mastercard\n" +
                            "1. Visa\n" +
                            "2. Mastercard");
                        int kortvalg = int.Parse(Console.ReadLine());
                        switch (kortvalg)
                        {
                            case 1:
                                Kort Visa = new Kort(4444333322221111, 400.23);
                                Kort.valgtKortNummer = Visa.nummer;
                                Kort.valgtSaldo = Visa.saldo;
                                Console.Clear();

                                break;
                            case 2:
                                Kort MasterCard = new Kort(1111222233334444, 17094.23);
                                Kort.valgtKortNummer = MasterCard.nummer;
                                Kort.valgtSaldo = MasterCard.saldo;
                                Console.Clear();

                                break;
                        }
                        // kortStanderObj.IndsætKort = true;
                        break;
                    case 2:
                        Console.WriteLine("Det regner i Odense");
                        break;
                }
                dækning = DækningObj.CheckSaldo();
            } while (dækning == false);

            ValgObj.ValgAfBrændstof();
            PumpeObj.TælFlow();
            BetalingObj.TrækBeløb(ValgObj.Type, PumpeObj.Mængde);
            KvitteringObj.UdskrivKvittering(BetalingObj.Saldo, ValgObj.Type, PumpeObj.Mængde);
            Console.ReadLine();




            
        }
    }
}
