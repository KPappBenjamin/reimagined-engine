using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public class InteraktivJatek : Jatek
    {
        readonly List<string> modulok;
        public InteraktivJatek(string azonosito, string tipus, string megnevezes, 
            GyartasAdatok gyartasAdatok, IEnumerable<string> modulok) : 
            base(azonosito, tipus, megnevezes, gyartasAdatok)
        {
            this.modulok = modulok.ToList();
        }

        public string TipusMeghatarozas(string modulAzonosito)
        {
            if (modulAzonosito[0] == 'k') return modulAzonosito;
            return modulAzonosito[0].ToString();

        }

        public override int ElkeszitesiIdo 
            => modulok.Sum(x=> gyartasAdatok[TipusMeghatarozas(x)]?.ElkeszitesiIdo ?? 0);
    }
}
