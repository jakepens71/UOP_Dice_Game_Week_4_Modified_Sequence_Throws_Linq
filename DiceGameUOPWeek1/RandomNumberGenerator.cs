using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameUOPWeek1
{
    class RandomNumberGenerator
    {
        private Random rnd = new Random();

        public Int32 getRandom(Int32 iMin, Int32 iMax)
        {
            return rnd.Next(iMin, iMax);
        }
    }
}
