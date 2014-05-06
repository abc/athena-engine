using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class Weapon
    {
        Damage _Damage = new Damage();

        public Weapon (DamageItem[] damages)
        {
            foreach (DamageItem Dmg in damages)
            {
                _Damage.Add(Dmg);
            }
        }

        public int Damage
        {
            get
            {
                return _Damage.Hit;
            }
        }

        public override string ToString()
        {
            return _Damage.ToString();
            
        }
    }
}
