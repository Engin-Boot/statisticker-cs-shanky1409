using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        private Stats stats;
        public StatsComputer()
        {
            this.stats = new Stats();
        }
        public Stats CalculateStatistics(List<double> numbers) {
            
            if(numbers.Count==0)
            {
                stats.min = double.NaN;
                stats.max = double.NaN;
                stats.average = double.NaN;
            }
            else
            {
                stats.min = numbers.Min();
                stats.max = numbers.Max();
                stats.average = numbers.Average();
            }
            return stats;
        }
    }
}
