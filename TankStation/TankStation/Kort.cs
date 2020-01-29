using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Kort
    {
        public static long valgtKortNummer = 0;
        public static double valgtSaldo = 0;
        public long nummer { get; set; }
        public double saldo { get; set; }

        public Kort(long kortNummer, double kontoSaldo)
        {
            nummer = kortNummer;
            saldo = kontoSaldo;
        }
    }
}
