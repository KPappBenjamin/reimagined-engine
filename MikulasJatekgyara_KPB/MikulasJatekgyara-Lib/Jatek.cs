using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public abstract class Jatek : IJatek
    {
        protected Jatek(string azonosito, string tipus, string megnevezes, 
            GyartasAdatok gyartasAdatok)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            Megnevezes = megnevezes;
            this.gyartasAdatok = gyartasAdatok;
        }

        //Azonosito;Tipus;Megnevezes
        public string Azonosito { get; init; }

        public string Tipus { get; init; }

        public string Megnevezes { get; init; }

        protected readonly GyartasAdatok gyartasAdatok;

        public abstract int ElkeszitesiIdo { get; }

        public override string ToString()
            => $"{Megnevezes}";
    }
}
