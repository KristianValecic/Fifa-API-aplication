using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.Model
{
    public class Settings
    {
        private const string PARAMS_PATH = "starting_parameters.txt";
        private const string FAVORITES_PATH = "favorites.txt";
        private const char DELIM = '|';
       
        public List<Player> players = new List<Player>();

        public bool IsMale { get; set; }
        
        public bool IsOnline { get; set; }

        public Team SelectedTeam { get; set; }

        //public string TeamCode { get; set; }
        
        //public string Culture { get; set; }


        private string FormatForFileLine()
            => $"{IsMale}{DELIM}{IsOnline}{DELIM}{SelectedTeam.FifaCode}"; //dodati jezik

        //=> $"{IsMale}{DELIM}{IsOnline}{DELIM}{TeamCode}"; //dodati jezik

        private static string FormatFavoritesForFileLine(Player player)
            => $"{player.Name}{DELIM}{player.ShirtNumber}\n"; //dodati jezik

        public bool IfSettingsFileExists()
        {
            if (!File.Exists(PARAMS_PATH))
            {
                return false;
            }
            return true;
        }


        public bool FavoritesFileExists()
        {
            if (!File.Exists(FAVORITES_PATH))
            {
                return false;
            }
            return true;
        }

        public void SaveSettings()
        {
            if (!File.Exists(PARAMS_PATH))
            {
                File.Create(PARAMS_PATH).Close();
            }
            File.WriteAllText(PARAMS_PATH, FormatForFileLine());
        }

        public void SaveFavoritePlayer(List<Player> players)
        {
            if (!File.Exists(FAVORITES_PATH))
            {
                File.Create(FAVORITES_PATH).Close();
            }

            //clears file
            File.Create(FAVORITES_PATH).Close(); 

            //writes all players in file
            players.ForEach(p => File.AppendAllText(FAVORITES_PATH, FormatFavoritesForFileLine(p)));

        }

        public void ReadFromFile()
        {
            string[] text = File.ReadAllText(PARAMS_PATH).Split(DELIM);
            IsMale = bool.Parse(text[0]);
            IsOnline = bool.Parse(text[1]);
            SelectedTeam = Team.ParseFromFileLine(text[2]);
        }

        public void LoadFavorites()
        {
            string[] lines = File.ReadAllLines(FAVORITES_PATH);
            foreach (var l in lines)
            {
                string[] details = l.Split(DELIM); 
                players.Add(new Player
                {
                    Name = details[0],
                    ShirtNumber = int.Parse(details[1]),
                    //Favorite = true
                });
            }
            File.Delete(FAVORITES_PATH);
        }
    }
}
