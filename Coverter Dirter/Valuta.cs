 using System;
using System.Collections.Generic;
using System.Text;

namespace Coverter_Dirter
{
    public class Valuta
    {
        public string ValutaToUSD(double amount, string valuta)
        {
            string message = "";
            double result = 0;

            switch (valuta)
            {
                case "DKK":
                    result = amount / 6.79;
                    break;

                case "EUR":
                    result = amount / 0.91;
                    break;

                case "SEK":
                    result = amount / 9.65;

                    break;
            }
            message = $"{amount} {valuta} = {result} USD";

            return message;
        }
        








    }
}
