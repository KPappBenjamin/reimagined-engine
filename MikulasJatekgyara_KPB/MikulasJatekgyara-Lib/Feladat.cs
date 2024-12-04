using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikulasJatekgyara_Lib
{
    public class Feladat
    {
        public const int MAX_IDOTARTAM = 8 * 60;

        //JatekTipus;Darabszam
        public Jatek JatekTipus { get; init; }
        public int Darabszam { get; init; }

        public Feladat(Jatek jatekTipus, int darabszam)
        {
            JatekTipus = jatekTipus;
            Darabszam = darabszam;
            if (ElkeszitesiIdo > MAX_IDOTARTAM)
                throw new TulSokFeladatException();
        }

        public int ElkeszitesiIdo
            => JatekTipus.ElkeszitesiIdo * Darabszam;

        public override string ToString()
            => $"{JatekTipus.Megnevezes}: {Darabszam} db, " +
            $"elkészítési idő: {ElkeszitesiIdo} perc";

    }
}
