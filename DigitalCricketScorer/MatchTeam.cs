using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCricketScorer
{
    public class MatchTeam
    {
        public int runCount;
        public int wicketCount;
        public Extras extras;
    }

    public struct Extras
    {
        public int bye;
        public int legBye;
        public int wide;
        public int noBall;
    }
}
