using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MatchDetailsManagementSys
{
    internal class MatchDetails
    {
        public int MatchId { get; set; }
        public string Sports { get; set; }
        public DateTime MatchDateTime { get; set; }
        public string Location { get; set; }
        public string HomeTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public string AwayTeam { get; set; }
        public int AwayTeamScore { get; set; }
        public MatchDetails() { }
        public MatchDetails(int matchid,string sports,DateTime MatchDateTime,string location, string hometeam, string awayteam, int hometeamscore, int awayteamscore)
        {
            this.MatchId = matchid;
            this.Sports = sports;
            this.MatchDateTime = MatchDateTime;
            this.Location = location;
            this.HomeTeam = hometeam;
            this.AwayTeam = awayteam;
            this.HomeTeamScore = hometeamscore;
            this.AwayTeamScore = awayteamscore;
        }
        public override string ToString()
        {
            return $" MatchId: {MatchId}\n Sports: {Sports}\n MatchDateTime: {MatchDateTime}\n Location: {Location}\n HomeTeam: {HomeTeam}\n HomeTeamScore: {HomeTeamScore}\n AwayTeam: {AwayTeam}\n AwayTeamScore: {AwayTeamScore}";
        }
    }
}
