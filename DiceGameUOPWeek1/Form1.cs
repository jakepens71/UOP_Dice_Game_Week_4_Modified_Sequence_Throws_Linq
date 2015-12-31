using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGameUOPWeek1
{
    public partial class Form1 : Form
    {
        List<int> sequence1 = new List<int>();
        List<int> sequence2 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rnd = new RandomNumberGenerator();

            lstSequence1.Items.Clear();
            lstSequence2.Items.Clear();
            lstNotInSequence1.Items.Clear();
            lstNotInSequence2.Items.Clear();


            for(int i = 0; i < 100; i++)
            {
                int random1 = rnd.getRandom(1, 7);
                int random2 = rnd.getRandom(1, 7);

                Throw throwDice1 = new Throw();
                throwDice1.executeThrow(random1, random2);
                sequence1.Add(throwDice1.getTotalOfBothDice());

                int roll = i + 1;

                lstSequence1.Items.Add("Dice 1: " + throwDice1.getDice1() + " Dice 2: " + throwDice1.getDice2() + " For a total of: " + throwDice1.getTotalOfBothDice() + " on Roll: " + roll.ToString());
            }

            for (int y = 0; y < 100; y++)
            {
                int random1 = rnd.getRandom(1, 7);
                int random2 = rnd.getRandom(1, 7);

                Throw throwDice2 = new Throw();
                throwDice2.executeThrow(random1, random2);
                sequence2.Add(throwDice2.getTotalOfBothDice());

                int roll = y + 1;

                lstSequence2.Items.Add("Dice 1: " + throwDice2.getDice1() + " Dice 2: " + throwDice2.getDice2() + " For a total of: " + throwDice2.getTotalOfBothDice() + " on Roll: " + roll.ToString());

            }

            IEnumerable<int> onlyInSequence1 = sequence1.Except(sequence2);

            foreach (int number in onlyInSequence1)
                lstNotInSequence2.Items.Add(number);


            IEnumerable<int> onlyInSequence2 = sequence2.Except(sequence1);

            foreach (int number in onlyInSequence2)
                lstNotInSequence1.Items.Add(number);

        }
    }
}
