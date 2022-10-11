using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;
using ADODB;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace DigitalCricketScorer
{
    internal static class SQLUtils
    {
        private const string CRICKET_DATABASE = "CricketDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + CRICKET_DATABASE + ";";

        public static void CreateDatabase()
        {
            CatalogClass cat = new CatalogClass();

            if (!File.Exists(CRICKET_DATABASE))
            {
                cat.Create(CONNECTION_STRING);
                CreateTables();
            }
        }

        private static void CreateTables()
        {
            string sqlString;

            sqlString = "CREATE TABLE tbl_Team("
                + "TeamID COUNTER NOT NULL,"
                + "Name VARCHAR(20) NOT NULL,"
                + "PRIMARY KEY (TeamID)"
                + ")";
            ExecuteSQL(sqlString);

            sqlString = "CREATE TABLE tbl_Player("
                + "PlayerID COUNTER NOT NULL,"
                + "FirstName VARCHAR(20) NOT NULL,"
                + "Surname VARCHAR(20) NOT NULL,"
                + "TeamID INT NOT NULL,"
                + "RunsScored INT NOT NULL DEFAULT 0,"
                + "BallsFaced INT NOT NULL DEFAULT 0,"
                + "StrikeRate DECIMAL(6,1) NOT NULL DEFAULT 0,"
                + "Fours INT NOT NULL DEFAULT 0,"
                + "Sixes INT NOT NULL DEFAULT 0,"
                + "RunsConceded INT NOT NULL DEFAULT 0,"
                + "OversBowled DECIMAL(6,1) NOT NULL DEFAULT 0,"
                + "RPO DECIMAL(6,1) NOT NULL DEFAULT 0,"
                + "Wickets INT NOT NULL DEFAULT 0,"
                + "Maidens INT NOT NULL DEFAULT 0,"
                + "PRIMARY KEY (PlayerID),"
                + "FOREIGN KEY (TeamID) REFERENCES tbl_Team (TeamID)"
                + ")";
            ExecuteSQL(sqlString);

            sqlString = "CREATE TABLE tbl_Match("
                + "MatchID COUNTER NOT NULL,"
                + "MatchDay DATE NOT NULL,"
                + "HomeTeamID INT NOT NULL,"
                + "HomeRuns INT NOT NULL,"
                + "HomeWickets INT NOT NULL,"
                + "HomeExtras VARCHAR(20) NOT NULL,"
                + "AwayTeamID INT NOT NULL,"
                + "AwayRuns INT NOT NULL,"
                + "AwayWickets INT NOT NULL,"
                + "AwayExtras VARCHAR(20) NOT NULL,"
                + "TossWonByHome BIT NOT NULL,"
                + "TossChoseToBat BIT NOT NULL,"
                + "BallArray LONGTEXT NOT NULL,"
                + "PRIMARY KEY (MatchID),"
                + "FOREIGN KEY (HomeTeamID) REFERENCES tbl_Team (TeamID),"
                + "FOREIGN KEY (AwayTeamID) REFERENCES tbl_Team (TeamID)"
                + ")";
            ExecuteSQL(sqlString);
        }

        public static DataTable ExecuteSQL(string sqlString)
        {
            DataTable data = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand command = new OleDbCommand(sqlString))
                {
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command))
                    {
                        command.Connection = connection;

                        try
                        {
                            connection.Open();
                            dataAdapter.Fill(data);
                            connection.Close();
                            return data;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            return null;
        }

        public static Team LoadTeam(int teamID)
        {
            DataTable teamData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Team WHERE TeamID = " + teamID);
            DataTable playerData = SQLUtils.ExecuteSQL("SELECT * FROM tbl_Player WHERE TeamID = " + teamID);
            List<MatchPlayer> playerList = new List<MatchPlayer>();

            foreach (DataRow row in playerData.Rows)
            {
                playerList.Add(new MatchPlayer((int)row[0], row[1].ToString(), row[2].ToString()));
            }

            return new Team((int)teamData.Rows[0][0], teamData.Rows[0][1].ToString(), playerList);
        }

        public static void SaveMatchData(Match match)
        {
            try
            {
                string homeExtras = match.homeMatchTeam.extras.bye + "," + match.homeMatchTeam.extras.legBye + "," + match.homeMatchTeam.extras.wide + "," + match.homeMatchTeam.extras.noBall;
                string awayExtras = match.awayMatchTeam.extras.bye + "," + match.awayMatchTeam.extras.legBye + "," + match.awayMatchTeam.extras.wide + "," + match.awayMatchTeam.extras.noBall;
                bool tossChoseToBat;
                if (match.homeBattingFirst && match.tossWonByHome || !match.homeBattingFirst && !match.tossWonByHome)
                {
                    tossChoseToBat = true;
                }
                else
                {
                    tossChoseToBat = false;
                }
                ExecuteSQL("INSERT INTO tbl_Match (MatchDay, HomeTeamID, HomeRuns, HomeWickets, HomeExtras, AwayTeamID, AwayRuns, AwayWickets, AwayExtras, TossWonByHome, TossChoseToBat, BallArray) " +
                    "VALUES ('" + match.matchDate.ToShortDateString() + "', " + match.homeTeam.Id + ", " + match.homeMatchTeam.runCount + ", " + match.homeMatchTeam.wicketCount + ", '" + homeExtras + "', " + match.awayTeam.Id + ", " + match.awayMatchTeam.runCount + ", " + match.awayMatchTeam.wicketCount + ", '" + awayExtras + "', " + match.tossWonByHome + ", " + tossChoseToBat + ", '" + match.ballString + "')");
            }
            catch
            {
                MessageBox.Show("Error saving match data!", "Match saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }

            if (!SaveTeam(match.homeTeam)) Application.Exit();
            if (!SaveTeam(match.awayTeam)) Application.Exit();
        }

        private static bool SaveTeam(Team team)
        {
            try
            {
                foreach (MatchPlayer player in team.players)
                {
                    DataTable data = ExecuteSQL("SELECT * FROM tbl_Player WHERE PlayerID = " + player.Id);

                    int runs = Convert.ToInt32(data.Rows[0][4]) + player.batsmanStats.runsScored;
                    ExecuteSQL("UPDATE tbl_Player SET RunsScored = " + runs + " WHERE PlayerID = " + player.Id);
                    int balls = Convert.ToInt32(data.Rows[0][5]) + player.batsmanStats.balls;
                    ExecuteSQL("UPDATE tbl_Player SET BallsFaced = " + balls + " WHERE PlayerID = " + player.Id);
                    decimal strike = balls == 0 ? 0 : Math.Round((decimal)runs / balls * 100, 2);
                    ExecuteSQL("UPDATE tbl_Player SET StrikeRate = " + strike + " WHERE PlayerID = " + player.Id);
                    ExecuteSQL("UPDATE tbl_Player SET Fours = " + (Convert.ToInt32(data.Rows[0][7]) + player.batsmanStats.fours) + " WHERE PlayerID = " + player.Id);
                    ExecuteSQL("UPDATE tbl_Player SET Sixes = " + (Convert.ToInt32(data.Rows[0][8]) + player.batsmanStats.sixes) + " WHERE PlayerID = " + player.Id);

                    int runsC = Convert.ToInt32(data.Rows[0][9]) + player.bowlerStats.runsConceded;
                    ExecuteSQL("UPDATE tbl_Player SET RunsConceded = " + runsC + " WHERE PlayerID = " + player.Id);
                    decimal totalOvers = Convert.ToDecimal(data.Rows[0][10]);
                    totalOvers += player.bowlerStats.overs;
                    if (totalOvers % 1 > 0.5m)
                    {
                        totalOvers += 0.4m;
                    }
                    ExecuteSQL("UPDATE tbl_Player SET OversBowled = " + totalOvers + " WHERE PlayerID = " + player.Id);
                    decimal rpo = totalOvers == 0 ? 0 : Math.Round(runsC / ((totalOvers % 1 * 10 / 6) + (totalOvers - (totalOvers % 1))), 2);
                    ExecuteSQL("UPDATE tbl_Player SET RPO = " + rpo + " WHERE PlayerID = " + player.Id);
                    ExecuteSQL("UPDATE tbl_Player SET Wickets = " + (Convert.ToInt32(data.Rows[0][12]) + player.bowlerStats.wickets) + " WHERE PlayerID = " + player.Id);
                    ExecuteSQL("UPDATE tbl_Player SET Maidens = " + (Convert.ToInt32(data.Rows[0][13]) + player.bowlerStats.maidens) + " WHERE PlayerID = " + player.Id);
                }
            }
            catch
            {
                MessageBox.Show("Error saving team data!", "Team saving", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
    }
}
