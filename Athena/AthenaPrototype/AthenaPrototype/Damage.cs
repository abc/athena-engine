using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class Damage : List<DamageItem>
    {
        public int Hit
        {
            get
            {
                int DamageSoFar = 0;
                foreach (DamageItem Dmg in this)
                {
                    DamageSoFar += Dmg.GetDamage();
                }

                return DamageSoFar;
            }
        }

        public override string ToString ()
        {
            Dictionary<string, int> Dice = new Dictionary<string, int>();
            StringBuilder DmgStringSoFar = new StringBuilder();
            foreach (DamageItem Dmg in this)
            {
                if (DmgStringSoFar.Length >= 1)
                {
                    DmgStringSoFar.Append(" + ");
                }
                if (Dmg is DiceDamage)
                {
                    DmgStringSoFar.Append("D" + Dmg.Max);
                }
                else if (Dmg is FixedDamage)
                {
                    DmgStringSoFar.Append(Dmg.Max);
                }
                
            }

            return DmgStringSoFar.ToString();
        }
    }
}
