using System;
using System.Collections.Generic;
using System.Text;


namespace TankStation
{
    class Kvittering
    {
        public double Pris { get; set; }
        public Valg.Brændstof Type { get; set; }
        public double Mængde { get; set; }
        public string Adresse = "Grønlykkevej 3";
        public string Navn = "F24";
        DateTime Dato;


        public void UdskrivKvittering(double pris, Valg.Brændstof type, double mængde)
        {
            Pris = pris;
            Type = type;
            Mængde = mængde;
            Dato = DateTime.Now;

            Console.WriteLine($"Her er din kvittering: \n\n" +
                $"Du har tanket for: {Mængde} liter {Type}\n" +
                $"Pris: {Pris} kr. \n" +
                $"{Navn}\n" +
                $"{Adresse}\n" +
                $"{Dato} \n" +
                $"Tak og på gensyn");

        }
    }
}

