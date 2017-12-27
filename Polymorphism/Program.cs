using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main()
        {
            var exercises = new List<Exercise>
            {
                new ChestTraining(4, 8, 60),
                new ArmsTraining(4, 12, 12)
            };

            foreach (var exercise in exercises)
            {
                exercise.TotalLoad();
            }

            Console.ReadKey();
        }
    }
}
