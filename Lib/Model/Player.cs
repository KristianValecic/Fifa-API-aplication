﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class Player
    {
        private int goals = 0;
        private int yellowcards = 0;

        public bool Favorite { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public int ShirtNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        public int Goals { get; set; }
        //    get => goals;
        //    set => goals += match.GetGoal(this);
        //}

        public int YellowCards { get; set; }

        public override string ToString()
         => $"{Name}, {ShirtNumber}, {Position}{(Captain ? ", Captain": "")}";

        public override bool Equals(object obj)
         => obj is Player other && Name == other.Name && ShirtNumber == other.ShirtNumber;

        public object FormatForTabel()
                 => $"{Name}, {ShirtNumber}\t\t{Position}{(Captain ? ", (Captain)" : "")}";
    }
}
