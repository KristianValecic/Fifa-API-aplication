using Lib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Dal
{
    public class FavoritePlayers : ISaveable
    {
        private const string FAVORITES_PATH = "favorites.txt";
        private const char DELIM = '|';

        public List<Player> players = new List<Player>();

        public bool IfFileExists()
        {
            if (!File.Exists(FAVORITES_PATH))
            {
                return false;
            }
            return true;
        }

        private string FormatForFileLine(Player player) // probaj maknu playera
            => $"{player.Name}{DELIM}{player.ShirtNumber}\n"; //dodati jezik


        public void LoadFromFile()
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
            //File.Delete(FAVORITES_PATH);
        }

        public void SaveToFile()
        {
            if (!File.Exists(FAVORITES_PATH))
            {
                File.Create(FAVORITES_PATH).Close();
            }

            //clears file
            File.Create(FAVORITES_PATH).Close();

            //writes all players in file
            players.ForEach(p => File.AppendAllText(FAVORITES_PATH, FormatForFileLine(p)));

        }
    }
}
