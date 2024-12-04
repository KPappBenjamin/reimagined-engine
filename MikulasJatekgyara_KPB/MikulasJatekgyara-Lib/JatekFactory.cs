using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public static class JatekFactory
    {
        public static Jatek Factory(string adatsor, GyartasAdatok gyartas)
        {
            string[] adatokTomb = adatsor.Split(';');
            return adatokTomb[1] switch
            {
                "i" => new InteraktivJatek(adatokTomb[0], adatokTomb[1], adatokTomb[2],
                gyartas, adatokTomb.Skip(3)),
                _ => new EgyszeruJatek(adatokTomb[0], adatokTomb[1], adatokTomb[2],
                gyartas)
            };
        }
    }
}
