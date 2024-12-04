using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public class GyartasAdatok
    {
        readonly Dictionary<string, GyartasAdat> gyartasAdatok;

        public GyartasAdatok(IEnumerable<GyartasAdat> gyartasAdatok)
        {
            this.gyartasAdatok = gyartasAdatok.ToDictionary(x=>x.Azonosito);
        }

        public GyartasAdat? this[string azonosito] => gyartasAdatok[azonosito];

        public IEnumerable<string> ElerhetoGyartasAzonositok
            => gyartasAdatok.Keys.Order();
    }
}
