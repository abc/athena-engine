using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthenaPrototype
{
    static class RPGMath
    {
        public static int ExpToNextLevel(int level)
        {
            double Exp = (8 * level) * 45;
            return (int) Math.Round(Exp);
        }

        public static int ExpDifference (int levelStart, int levelEnd)
        {
            int ExpSoFar = 0;

            for (int i = levelStart; i < levelEnd; i++)
            {
                ExpSoFar += ExpToNextLevel(i);
            }

            return ExpSoFar;
        }

        public static int ExpToLevel (int level)
        {
            return ExpDifference(1, level);
        }

        public static int LevelFromExp (int exp)
        {
            int i = 0;
            int ExpLevel;
            do
            {
                i++;
                ExpLevel = ExpToLevel(i);
            }
            while (ExpLevel <= exp);

            return i - 1;
        }
    }
}
