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
        //Instantiate new dice1 and dice2 objects
        Dice1 dice1 = new Dice1();
        Dice2 dice2 = new Dice2();

        //Create random number generator object
        Random random = new Random();

        //Create images object
        Images image = new Images();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            lstRollResult.Items.Clear();

            for (int i = 0; i < 100; i++)
            {
                picDice1.Image = null;
                picDice2.Image = null;


                //For Dice 1
                int randomNumber1 = random.Next(1, 7);
                dice1.setDice1(randomNumber1);
                string filePath1 = image.getPictureName(dice1.getDice1());
                var newImage = Image.FromFile(filePath1);
                picDice1.Image = newImage;
                picDice1.Refresh();


                //For dice 2
                int randomNumber2 = random.Next(1, 7);
                dice2.setDice2(randomNumber2);
                string filePath2 = image.getPictureName(dice2.getDice2());
                var dice2Image = Image.FromFile(filePath2);
                picDice2.Image = dice2Image;
                picDice2.Refresh();

                if (randomNumber1 == randomNumber2)
                {
                    int rollIteration = i - 1;
                    lstRollResult.Items.Add("Dice 1: " + randomNumber1.ToString() + " : Dice 2: " + randomNumber2.ToString() + " on Roll: " + rollIteration.ToString());
                }

            }
        }
    }
}
