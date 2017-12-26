namespace Polymorphism
{
    internal abstract class Exercise
    {
        protected int Series;
        protected int Repetitions;
        protected int Load;

        protected Exercise(int series, int repetitions, int load)
        {
            Series = series;
            Repetitions = repetitions;
            Load = load;
        }

        public abstract int TotalLoad();
    }
}
