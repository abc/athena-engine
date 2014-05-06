using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AthenaEngine.Framework.Systems
{
	/// <summary>
	/// Triggers.
	/// </summary>
    class Triggers
    {
		/// <summary>
		/// This was used to test
		/// </summary>
        public static void test ()
        {
            System.Console.WriteLine("You stepped on a tile.");
        }
		
		/// <summary>
		/// Random encounter test
		/// </summary>
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
