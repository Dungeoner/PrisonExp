using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal class Prisoner
    {
      //  public List<int> ChosenNumbers { get; set; }
        public IStrategy Strategy { get; set; }
        public int PrisonerNumber { get; set; }
        public  Prisoner(IStrategy strategy, int prisonerNumber)
        {
          //  ChosenNumbers = new List<int>();
            Strategy = strategy;
            PrisonerNumber = prisonerNumber;
        }
        public bool DoStrategy(int[] boxes, int attemptsAmount)
        {
           return Strategy.DoStrategy(boxes, PrisonerNumber, attemptsAmount);
        }
    }
}
