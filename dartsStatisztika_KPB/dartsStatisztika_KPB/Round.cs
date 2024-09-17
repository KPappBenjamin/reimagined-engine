namespace dartsStatisztika_Lib
{
    public record Round(int Player, string FirstThrow, string SecondThrow, string ThirdThrow)
    {
        private Round(string[] data) 
            : this(Player : int.Parse(data[0]),
                   FirstThrow : data[1],
                   SecondThrow : data[2],
                   ThirdThrow : data[3] )
        { }

        public Round(string line) : this(line.Split(';'))
        {

        }

        public override string ToString()
        {
            return $"Játékos: {Player}, első dobás: {FirstThrow}, második dobás: {SecondThrow}";
        }
    }
}
