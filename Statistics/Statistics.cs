using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            Stats stats = new Stats();
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
