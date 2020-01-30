using System;

namespace Coverter_Dirter
{
    public class Length
    {

        public string ConverterMeterFod(double meter)
        {
           double Fod = 3.2808399;
            double Meter = meter;

            double answer = Meter * Fod;

            string message = $"Omregnet giver det sgu {answer}";
            
            return message;

        }

        public string ConverterFodMeter(double fod)
        {
           double Fod = fod;
            double Meter = 0.3048;


            double answer = fod / Meter;

            string message = $"Omregnet giver det sgu {answer}";

            return message;

        }
    }
}
