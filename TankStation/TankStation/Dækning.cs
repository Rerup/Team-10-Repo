using System;
using System.Collections.Generic;
using System.Text;

namespace TankStation
{
    public class Dækning
    {
        public bool Verificering = false;

        public bool CheckSaldo()
        {
            if (Kort.valgtSaldo >= 600)
            {
                Verificering = true;
                return Verificering;
            }
            else
            {
                Console.WriteLine("Du har ikke råd");
                return Verificering;
            }
            
        }



    }
}
