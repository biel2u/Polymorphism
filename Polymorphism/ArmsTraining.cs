using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ArmsTraining : Exercise
    {
        public ArmsTraining(int series, int repetitions, int load) 
            : base(series, repetitions, load)
        {
        }

        public override void TotalLoad()
        {
            base.TotalLoad();
            var total = Series * Repetitions * Load * 2;
            Console.WriteLine("Total load in arms exercise was: {0} kg.", total);
        }
    }
}
