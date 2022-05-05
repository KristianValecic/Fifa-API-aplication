using Lib.Dal;
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

        private OpenFileDialog ofd = new OpenFileDialog();
        private FavoritePlayers favoritePlayers = new FavoritePlayers();
        

        public TeamViewForm()
        {
            InitializeComponent();
            InitOpenFileDialog();
        }

        private void InitOpenFileDialog()
        {
            ofd.Filter = "Pictures|*.jpeg;*.jpg;*.png;|All files|*.*";
            //ofd.Multiselect = fasle;
            ofd.Title = "Load pictures...";
            ofd.InitialDirectory = Application.StartupPath;
        }

        private void LoadFlpPlayers()
        {
            List<Player> players = matches.ElementAt(0).GetPlayerFromTeam(team);

            if (favoritePlayers.IfFileExists())
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
            //
        }

        private void LoadflpFavorites(List<Player> players)
        {
            favoritePlayers.LoadFromFile();
            foreach (Player p in favoritePlayers.players)
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
            if (flpFavorites.Controls.Count >= PlayerContainer.GetListLimit() ||
            (PlayerContainer.selectedList.Count > (PlayerContainer.GetListLimit() - flpFavorites.Controls.Count)/* && flpFavorites.Controls.Count != 0*/) ||
            PlayerContainer.selectedList.Count > PlayerContainer.GetListLimit())
            {
                MessageBox.Show($"Lista favorita prima samo {PlayerContainer.GetListLimit()} igrača");
                return;
            }
            CheckIfSelected(PlayerContainer.selectedList.Count == 0 );
            AddPlayersToList(PlayerContainer.selectedList, flpFavorites.Controls, true);
        }

        public void AddPlayerToFavoriteList(List<PlayerContainer> selectedList)
        {
            selectedList.ForEach(p => {
                p.BackColor = Color.White;
                p.player.Favorite = true;
                p.ShowFavoriteStar();
                flpFavorites.Controls.Add(p);
            });

            selectedList.Clear();
            SaveFavorites();
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
            favoritePlayers.players = tempList;
            favoritePlayers.SaveToFile();
        }

        private void AddPlayerImg_Click(object sender, EventArgs e) => LoadPictures();

        private void LoadPictures()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var selectedList = PlayerContainer.selectedList.Concat(PlayerContainer.selectedListFavorites);
                foreach (PlayerContainer plContainer in selectedList)
                {
                    //plContainer.SetImage(Image.FromFile(ofd.FileName));
                    plContainer.ChangeImage(Image.FromFile(ofd.FileName), ofd.FileName);
                }
            }
        }

        private void RemoveImage_click(object sender, EventArgs e) => RemovePictures();

        private void RemovePictures()
        {
            var selectedList = PlayerContainer.selectedList.Concat(PlayerContainer.selectedListFavorites);
            foreach (PlayerContainer plContainer in selectedList)
            {
                plContainer.DefaultImage();
            }
        }
    }
}
