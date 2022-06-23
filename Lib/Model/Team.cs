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
    public class Team
    {
        public const string TEAMS_ONLINE_MEN_ENDPOINT = "http://world-cup-json-2018.herokuapp.com/teams/results";
        public const string TEAMS_ONLINE_WOMEN_ENDPOINT = "http://worldcup.sfg.io/teams/results";
        public static string TEAMS_OFFLINE_MEN_PATH = @"men\teams.json";
        public static string TEAMS_OFFLINE_WOMEN_PATH = @"women\teams.json";

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("games_played")]
        public int GamesPlayed { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("goals_for")]
        public int GoalsFor { get; set; }

        [JsonProperty("goals_against")]
        public int GoalsAgainst { get; set; }

        [JsonProperty("goal_differential")]
        public int GoalDifferential { get; set; }
        
        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
        public string DisplayName 
        { 
            get => $"{Country} ({((FifaCode != null) ? FifaCode : Code)})";
        }

        public override string ToString()
            //=> $"{Id} - {Country} '{FifaCode}' W:{Wins}, D:{Draws}, L:{Losses}";
            => $"/country?fifa_code={FifaCode}";

        //public string GetLinkString()
        //    => $"/country?fifa_code={FifaCode}";

        public override bool Equals(object obj)
            => obj is Team other && FifaCode == other.FifaCode;

        internal static Team ParseFromFileLine(string code)
        {
            return new Team { 
                FifaCode = code
            };
        }

        internal object FromatForFileLine()
            => $"{FifaCode}";    

        public static string GetEndpoint(bool isOnline, bool isMale)
        {
            if (isOnline) 
            {
                if (isMale)
                {
                    return "http://world-cup-json-2018.herokuapp.com/teams/results";
                }
                else
                {
                    return "http://worldcup.sfg.io/teams/results";
                }
            }
            else
            {
                if (isMale)
                {
                    return File.ReadAllText(TEAMS_OFFLINE_MEN_PATH);
                }
                else
                {
                    return File.ReadAllText(TEAMS_OFFLINE_WOMEN_PATH);
                }
            }
        }

        internal bool CompareCountryName(Team team)
            => Country == team.Country;
    }
}
