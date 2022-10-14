using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonExp
{
    internal class Experiment
    {
        IColectionFiller Filler { get; set; }
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="filler">Interface implementation</param>
        /// 
        public int Quantity { get; set; }
        public int[] Boxes { get; set; }
        public Experiment(IColectionFiller filler, int quantity)
        {
            Boxes = new int[quantity];
            filler.FillBoxesWithNumbers(Boxes);
            Quantity = quantity;
            // Filler = filler;

        }

        public bool DoExperiment(int attemptsAmount, IStrategy strategy)
        {
            var prisoners = new List<Prisoner>();
            for (int i = 0; i < Quantity; i++)
            {
                prisoners.Add(new Prisoner(strategy, i + 1));
            }
            foreach (var prisoner in prisoners)
            {
                if (!prisoner.DoStrategy(Boxes, attemptsAmount))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
