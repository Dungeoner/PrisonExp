using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal class ArrayFiller : IColectionFiller
    {
        public void FillBoxesWithNumbers(int[] boxes)
        {
            var random = new Random();
            var arrayLenght = boxes.Length;
            for (int i = 0; i < arrayLenght; i++)
            {
                int numberWithBoxes;
                do
                {
                    numberWithBoxes = random.Next(1, arrayLenght + 1);
                }
                while (boxes.Any(x => x == numberWithBoxes));
                boxes[i] = numberWithBoxes;
            }
        }
    }
}
