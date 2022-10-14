using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal class SmartStrategy : IStrategy
    {
        public bool DoStrategy(int[] boxes, int prisonerNumber, int attemptsAmount)
        {
            var boxToPick = prisonerNumber - 1;
            for (int i = 0; i < attemptsAmount; i++)
            {
                if (boxes[boxToPick] == prisonerNumber)
                {
                    return true;
                }
                else
                {
                    boxToPick = boxes[boxToPick] - 1;
                }
            }
            return false;
        }
    }
}
