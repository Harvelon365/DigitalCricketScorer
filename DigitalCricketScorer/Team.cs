using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCricketScorer
{
    /// <summary>
    /// Class to store the data for a team that will not change during a match
    /// </summary>
    public class Team
    {
        public int Id { private set; get; }
        public string name { private set; get; }
        public List<MatchPlayer> players { private set; get; }

        public Team(int id, string name, List<MatchPlayer> players)
        {
            this.Id = id;
            this.name = name;
            this.players = players;    
        }
    }
}
