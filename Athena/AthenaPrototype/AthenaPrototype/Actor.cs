using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    class Actor
    {
        public int MaxHP
        {
            get
            {
                return (Level * 100) + (Constitution * 10) ;
            }
        }
        public int MaxNano
        {
            get
            {
                return (Level * 100) + (Wisdom * 10);
            }
        }

        public int Health;
        public int Nano;

        private int[] _attributes = new int[6];

        public int Strength
        {
            get
            {
                return _attributes[Attributes.Strength];
            }
            set
            {
                _attributes[Attributes.Strength] = value;
            }
        }
        public int Constitution
        {
            get
            {
                return _attributes[Attributes.Constitution];
            }
            set
            {
                _attributes[Attributes.Constitution] = value;
            }
        }
        public int Dexterity
        {
            get
            {
                return _attributes[Attributes.Dexterity];
            }
            set
            {
                _attributes[Attributes.Dexterity] = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return _attributes[Attributes.Intelligence];
            }
            set
            {
                _attributes[Attributes.Intelligence] = value;
            }
        }
        public int Charisma
        {
            get
            {
                return _attributes[Attributes.Charisma];
            }
            set
            {
                _attributes[Attributes.Charisma] = value;
            }
        }
        public int Wisdom
        {
            get
            {
                return _attributes[Attributes.Wisdom];
            }
            set
            {
                _attributes[Attributes.Wisdom] = value;
            }
        }

        public int Experience;
        public int Level
        {
            get
            {
                return RPGMath.LevelFromExp(Experience);
            }
            set
            {
                this.Experience = RPGMath.ExpToLevel(value);
            }
        }

        public Actor ()
        {
            this.Level = 10;
            this.Strength = 10;
            this.Constitution = 10;
            this.Dexterity = 10;
            this.Intelligence = 10;
            this.Charisma = 10;
            this.Wisdom = 10;
        }
    }
}