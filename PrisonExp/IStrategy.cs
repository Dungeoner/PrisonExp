using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal interface IStrategy
    {
        bool DoStrategy(int[] boxes, int prisonerNumber, int attemptsAmount);
        
    }
}
