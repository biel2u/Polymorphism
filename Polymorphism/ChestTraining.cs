namespace Polymorphism
{
    internal class ChestTraining : Exercise
    {
        public ChestTraining(int series, int repetitions, int load) 
            : base(series, repetitions, load)
        {
        }

        public override int TotalLoad()
        {
            return (Series*Repetitions*Load);
        }
    }
}
