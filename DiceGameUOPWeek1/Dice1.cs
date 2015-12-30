using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameUOPWeek1
{
    class Dice1
    {
        int setNumber = 0;

        public Dice1()
        {

        }

        public void setDice1(int number)
        {
            setNumber = number;
        }

        public int getDice1()
        {
            return setNumber;
        }
    }

}
