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
        private List<Player> allPlayers = new List<Player>();
        private List<Player> playersListForSort = new List<Player>();
        private List<Player> players = new List<Player>();
        private bool teamHasFavorites = false;
        private bool initialLoad = true;


        public TeamViewForm()
        {
            InitializeComponent();
            InitOpenFileDialog();
        }

        private void TeamViewForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            LoadFavoritePlayers();
            LoadFlpPlayers();
            LoadListOfPlayers();
            LoadflpFavorites();
        }

        private void LoadFavoritePlayers()
        {
            if (favoritePlayers.IfFileExists())
            {
                SetFavorites(allPlayers);
            }
        }


        private void LoadListOfPlayers()
        {
            if (initialLoad == true)
            {
                allPlayers.ForEach(playersListForSort.Add);
                initialLoad = false;
            }

            flpList.Controls.Clear();

            playersListForSort.ForEach(p =>
            {
                flpList.Controls.Add(
                    new PlayerContainerRow
                    {
                        player = p
                    }
                );
            });
        }

        private void LoadFlpPlayers()
        {
            allPlayers.ForEach(players.Add);

            players.ForEach(p =>
             {
                 if (p.Favorite == false)
                 {
                     flpPlayers.Controls.Add(
                         new PlayerContainer
                         {
                             player = p
                         }
                     );
                 }
             }) ;
        }

        private void InitOpenFileDialog()
        {
            ofd.Filter = "Pictures|*.jpeg;*.jpg;*.png;|All files|*.*";
            ofd.Title = "Load pictures...";
            ofd.InitialDirectory = Application.StartupPath;
        }

        private void SetFavorites(List<Player> players)
        {
            foreach (Player p in favoritePlayers.favoritePlayersList)
            {
                Player player = players.FirstOrDefault(p.Equals);
                if (player != null)
                {
                    player.Favorite = true;
                }
            }
        }

        private void LoadflpFavorites()
        {
            allPlayers.ForEach(p => { 
                if (p != null && p.Favorite == true)
                {
                    players.Remove(p);
                        flpFavorites.Controls.Add(
                        new PlayerContainer
                        {
                            player = p
                        });
                }
            });
        }

        private void LoadPlayers()
        {
            allPlayers = matches.ElementAt(0).GetPlayersFromTeam(team); //samo prvobitno da dobijes 
            foreach (var match in matches)
            {
                //var tempPlayers = new List<Player>();
                //match.GetAllPlayersGoalsCards();
                //if (match.HasGoalOrCardEvent(team))
                //{
                    var tempPlayers = match.GetPlayersFromTeam(team);
                    tempPlayers.ForEach(p => {
                        //if (match.PlayerHasGoalOrCardEvent(p))
                        //{
                            match.GetAllPlayerGoalsCards(p, team);
                            allPlayers.ForEach((player) =>
                            {
                                if (p.Equals(player) && (p.Goals != 0 && p.YellowCards != 0))
                                {
                                    player.Goals += p.Goals;
                                    player.YellowCards += p.YellowCards;
                                }
                            }); 
                        //}
                    }); 
                //}
            }
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
            LoadListOfPlayers();
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
            favoritePlayers.favoritePlayersList = tempList;
            //if (flpFavorites.Controls.Count != 0)
            //{
                favoritePlayers.SaveToFile(); 
            //}
        }

        private void AddPlayerImg_Click(object sender, EventArgs e) => LoadPictures();

        private void LoadPictures()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var selectedList = PlayerContainer.selectedList.Concat(PlayerContainer.selectedListFavorites);
                foreach (PlayerContainer plContainer in selectedList)
                {
                    plContainer.ChangeImage(Image.FromFile(ofd.FileName), ofd.FileName);
                }
            }
            LoadListOfPlayers();
        }

        private void RemoveImage_click(object sender, EventArgs e) => RemovePictures();

        private void RemovePictures()
        {
            var selectedList = PlayerContainer.selectedList.Concat(PlayerContainer.selectedListFavorites);
            foreach (PlayerContainer plContainer in selectedList)
            {
                plContainer.DefaultImage();
            }
            LoadListOfPlayers();
        }

        private void SortYellowCards_Click(object sender, EventArgs e)
        {
            playersListForSort.Sort((a, b) => -a.YellowCards.CompareTo(b.YellowCards));
            LoadListOfPlayers();
        }

        private void SortGoals_Click(object sender, EventArgs e)
        {
            playersListForSort.Sort((a, b) => -a.Goals.CompareTo(b.Goals));
            LoadListOfPlayers();
        }
    }
}
