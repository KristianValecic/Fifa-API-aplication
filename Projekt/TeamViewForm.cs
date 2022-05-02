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

        private const int listLimit = 3;

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
            if (flpFavorites.Controls.Count == listLimit)
            {
                MessageBox.Show("Lista favorita je puna");
                return;
            }

            List<PlayerContainer> selectedList = new List<PlayerContainer>();

            foreach (PlayerContainer item in flpPlayers.Controls)
            {
                if (item.selected)
                {
                    selectedList.Add(item);
                    item.BackColor = Color.White;
                    item.selected = false;
                }
                
            }
            selectedList.ForEach(flpFavorites.Controls.Add);
            PlayerContainer.ResetCounter(listLimit);
        }

        private void RemoveFromFavorites_Click(object sender, EventArgs e)
        {
            foreach (PlayerContainer item in flpFavorites.Controls)
            {
                if (item.selected)
                {
                    item.selected = false;
                    item.BackColor = Color.White;

                    flpFavorites.Controls.Remove(item); 
                    flpPlayers.Controls.Add(item);
                }
            }
        }
    }
}
