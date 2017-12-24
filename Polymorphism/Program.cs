using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ChestTraining chestTraining = new ChestTraining(4, 10, 60);
            int totalLoad = chestTraining.TotalLoad();
            Console.WriteLine("Total load in chest exercise was: {0} kg.", totalLoad);
            Console.ReadKey();
        }
    }
}
