using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public sealed class EgyszeruJatek : Jatek
    {
        public EgyszeruJatek(string azonosito, string tipus, string megnevezes, 
            GyartasAdatok gyartasAdatok) : 
            base(azonosito, tipus, megnevezes, gyartasAdatok)
        {
        }

        public override int ElkeszitesiIdo 
            => gyartasAdatok[Tipus]?.ElkeszitesiIdo ?? 0;
    }
}
