using System;
using Coverter_Dirter;

namespace Converter_Dirter_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            Weight test1 = new Weight();
            Valuta test2 = new Valuta();
            Length test3 = new Length();
            Console.WriteLine(test1.ConvertKilogramToGram(10));
            Console.WriteLine(test2.ValutaToUSD(10, "DKK"));
            Console.WriteLine(test3.ConverterMeterFod(1));
            Console.ReadLine();
        }
    }
}
