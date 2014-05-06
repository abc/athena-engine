using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class FixedDamage : DamageItem
    {
        public int Damage;

        public override int Min
        {
            get
            {
                return Damage;
            }
        }

        public override int Max
        {
            get
            {
                return Damage;
            }
        }

        public FixedDamage (int damage)
        {
            this.Damage = damage;
        }

        public override int GetDamage ()
        {
            return this.Damage;
        }
    }
}
