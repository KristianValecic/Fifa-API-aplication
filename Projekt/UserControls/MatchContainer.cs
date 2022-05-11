using Lib.Model;
using Lib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.UserControls
{
    public partial class MatchContainer : UserControl
    {
        public Match match;

        public MatchContainer()
        {
            InitializeComponent();
        }

        private void MatchContainer_Load(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void SetLabels()
        {
            lbMatchLocation.Text = match.Venue;
            PlayerContainerUtils.Center(lbMatchLocation, this.Width);
            lbVisitorsCount.Text = match.Attendance.ToString();
            lbHomeTeamName.Text = match.HomeTeam.Country;
            lbAwayTeamName.Text = match.AwayTeam.Country;

            //lbHomeTeamGoals.Text = match.HomeTeam.GoalsFor.ToString();
            //lbAwayTeamGoals.Text = match.AwayTeam.GoalsFor.ToString();
            lbAwayTeamGoals.Text = match.AwayTeam.Goals.ToString();
            lbHomeTeamGoals.Text = match.HomeTeam.Goals.ToString();
        }
    }
}
