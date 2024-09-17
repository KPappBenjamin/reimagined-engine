

namespace szalagLib
{
    public record Rekesz(int SzalagraTetelIdeje, int Honnan, int Hova, int Tomeg)
    {
        
        private Rekesz(string[] adatsor)
            : this (SzalagraTetelIdeje : int.Parse(adatsor[0]),
                    Honnan : int.Parse(adatsor[1]),
                    Hova : int.Parse(adatsor[2]),
                    Tomeg : int.Parse(adatsor[3]))
        { }

        public Rekesz(string adatsor) : this(adatsor.Split(" "))
        {

        }

        public int szalagHossza = 200;


        public int SzallitasiTavolsag
            => Honnan > Hova ? szalagHossza - Honnan + Hova : Hova - Honnan;

        public int szalagSebesseg = 3;

        public int SzalarolLevetelIdeje 
            => SzalagraTetelIdeje + SzallitasiTavolsag * szalagSebesseg;

    }
}
