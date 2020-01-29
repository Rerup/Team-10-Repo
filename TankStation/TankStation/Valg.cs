using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Valg
    {
        public enum Brændstof { Diesel, Benzin92, Benzin95 };

        public double Diesel { get; set; } = 9.47;
        public double Benzin92 { get; set; } = 10.23;
        public double Benzin95 { get; set; } = 10.45;

        public Brændstof Type { get; set; }

        public void ValgAfBrændstof()
        {
            Console.WriteLine("Vælg type brændstof:\n 1. Diesel \n 2. Benzin92 \n 3. Benzin95");
            if(int.TryParse(Console.ReadLine(), out int valg)) 
            {
                switch (valg)
                {
                    case 1: Type = Brændstof.Diesel; break;
                    case 2: Type = Brændstof.Benzin92; break;
                    case 3: Type = Brændstof.Benzin95; break;
                }
                
            }
        }
    }
}

