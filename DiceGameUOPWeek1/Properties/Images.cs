using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameUOPWeek1
{
    class Images
    {
        enum dicePictures { dice1, dice2, dice3, dice4, dice5, dice6 };

        public Images()
        {

        }

        public string getPictureName(int number)
        {
            string[] images = Directory.GetFiles(@"dice_pictures", "*.png");

            int picIndex = number - 1;

            string image = images[picIndex].ToString();

            return image;
        }

    }
}
