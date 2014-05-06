using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class DiceDamage : DamageItem
    {
        private Dice DamageDice;

        public int Damage
        {
            get
            {
                return DamageDice.Throw;
            }
        }

        public override int Max
        {
            get
            {
                return DamageDice.Max - 1;
            }
        }

        public override int Min
        {
            get
            {
                return 0;
            }
        }

        public override int GetDamage ()
        {
            return this.Damage;
        }

        public DiceDamage (int min, int max)
        {
            this.DamageDice = new Dice(min, max);
        }

        public DiceDamage (int sides)
        {
            this.DamageDice = new Dice(sides);
        }

        public DiceDamage (Dice dice)
        {
            this.DamageDice = dice;
        }

    }
}
