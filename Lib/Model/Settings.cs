using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    public class Settings
    {
        private const string PATH = "starting_parameters.txt";
        private const char DELIM = '|';

        public bool IsMale { get; set; }
        
        public bool IsOnline { get; set; }

        public Team SelectedTeam { get; set; }

        //public string TeamCode { get; set; }
        
        //public string Culture { get; set; }


        private string FormatForFileLine()
            => $"{IsMale}{DELIM}{IsOnline}{DELIM}{SelectedTeam.FifaCode}"; //dodati jezik
            //=> $"{IsMale}{DELIM}{IsOnline}{DELIM}{TeamCode}"; //dodati jezik

        public bool IfFileExists()
        {
            if (!File.Exists(PATH))
            {
                return false;
            }
            return true;
        }

        public void SaveFile()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
            File.WriteAllText(PATH, FormatForFileLine());
        }

        public void ReadFromFile()
        {
            string[] text = File.ReadAllText(PATH).Split(DELIM);
            IsMale = bool.Parse(text[0]);
            IsOnline = bool.Parse(text[1]);
            SelectedTeam = Team.ParseFromFileLine(text[2]);
        }
    }
}
