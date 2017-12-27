using System;

namespace Polymorphism
{
    internal class ChestTraining : Exercise
    {
        public ChestTraining(int series, int repetitions, int load) 
            : base(series, repetitions, load)
        {
        }

        public override void TotalLoad()
        {
            base.TotalLoad();
            var total = Series * Repetitions * Load;
            Console.WriteLine("Total load in chest exercise was: {0} kg.", total);
        }
    }
}
