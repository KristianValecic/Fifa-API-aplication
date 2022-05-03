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

        //private const int listLimit = 3;

        public TeamViewForm()
        {
            InitializeComponent();
        }


        private void LoadFlpPlayers()
        {
            List<Player> players = matches.ElementAt(0).GetPlayerFromTeam(team);

            players.ForEach(p =>
            {
                flpPlayers.Controls.Add(
                    new PlayerContainer {
                        //p.Captain ? player = p : player = p,
                        player = p
                    }
                );
            });
            //////////////////////
            //TO DO:////////////
            // dodavanje favorita popravi....
            // posebno punjenje liste za flpFav i flpPlayer
           
        }

        private void TeamViewForm_Load(object sender, EventArgs e)
        {
            LoadFlpPlayers();
        }

        private void MoveToFavorites_Click(object sender, EventArgs e)
        {
            //if (flpFavorites.Controls.Count == listLimit)
            if (flpFavorites.Controls.Count == PlayerContainer.GetListLimit() ||
                (PlayerContainer.selectedList.Count > (PlayerContainer.GetListLimit() - flpFavorites.Controls.Count) &&
                flpFavorites.Controls.Count != 0)) // Mora provjeriti je li odabrano previse igraca
            {
                MessageBox.Show($"Lista favorita prima samo {PlayerContainer.GetListLimit()} igrača");
                return;
            }
            //PlayerContainer.ResetCounter();
            AddPlayersToList(PlayerContainer.selectedList, flpFavorites.Controls);
        }


        private void RemoveFromFavorites_Click(object sender, EventArgs e)
        {
            AddPlayersToList(PlayerContainer.selectedListFavorites, flpPlayers.Controls);
        }

        private void AddPlayersToList(List<PlayerContainer> fromList, Control.ControlCollection toList)
        {

            fromList.ForEach(p => {
                p.BackColor = Color.White;
                toList.Add(p);
            });

            fromList.Clear();
        }
    }
}
