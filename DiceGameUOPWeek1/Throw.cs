using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameUOPWeek1
{
    class Throw
    {
        //Instantiate new dice1 and dice2 objects
        Dice1 dice1 = new Dice1();
        Dice2 dice2 = new Dice2();

        //Create random number generator object
        RandomNumberGenerator rnd = new RandomNumberGenerator();

        public Throw()
        {

        }

        public void executeThrow(int randomNumber1, int randomNumber2)
        {

            dice1.setDice1(randomNumber1);
               
            dice2.setDice2(randomNumber2);
        }

        public int getTotalOfBothDice()
        {
            int dice1Number = dice1.getDice1();
            int dice2Number = dice2.getDice2();

            int totalNumberRolled = dice1Number + dice2Number;

            return totalNumberRolled;
        }

        public int getDice1()
        {
            return dice1.getDice1();
        }

        public int getDice2()
        {
            return dice2.getDice2();
        }

    }
}
