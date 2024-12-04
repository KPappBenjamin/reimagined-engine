namespace MikulasJatekgyara_Lib
{
    public class GyartasAdat
    {
        public GyartasAdat(string azonosito, string tipus, int elkeszitesiIdo)
        {
            Azonosito = azonosito;
            Tipus = tipus;
            ElkeszitesiIdo = elkeszitesiIdo;
        }

        //Azonosito;Tipus;ElkeszitesiIdo
        public string Azonosito { get;init; }
        public string Tipus { get;init; }
        public int ElkeszitesiIdo { get;init; }


    }
}
