﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class TeamStatistics
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal")]
        public int? AttemptsOnGoal { get; set; }

        [JsonProperty("on_target")]
        public int? OnTarget { get; set; }

        [JsonProperty("off_target")]
        public int? OffTarget { get; set; }

        [JsonProperty("blocked")]
        public int? Blocked { get; set; }

        [JsonProperty("corners")]
        public int? Corners { get; set; }

        [JsonProperty("offsides")]
        public int? Offsides { get; set; }

        [JsonProperty("ball_possession")]
        public int? BallPossession { get; set; }

        [JsonProperty("pass_accuracy")]
        public int? PassAccuracy { get; set; }

        [JsonProperty("num_passes")]
        public int? NumPasses { get; set; }

        [JsonProperty("passes_completed")]
        public int? PassesCompleted { get; set; }

        [JsonProperty("distance_covered")]
        public int? DistanceCovered { get; set; }

        [JsonProperty("tackles")]
        public int? Tackles { get; set; }

        [JsonProperty("clearances")]
        public int? Clearances { get; set; }

        [JsonProperty("yellow_cards")]
        public int? YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public int? RedCards { get; set; }

        [JsonProperty("fouls_committed")]
        public int? FoulsCommitted { get; set; }

        [JsonProperty("tactics")]
        public string Tactics { get; set; }

        [JsonProperty("starting_eleven")]
        public List<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public List<Player> Substitutes { get; set; }

        public List<Player> GetPlayers()
        {
            StartingEleven.AddRange(Substitutes);
            return StartingEleven;
        }

        public string GetPlayerStrings()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Starting eleven: ");
            foreach (Player p in StartingEleven)
            {
                sb.Append(p);
                sb.Append(" ");
            }
            sb.Append("\nSubstitutes: ");
            foreach (Player p in Substitutes)
            {
                sb.Append(p);
                sb.Append(" ");
            }
            return sb.ToString();
        }

    }
}
