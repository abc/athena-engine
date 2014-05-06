using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor test = new Actor();
            test.Level = 2;

            Weapon DmgTest = new Weapon(new DamageItem[] { new DiceDamage(6), new DiceDamage(6), new FixedDamage(2) });

            System.Console.WriteLine(DmgTest.ToString());
        }
    }
}
