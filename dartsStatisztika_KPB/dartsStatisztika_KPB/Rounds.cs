using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dartsStatisztika_Lib
{
    public class Rounds
    {
        readonly List<Round> rounds;  
        
        public Rounds(IEnumerable<string> lineOfData)
        {
            rounds = new List<Round>();
            foreach (string line in lineOfData)
            { 
                rounds.Add(new Round(line));
            }
        }

        public int NumberOfRounds => rounds.Count;

        public int CountBullseyeOnThirdThrow() 
            => rounds.Count(x => x.ThirdThrow == "D25");

        public int CountPlayerSpecificSectorThrow(int playerNumber, string sector)
            => rounds.Where(x => x.Player == playerNumber).Count(x => x.FirstThrow == sector || x.SecondThrow == sector || x.ThirdThrow == sector);

        public int CountPlayerMaxPossibleThrow(int playerNumber)
            => rounds.Where(x => x.Player == playerNumber).Count(x => x.FirstThrow == "T20" && x.SecondThrow == "T20" && x.ThirdThrow == "T20");
    }
}
