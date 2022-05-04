using Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class TeamViewForm : Form
    {
        public IList<Match> matches;
        public Team team;

        private Settings settings = new Settings();
        //private const int listLimit = 3;

        public TeamViewForm()
        {
            InitializeComponent();
        }

        private void LoadFlpPlayers()
        {
            List<Player> players = matches.ElementAt(0).GetPlayerFromTeam(team);

            if (settings.FavoritesFileExists())
            {
                //flpFavorites.Controls.Add(settings.LoadFavorites());
                LoadflpFavorites(players);
            }

            players.ForEach(p =>
            {
                flpPlayers.Controls.Add(
                    new PlayerContainer {
                        player = p
                    }
                );
            });
            //////////////////////
            ////////TO DO:///////
            //Popravi da se savea i kada se zatvori samo galvna forma
        }

        private void LoadflpFavorites(List<Player> players)
        {
            settings.LoadFavorites();
            foreach (Player p in settings.players)
            {
                Player player = players.FirstOrDefault(p.Equals);
                player.Favorite = true;
                players.Remove(player);
                flpFavorites.Controls.Add(
                new PlayerContainer
                {
                    player = player
                });
            }
        }

        private void TeamViewForm_Load(object sender, EventArgs e)
        {
            LoadFlpPlayers();
        }

        private void MoveToFavorites_Click(object sender, EventArgs e)
        {
            if (flpFavorites.Controls.Count == PlayerContainer.GetListLimit() ||
            (PlayerContainer.selectedList.Count > (PlayerContainer.GetListLimit() - flpFavorites.Controls.Count) &&
            flpFavorites.Controls.Count != 0))
            {
                MessageBox.Show($"Lista favorita prima samo {PlayerContainer.GetListLimit()} igrača");
                return;
            }
            CheckIfSelected(PlayerContainer.selectedList.Count == 0 );
            AddPlayersToList(PlayerContainer.selectedList, flpFavorites.Controls, true);
        }

        private void CheckIfSelected(bool condition)
        {
            if (condition)
            {
                MessageBox.Show("Odaberite igrače");
                return;
            }
        }

        private void RemoveFromFavorites_Click(object sender, EventArgs e)
        { 
            CheckIfSelected(PlayerContainer.selectedListFavorites.Count == 0);
            AddPlayersToList(PlayerContainer.selectedListFavorites, flpPlayers.Controls, false);
        }

        private void AddPlayersToList(List<PlayerContainer> fromList, Control.ControlCollection toList, bool isFav)
        {
            fromList.ForEach(p => {
                p.BackColor = Color.White;
                p.player.Favorite = isFav;
                p.ShowFavoriteStar();
               toList.Add(p);
            });

            fromList.Clear();
            SaveFavorites();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
           SaveFavorites();
        }

        private void SaveFavorites()
        {
            List<Player> tempList = new List<Player>();

            foreach (PlayerContainer c in flpFavorites.Controls)
            {
                tempList.Add(c.player);
            }
                settings.SaveFavoritePlayer(tempList);
        }
    }
}
