using System.Xml.Linq;

namespace orszagok_Lib
{
    public class Orszag
    {
        public string Nev {  get; init; }
        public uint Terulet { get; init; }
        public long Lakossag { get; init; }
        public string Fovaros { get; init; }
        public int Tavolsag { get; init; }

        public Orszag(string input)
        {
            string[] line = input.Split(';');

            Nev = line[0];
            Terulet = uint.Parse(line[1]);
            Lakossag = long.Parse(line[2]) > 20000 ? long.Parse(line[2]) : 20000;
            Fovaros = line[3];
            if (int.Parse(line[4]) < 200)
                Tavolsag = 200;
            else if (int.Parse(line[4]) > 25000)
                Tavolsag = 25000;
            else
                Tavolsag = int.Parse(line[4]);
        }


        public string Info() => $"\tOrszág neve: {Nev}" +
                $"\n\tFővárosa: {Fovaros}" +
                $"\n\tTerülete: {Terulet} km2" +
                $"\n\tLakossága: {Lakossag} fő" +
                $"\n\tTávolság Budapesttől: {Tavolsag} km";
        public override string ToString()
        {
            return string.Join(';', Nev, Terulet, Lakossag, Fovaros, Tavolsag);
        }
    }
}
