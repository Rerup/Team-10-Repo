using System;
using System.Collections.Generic;
using System.Text;

namespace Coverter_Dirter
{
    public class Weight
    {
        public string ConvertKilogramToGram(double input)
        {
            double Answer;
            Answer = input * 1000;
            string message = $"{input}kg. is {Answer} in grams. ";
            return message;
        }

        public string ConvertGramToKiloGram(double input)
        {
            double Answer;
            Answer = input * 0.001;
            string message = $"{input}g. is {Answer} in kg. ";
            return message;
        }
    }
}
