using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class ChestTraining : Exercise
    {
        public ChestTraining(int series, int repetitions, int load) 
            : base(series, repetitions, load)
        {
        }

        public override int TotalLoad()
        {
            return (_series*_repetitions*_load);
        }
    }
}
