using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchDetailsManagementSys
{
    internal class MatchManagement
    {
        List<MatchDetails> matches;

        public MatchManagement() { 
            matches = new List<MatchDetails>() {
            new MatchDetails(1,"Cricket",new DateTime(2022,7,15,10,0,0),"Wankhede","India", "Australia",356,351),
            new MatchDetails(2,"Football",new DateTime(2022,7,16,10,0,0),"Camp Nou","Barcelona", "Real Madrid",2,3),
            new MatchDetails(3,"Kabaddi",new DateTime(2022,7,17,10,0,0),"NSCI Dome","UMumba", "Patna Pirates",40,37),
            new MatchDetails(4,"Cricket",new DateTime(2022,7,18,10,0,0),"MCG","Australia", "Newzealand",160,151),
            new MatchDetails(5,"Football",new DateTime(2022,7,19,10,0,0),"Old Trafford","Manchester United", "Manchester City",3,1),
            new MatchDetails(6,"Kabaddi",new DateTime(2022,7,20,10,0,0),"Gachibowli Indoor Stadium","Telugu Titans", "Bengal Warriors",32,35)
            };
        }

        public void AddMatch(MatchDetails match)
        {   
            if(IsValidMatch(match) == true) {
                matches.Add(match);
                Console.WriteLine("Matches added successfully");
            }
            else
            {
                Console.WriteLine("Enter correct value");
            }
        }

        public void DisplayMatches()
        {
            if(matches.Count != null)
            {
                foreach(MatchDetails match in matches)
                {
                    //Console.WriteLine("MatchId : ",match.MatchId);
                    //Console.WriteLine("Sports : ", match.Sports);
                    //Console.WriteLine("MatchDateTime : ", match.MatchDateTime);
                    //Console.WriteLine("Location : ",match.Location);
                    //Console.WriteLine("HomeTeam : ", match.HomeTeam);
                    //Console.WriteLine("HomeTeamScore : ", match.HomeTeamScore);
                    //Console.WriteLine("AwayTeam : ", match.AwayTeam);
                    //Console.WriteLine("AwayTeamScore : ", match.AwayTeamScore);
                    Console.WriteLine(match);
                }
            }
            else {
                Console.WriteLine("Match details is Empty");
            }
        }

        public void DisplayMatchDetails()
        {
            Console.WriteLine("Enter the id of Match : ");
            int Id = int.Parse(Console.ReadLine());
            MatchDetails matchDetails = matches.FirstOrDefault(a => a.MatchId == Id);
            if(matchDetails != null)
            {
                //Console.WriteLine("MatchId : ", matchDetails.MatchId);
                //Console.WriteLine("Sports : ", matchDetails.Sports);
                //Console.WriteLine("MatchDateTime : ", matchDetails.MatchDateTime);
                //Console.WriteLine("Location : ", matchDetails.Location);
                //Console.WriteLine("HomeTeam : ", matchDetails.HomeTeam);
                //Console.WriteLine("HomeTeamScore : ", matchDetails.HomeTeamScore);
                //Console.WriteLine("AwayTeam : ", matchDetails.AwayTeam);
                //Console.WriteLine("AwayTeamScore : ", matchDetails.AwayTeamScore);
                Console.WriteLine(matchDetails);  
            }
            else
            {
                Console.WriteLine("Matches no found");
            }
        }

        public void UpdateMatchScore()
        {
            Console.WriteLine("Enter Match Id:");
            int updatematchid = int.Parse(Console.ReadLine());
            
            MatchDetails matchDetails = matches.FirstOrDefault(a => a.MatchId == updatematchid);
            if (matchDetails != null)
            {
                Console.WriteLine("Enter Home Team Score:");
                int updatehometeamscore = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Away Team Score:");
                int updateawayteamscore = int.Parse(Console.ReadLine());

                matchDetails.HomeTeamScore = updatehometeamscore;
                matchDetails.AwayTeamScore = updateawayteamscore;                  
                Console.WriteLine("Match Detail updated successfully");
            }
            else
            {
                Console.WriteLine("Match Detail not found");
            }
        }

        public void RemoveMatch()
        {
            Console.WriteLine("Enter the MatchId to remove");
            int mid = int.Parse(Console.ReadLine());
            MatchDetails matchDetails = matches.FirstOrDefault(a => a.MatchId == mid);
            if (matchDetails != null)
            {
                matches.Remove(matchDetails);
                Console.WriteLine("Match Detail deleted successfully");
            }
            else
            {
                Console.WriteLine("Match Detail not found");
            }
        }

        public void SortMatches()
        {
            Console.WriteLine("Sort by: (date/sport/location)");
            string criteria = Console.ReadLine();
            Console.WriteLine("Ascending? (true/false)");
            bool ascending = bool.Parse(Console.ReadLine());
            switch (criteria.ToLower())
            {
                case "date":
                    matches = ascending ? matches.OrderBy(m => m.MatchDateTime).ToList() : matches.OrderByDescending(m => m.MatchDateTime).ToList();
                    break;
                case "sport":
                    matches = ascending ? matches.OrderBy(m => m.Sports).ToList() : matches.OrderByDescending(m => m.Sports).ToList();
                    break;
                case "location":
                    matches = ascending ? matches.OrderBy(m => m.Location).ToList() : matches.OrderByDescending(m => m.Location).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid sorting criteria.");
                    break;
            }
        }

        public List<MatchDetails> FilterMatches()
        {
            Console.WriteLine("Filter by: (sport/location/daterange)");
            string criteria = Console.ReadLine();
            Console.WriteLine("Enter value: ");
            string value = Console.ReadLine();
            switch (criteria.ToLower())
            {
                case "sport":
                    return matches.Where(m => m.Sports.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                case "location":
                    return matches.Where(m => m.Location.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                case "daterange":
                    DateTime startDate;
                    DateTime endDate;
                    if (DateTime.TryParse(value.Split('-')[0], out startDate) && DateTime.TryParse(value.Split('-')[1], out endDate))
                    {
                        return matches.Where(m => m.MatchDateTime >= startDate && m.MatchDateTime <= endDate).ToList();
                    }
                    else
                    {
                        Console.WriteLine("Invalid date range format. Use format 'yyyy-mm-dd - yyyy-mm-dd'.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid filtering criteria.");
                    break;
            }

            return new List<MatchDetails>();
        }

        public void CalculateStatistics(string criteria)
        {
            switch (criteria.ToLower())
            {
                case "averagescore":
                    double homeAvg = matches.Average(m => m.HomeTeamScore);
                    double awayAvg = matches.Average(m => m.AwayTeamScore);
                    Console.WriteLine($"Average Score - Home: {homeAvg}, Away: {awayAvg}");
                    break;
                case "highestscore":
                    int highestHomeScore = matches.Max(m => m.HomeTeamScore);
                    int highestAwayScore = matches.Max(m => m.AwayTeamScore);
                    Console.WriteLine($"Highest Score - Home: {highestHomeScore}, Away: {highestAwayScore}");
                    break;
                case "lowestscore":
                    int lowestHomeScore = matches.Min(m => m.HomeTeamScore);
                    int lowestAwayScore = matches.Min(m => m.AwayTeamScore);
                    Console.WriteLine($"Lowest Score - Home: {lowestHomeScore}, Away: {lowestAwayScore}");
                    break;
                default:
                    Console.WriteLine("Invalid statistics criteria.");
                    break;
            }
        }

        public List<MatchDetails> SearchMatches(string keyword)
        {
            return matches.Where(m =>
                m.Sports.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.HomeTeam.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.AwayTeam.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                m.Location.Contains(keyword, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        private bool IsValidMatch(MatchDetails match)
        {
            if (match.MatchId <= 0 || matches.Any(m => m.MatchId == match.MatchId))
                return false;

            if (string.IsNullOrWhiteSpace(match.Sports))
                return false;

            if (match.MatchDateTime <= DateTime.Now)
                return false;

            if (string.IsNullOrWhiteSpace(match.Location))
                return false;

            if (string.IsNullOrWhiteSpace(match.HomeTeam) || string.IsNullOrWhiteSpace(match.AwayTeam) || match.HomeTeam == match.AwayTeam)
                return false;

            if (match.HomeTeamScore < 0 || match.AwayTeamScore < 0)
                return false;

            return true;
        }

    }
}
