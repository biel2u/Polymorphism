using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Exercise
    {
        protected int _series;
        protected int _repetitions;
        protected int _load;
        public Exercise(int series, int repetitions, int load)
        {
            _series = series;
            _repetitions = repetitions;
            _load = load;
        }
        public abstract int TotalLoad();
    }
}
