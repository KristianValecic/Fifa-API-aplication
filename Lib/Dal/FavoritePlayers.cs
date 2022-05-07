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

        public List<Player> favoritePlayersList = new List<Player>();

        public bool IfFileExists()
        {
            if (!File.Exists(FAVORITES_PATH))
            {
                SaveToFile();
                return false;
            }
            LoadFromFile();
            return true;
        }

        private string FormatForFileLine(Player player) // probaj maknu playera
            => $"{player.Name}{DELIM}{player.ShirtNumber}\n";


        public void LoadFromFile()  // mozda on treba provjeravati je li postoji igrac iz tima, ne neka duga funkcija
        {
            string[] lines = File.ReadAllLines(FAVORITES_PATH);
            if (lines.Length == 0)
            {
                return;
            }
            foreach (var l in lines)
            {
                string[] details = l.Split(DELIM);
                favoritePlayersList.Add(new Player
                {
                    Name = details[0],
                    ShirtNumber = int.Parse(details[1]),
                });
            }
        }

        public bool FavoritesExist()
        {
            if (favoritePlayersList.Count == 0)
            {
                return false;
            }
            return true;
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
            favoritePlayersList.ForEach(p => File.AppendAllText(FAVORITES_PATH, FormatForFileLine(p)));
        }
    }
}
