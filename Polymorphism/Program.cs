using System;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main()
        {
            var chestTraining = new ChestTraining(4, 10, 60);
            var totalLoad = chestTraining.TotalLoad();
            Console.WriteLine("Total load in chest exercise was: {0} kg.", totalLoad);
            Console.ReadKey();
        }
    }
}
