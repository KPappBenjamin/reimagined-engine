using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalagLib
{
    public class Rekeszek
    {
        readonly List<Rekesz> rekeszek;

        public Rekeszek(IEnumerable<string> adatsorok)
        {
            string[] elsoSor = adatsorok.First().Split();

            int szalagHossza = int.Parse(elsoSor[0]);
            int szalagSebesege = int.Parse(elsoSor[1]);




            rekeszek = new List<Rekesz>();
            foreach (string sor in adatsorok.Skip(1)){
                rekeszek.Add(new Rekesz(sor));
            }
        }

        public Rekesz RekeszKereso(int sorszam)
            => rekeszek[sorszam - 1];

        public int LegnagyobbTavolsag()
            => rekeszek.Max(x => x.SzallitasiTavolsag);

        public IEnumerable<int> IndexKereseseTavMegtetelAlapjan(int Tav)
        {
            for(int i = 0; i < rekeszek.Count;i++)
            {
                if (rekeszek[i].SzallitasiTavolsag == Tav)
                   yield return i + 1 ;
            }
        }


        public int KezdoPontElottElhaladtRekeszekTomege()
            => rekeszek.Where(x => x.Honnan != 0 && x.Hova != 0 && x.Honnan > x.Hova)
            .Sum(x => x.Tomeg);


        public IEnumerable<int> RekeszekIndexeAmiketEppenSzallitanak(int idopont)
        {
            for (int i = 0; i < rekeszek.Count; i++)
            {
                if (rekeszek[i].SzalagraTetelIdeje <= idopont 
                    && rekeszek[i].SzalarolLevetelIdeje > idopont)
                    yield return i + 1 ;
            }
        }

        public IEnumerable<(int, int)> Tomeg
            => rekeszek.GroupBy(x => x.Honnan).Select(y => (y.Key, y.Sum(x => x.Tomeg)))
            .OrderBy(x => x.Key);
    }
}
