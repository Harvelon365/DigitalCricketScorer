using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCricketScorer
{
    public class MatchPlayer
    {
        [DisplayName("id")]
        public int Id { private set; get; }
        [DisplayName("First Name")]
        public string firstName { private set; get; }
        [DisplayName("Surname")]
        public string surname { private set; get; }

        public bool isValid = true;
        public bool isOut = false;

        public BatsmanStats batsmanStats;
        public BowlerStats bowlerStats;

        public MatchPlayer(int id, string firstName, string surname)
        {
            this.Id = id;
            this.firstName = firstName;
            this.surname = surname;
            batsmanStats = new BatsmanStats(firstName, surname, this);
            bowlerStats = new BowlerStats(firstName, surname, this);
        }

        public object[] GetBatsmanData()
        {
            return new object[] { batsmanStats.batsmanName, batsmanStats.runsScored, batsmanStats.balls, batsmanStats.fours, batsmanStats.sixes, batsmanStats.strikeRate };
        }
        
        public object[] GetBowlerData()
        {
            return new object[] { bowlerStats.bowlerName, bowlerStats.overs, bowlerStats.maidens, bowlerStats.runsConceded, bowlerStats.wickets, bowlerStats.rpo};
        }
    }

    public class BatsmanStats : INotifyPropertyChanged
    {
        public MatchPlayer player;

        [DisplayName("Batsman")]
        public string batsmanName { get; private set; }
        [DisplayName("Runs")]
        public int runsScored { get; set; } = 0;
        private int _balls;
        [DisplayName("Balls")]
        public int balls
        {
            get
            {
                return _balls;
            }
            set
            {
                _balls = value;
                NotifyPropertyChanged();
            }
        }
        [DisplayName("4s")]
        public int fours { get; set; } = 0;
        [DisplayName("6s")]
        public int sixes { get; set; } = 0;
        private decimal _strikeRate = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        [DisplayName("SR")]
        public decimal strikeRate
        {
            set
            {
                _strikeRate = value;
            }

            get
            {
                try
                {
                    _strikeRate = Math.Round((decimal)runsScored / balls * 100, 2);
                }
                catch (Exception)
                {
                    _strikeRate = 0;
                }

                return _strikeRate;
            }
        }
        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BatsmanStats(string firstName, string surname, MatchPlayer player)
        {
            batsmanName = firstName + " " + surname;
            this.player = player;
        }
    }

    public class BowlerStats : INotifyPropertyChanged
    {
        public MatchPlayer player;

        [DisplayName("Bowler")]
        public string bowlerName { get; private set; }
        private decimal _overs;
        [DisplayName("Overs")]
        public decimal overs
        {
            get
            {
                return _overs;
            }
            set
            {
                _overs = value;
                NotifyPropertyChanged();
            }
        }
        [DisplayName("Maidens")]
        public int maidens { get; set; } = 0;
        [DisplayName("Runs")]
        public int runsConceded { get; set; } = 0;
        [DisplayName("Wickets")]
        public int wickets { get; set; } = 0;
        private decimal _rpo = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        [DisplayName("RPO")]
        public decimal rpo
        {
            set
            {
                _rpo = value;
            }

            get
            {
                try
                {
                    _rpo = Math.Round(runsConceded / ((overs % 1 * 10 / 6) + (overs - (overs % 1))), 2);
                }
                catch (Exception)
                {
                    _rpo = 0;
                }

                return _rpo;
            }
        }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BowlerStats(string firstName, string surname, MatchPlayer player)
        {
            bowlerName = firstName + " " + surname;
            this.player = player;
        }
    }
}
