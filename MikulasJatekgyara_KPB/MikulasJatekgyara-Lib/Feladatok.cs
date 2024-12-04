using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public class Feladatok
    {
        readonly List<Feladat> feladatok;

        public Feladatok()
        {
            this.feladatok = new List<Feladat>();
        }

        public static Feladatok operator +(Feladatok meglevoFeladatok, Feladat ujFeladat)
        {
            var ujFeladatLista = new Feladatok();
            ujFeladatLista.feladatok.AddRange(meglevoFeladatok.feladatok);
            ujFeladatLista.feladatok.Add(ujFeladat);
            return ujFeladatLista;
        }

        public IEnumerable<Feladat> FeladatLista => feladatok;
    }
}
