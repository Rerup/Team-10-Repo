using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace TankStation
{
    public class Pumpe
    {
        private bool tilstand { get; set; }
        public double Mængde { get; set; }

        public void TælFlow ()
        {
            
            var timer = new Stopwatch();
            Console.WriteLine("Press any key to start tanking");
            Console.ReadKey();
            tilstand = true;
            timer.Start();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            tilstand = false;
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            double temMængde = 1.3 * timeTaken.TotalSeconds;
            Mængde = Math.Round(temMængde, 2);

            
        }
    }
}
