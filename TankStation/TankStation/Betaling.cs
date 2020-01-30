using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Betaling
    {
        public double Saldo { get; set; }


        public void TrækBeløb(Valg.Brændstof type, double mængde)
        {
            Saldo = 0;

            switch (type)
            {
                case Valg.Brændstof.Diesel:
                    Saldo = mængde * Valg.Diesel;
                    break;

                case Valg.Brændstof.Benzin92:
                    Saldo = mængde * Valg.Benzin92;
                    break;

                case Valg.Brændstof.Benzin95:
                    Saldo = mængde * Valg.Benzin95;
                    break;
            }
            Console.Clear();
           

            Kort.valgtSaldo =- Math.Round(Saldo,2);

        }
    }
}
