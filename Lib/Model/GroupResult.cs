using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class GroupResult
    {

        public static string TEAMS_OFFLINE_MEN_PATH = "../../../OfflineJSON/men/group_results.json";
        public static string TEAMS_OFFLINE_WOMEN_PATH = "../../../OfflineJSON/women/group_results.json";

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("ordered_teams")]
        public List<Team> OrderedTeams { get; set; }

        public static string GetEndpoint(bool isMale)
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
}
