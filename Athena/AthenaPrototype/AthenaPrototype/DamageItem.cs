using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    abstract class DamageItem
    {
        public abstract int Min
        {
            get;
        }

        public abstract int Max
        {
            get;
        }

        abstract public int GetDamage();
    }
}
