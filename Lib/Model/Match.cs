using Lib.Dal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class Match
    {
        public const string MATCH_ONLINE_MEN_ENDPOINT = "http://world-cup-json-2018.herokuapp.com/matches";
        public const string MATCH_ONLINE_WOMEN_ENDPOINT = "http://worldcup.sfg.io/matches";

        public static string MATCH_OFFLINE_MEN_PATH = @"men\matches.json";
        public static string MATCH_OFFLINE_WOMEN_PATH = @"women\matches.json";

        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("fifa_id")]
        public long FifaId { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("attendance")]
        public long Attendance { get; set; }

        [JsonProperty("officials")]
        public List<string> Officials { get; set; }

        [JsonProperty("stage_name")]
        public string StageName { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("winner_code")]
        public string WinnerCode { get; set; }

        [JsonProperty("home_team")]
        public Team HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public Team AwayTeam { get; set; }

        [JsonProperty("home_team_events")]
        public List<TeamEvent> HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public List<TeamEvent> AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }

        [JsonProperty("last_event_update_at")]
        public string LastEventUpdateAt { get; set; }

        [JsonProperty("last_score_update_at")]
        public string LastScoreUpdateAt { get; set; }

        public override string ToString()
         //=> $"{Venue}, {Location} {Datetime} - {AwayTeam}, {AwayTeam}";
         => $"{Venue}, {Location}\t\t H:{HomeTeam.Country}, A:{AwayTeam.Country}";
        //=> $"{Venue}";
        //=> $"{IfIntIsNull(AwayTeamStatistics.FoulsCommitted)} {IfIntIsNull(HomeTeamStatistics.FoulsCommitted)}";
        //=> $"H: {HomeTeamStatistics.GetPlayers()}\nA: {AwayTeamStatistics.GetPlayers()}";

        public IEnumerable<Player> GetAllPlayers()
        {
            return HomeTeamStatistics.GetPlayers().Concat(AwayTeamStatistics.GetPlayers());
        }

        public IList<Player> GetStartingEleven(Team team)
        {
            if (HomeTeam.CompareCountryName(team))
            {
                return HomeTeamStatistics.StartingEleven;
            }
            else
            {
                return AwayTeamStatistics.StartingEleven;
            }
        }

        public List<Player> GetPlayersFromTeam(Team team)
        {
            if (HomeTeam.CompareCountryName(team))
            {
                return (List<Player>)HomeTeamStatistics.GetPlayers();
            }
            else 
            { 
                return (List<Player>)AwayTeamStatistics.GetPlayers();
            }
        }

        public List<TeamEvent> GetTeamEvents(Team team)
        {
            List<TeamEvent> teamEvents;
            if (team.CompareCountryName(HomeTeam))
            {
                teamEvents = HomeTeamEvents;
            }
            else
            {
                teamEvents = AwayTeamEvents;
            }
            return teamEvents;
        }

        public void GetAllPlayerGoalsCards(Player p, Team team)
        {
            List<TeamEvent> teamEvents;
            if (team.CompareCountryName(HomeTeam))
            {
                 teamEvents = HomeTeamEvents;
            }
            else
            {
                 teamEvents = AwayTeamEvents;

            }
            IList<TeamEvent> teamEventsList = teamEvents.FindAll(e => p.Name == e.Player);
            foreach (var teamEvent in teamEventsList)
            {
                if (teamEvent.TypeOfEvent == "goal")
                {
                    p.Goals += 1;
                }
                if (teamEvent.TypeOfEvent == "yellow-card")
                {
                    p.YellowCards += 1;
                }
            }
        }

        public Team GetTeamOpponent(Team team)
        {
            if (team.Country == HomeTeam.Country)
            {
                return AwayTeam;
            }
            else
            {
                return HomeTeam;
            }
        }

        public static string GetEndpoint(bool isOnline, bool isMale, string extension)
        {
            if (isOnline)
            {
                if (isMale)
                {
                    return "http://world-cup-json-2018.herokuapp.com/matches" + extension;
                }
                else
                {
                    return "http://worldcup.sfg.io/matches" + extension;
                }
            }
            else
            {
                if (isMale)
                {
                    return File.ReadAllText(MATCH_OFFLINE_MEN_PATH);
                }
                else
                {
                    return File.ReadAllText(MATCH_OFFLINE_WOMEN_PATH);
                }
            }
        }
    }
}
