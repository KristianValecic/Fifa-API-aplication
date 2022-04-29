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
                        player = p,
                    }
                );
            });

            //plc.BackColor = Color.Black;
            
            //flpPlayers.Controls.Add(plc);
        }


        private void TeamViewForm_Load(object sender, EventArgs e)
        {
            LoadFlpPlayers();
        }
    }
}
