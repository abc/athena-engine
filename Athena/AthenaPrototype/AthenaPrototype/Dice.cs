using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class Dice
    {
        private int _Min;
        private int _Max;
        public int Min
        {
            get
            {
                return _Min;
            }
            private set
            {
                this._Min = value;
            }
        }
        public int Max
        {
            get
            {
                return _Max;
            }
            private set
            {
                this._Max = value;
            }
        }
        private Random _random = new Random();

        public Dice (int min, int max)
        {
            this.Min = min;
            this.Max = max + 1;
        }
        
        public Dice (int sides)
        {
            this.Min = 1;
            this.Max = sides + 1;
        }

        public int Throw
        {
            get
            {
                return _random.Next(this.Min, this.Max);
            }
        }
    }
}
