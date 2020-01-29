using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Valg
    {
        public enum Brændstof { Diesel, Benzin92, Benzin95 };

        public static double Diesel { get; set; } = 9.47;
        public static double Benzin92 { get; set; } = 10.23;
        public static double Benzin95 { get; set; } = 10.45;

        public Brændstof Type { get; set; }

        public void ValgAfBrændstof()
        {
            int valg = 0;
            do
            {

                Console.WriteLine("Vælg type brændstof:\n 1. Diesel \n 2. Benzin92 \n 3. Benzin95");
                if (int.TryParse(Console.ReadLine(), out valg))
                {
                    switch (valg)
                    {
                        case 1: Type = Brændstof.Diesel; break;
                        case 2: Type = Brændstof.Benzin92; break;
                        case 3: Type = Brændstof.Benzin95; break;
                    }

                }
                else
                {
                    Console.WriteLine("Ikke forstået, prøv igen");
                }
            } while (valg != 1 || valg != 2 || valg != 3);
        }
    }
}

