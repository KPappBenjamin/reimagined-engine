namespace Eloadasok_Lib
{
    public class Performance
    {
        const int AVAILABLE_SEATS = 130;

        public string Name { get; init; }
        public int CategoryPrice1 { get; init; }
        public int Amount1 { get; init; }
        public int CategoryPrice2 { get; init;}
        public int Amount2 { get; init;}

        public int FreeSeats => AVAILABLE_SEATS -  (Amount1 + Amount2);
        public int SumAudience => Amount1 + Amount2;
        public int Profit => (Amount1*CategoryPrice1) + (Amount2*CategoryPrice2);

        public Performance(string lineOfData){
            string[] separated = lineOfData.Split(';');

            Name = separated[0];
            CategoryPrice1 = int.Parse(separated[1]);
            Amount1 = int.Parse(separated[2]);
            CategoryPrice2 = int.Parse(separated[3]);
            Amount2 = int.Parse(separated[4]);
        }
    }
}
