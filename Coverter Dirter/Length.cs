using System;

namespace Coverter_Dirter
{
    public class Length
    {
        public double Meter = 0.3048;
        public double Fod = 3.2808;

        public string ConverterMeterFod(double meter, double fod)
        {
            Fod = fod;
            Meter = meter;

            Console.WriteLine("Skriv hvor mange meter du vil have konverteret om til fod");
            meter = int.Parse(Console.ReadLine());

            double answear = meter * fod;

            string message = $"Omregnet giver det sgu {answear}";
            
            return message;

        }

        public string ConverterFodMeter(double fod, double meter)
        {
            Fod = fod;
            Meter = meter;

            Console.WriteLine("Skriv hvor mange fod du vil have konverteret om til meter");
            fod = int.Parse(Console.ReadLine());

            double answear = fod / meter;

            string message = $"Omregnet giver det sgu {answear}";

            return message;

        }
    }
}
