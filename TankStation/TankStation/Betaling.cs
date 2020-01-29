using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Betaling
    {
        public double Saldo { get; }

        public void TrækBeløb(Valg.Brændstof type, double mængde)
        {
            double betalingspris = 0;

            switch (type)
            {
                case Valg.Brændstof.Diesel:
                    betalingspris = mængde * Valg.Diesel;
                    break;

                case Valg.Brændstof.Benzin92:
                    betalingspris = mængde * Valg.Benzin92;
                    break;

                case Valg.Brændstof.Benzin95:
                    betalingspris = mængde * Valg.Benzin95;
                    break;
            }

            Console.WriteLine("Du betaler nu: " + betalingspris);

            Kort.valgtSaldo =- betalingspris;

        }
    }
}
