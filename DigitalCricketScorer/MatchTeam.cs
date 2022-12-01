using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCricketScorer
{
    /// <summary>
    /// Class holding data for a team in the current match that may change during its duration
    /// </summary>
    public class MatchTeam
    {
        public int runCount;
        public int wicketCount;
        public Extras extras;
    }

    public struct Extras
    {
        public int bye { get; set; }
        public int legBye { get; set; }
        public int wide { get; set; }
        public int noBall { get; set; }
    }
}
