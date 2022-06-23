using Lib.Dal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Model
{
    public enum ScreenSizes { 
        Small,
        Medium,
        Large,
        Fullscreen
    }
    public class Settings : ISaveable
    {
        private const string PARAMS_PATH = "starting_parameters.txt";
        private const char DELIM = '|';

        public bool IsMale { get; set; }
        
        public bool IsOnline { get; set; }

        public Team SelectedTeam { get; set; }

        public string Culture { get; set; }
        public ScreenSizes ScreenSize { get; set; }


        private string FormatForFileLine()
            => $"{IsMale}{DELIM}{IsOnline}{DELIM}{SelectedTeam.FifaCode}{DELIM}{Culture}{DELIM}{ScreenSize}"; //dodati jezik

        public bool IfFileExists()
        {
            if (!File.Exists(PARAMS_PATH))
            {
                return false;
            }
            return true;
        }

        public void SaveToFile()
        {
            if (!File.Exists(PARAMS_PATH))
            {
                File.Create(PARAMS_PATH).Close();
            }
            File.WriteAllText(PARAMS_PATH, FormatForFileLine());
        }

        public void LoadFromFile()
        {
            string[] text = File.ReadAllText(PARAMS_PATH).Split(DELIM);
            IsMale = bool.Parse(text[0]);
            IsOnline = bool.Parse(text[1]);
            SelectedTeam = Team.ParseFromFileLine(text[2]);
            Culture = text[3];
            ScreenSize = ParseSize(text[4]);
        }

        private ScreenSizes ParseSize(string size)
        {
            switch (size)
            {
                case "Small":
                    return ScreenSizes.Small;
                    break;
                case "Medium":
                    return ScreenSizes.Medium;
                    break;
                case "Large":
                    return ScreenSizes.Large;
                    break;
                case "Fullscreen":
                    return ScreenSizes.Fullscreen;
                    break;
                default:
                    return ScreenSizes.Small;
                    break;
            }
        }
    }
}
