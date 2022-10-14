using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal class RandomStrategy : IStrategy
    {
        public bool DoStrategy(int[] boxes, int prisonerNumber, int attemptsAmount)
        {
           var openedBoxes = new List<int>();
            for (int i = 0; i < attemptsAmount; i++)
            {
                var number = PickBox(boxes.Length, openedBoxes);
                if (boxes[number] == prisonerNumber) 
                { 
                    return true;
                }
                openedBoxes.Add(number);
            }
            return false;
        }

        private int PickBox(int boxesAmount, List<int> openedBoxes)
        {
            var random = new Random();
            int number;
            do
            {
                 number = random.Next(0, boxesAmount);
            }
            while (openedBoxes.Any(x => x == number));
            return number;
        }
    }
}
