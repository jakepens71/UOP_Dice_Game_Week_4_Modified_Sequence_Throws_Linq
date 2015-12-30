using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameUOPWeek1
{
    class Dice2
    {
        int setNumber = 0;

        public Dice2()
        {

        }

        public void setDice2(int number)
        {
            setNumber = number;
        }

        public int getDice2()
        {
            return setNumber;
        }
    }
}
