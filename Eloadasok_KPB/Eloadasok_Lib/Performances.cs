using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloadasok_Lib
{
    public class Performances
    {
        private readonly List<Performance> performances = new List<Performance>();
        
        public Performances(IEnumerable<string> linesOfData) { 
            
            foreach (string line in linesOfData){
            
                performances.Add(new Performance(line));
            }
        }

        public int Count => performances.Count;

        public Performance MostExpesive() =>
            performances.MaxBy(x => x.CategoryPrice1);

        public Performance LeastAvailableSeats() =>
            performances.MinBy(x => x.FreeSeats);

        public IEnumerable<Performance> DescendingByAudience() =>
            performances.OrderByDescending(x => x.SumAudience);

        public IEnumerable<(string, int)> ProfitPerPerformance() =>
            performances.GroupBy(x => x.Name).Select(g => (g.Key, g.Sum(x => x.Profit)));

        public IEnumerable<string> PerformedMoreThanOnce() =>
            performances.GroupBy(x => x.Name).Where(g => g.Count() > 1).Select(x => x.Key);

        public IEnumerable<Performance> CheapestPerformaces(int amount) => 
            performances.OrderBy(x=>x.CategoryPrice2).Take(amount);

        public IEnumerable<string> AllPerformaceNames() => 
            performances.Select(x => x.Name).Distinct().Order();
    }
}
