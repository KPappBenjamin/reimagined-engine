using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orszagok_Lib
{
    public class Orszagok
    {
        readonly List<Orszag> orszagok = new List<Orszag>();

        public Orszagok(IEnumerable<string> inputs)
        {
            foreach(var item in inputs)
            {
                orszagok.Add(new Orszag(item));
            }
        }

        public int Lenght() => orszagok.Count;

        public long SumArea() => orszagok.Sum(x=> x.Terulet);
        public long SumPopulation() => orszagok.Sum(x => x.Lakossag);
        public double AvgDistans() => orszagok.Average(x=> x.Tavolsag);

        public Orszag MaxArea() => orszagok.MaxBy(x => x.Terulet)!;

        public Orszag MinPopulation() => orszagok.MinBy(x => x.Lakossag)!;

        public int CountStartsWithA() => orszagok.Count(x => x.Nev.StartsWith("A"));

        public Orszag Contains(string name) => orszagok.First(x => x.Nev == name);

        public IEnumerable<string> SmallerThan(uint area) 
            => orszagok.Where(x => x.Terulet < area).Select(x => x.Nev);

        public IEnumerable<string> SmallerThanMo(uint area)
            => orszagok.Where(x => x.Terulet < area).Select(x => x.ToString());
    }
}
