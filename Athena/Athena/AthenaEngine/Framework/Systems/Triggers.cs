using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AthenaEngine.Framework.Systems
{
    class Triggers
    {
        public static void test ()
        {
            System.Console.WriteLine("You stepped on a tile.");
        }
        public static void encounter()
        {

            Random Rng = new Random();
            int encounter = Rng.Next(1,20);

            if((encounter %4 == 0))
            {
                Console.WriteLine("Random Encounter!");
            }
        }
    }
}
