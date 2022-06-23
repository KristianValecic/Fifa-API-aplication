using Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Projekt.Windows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WindowForTeam : Window
    {
    public Team team { get; set; }
        public WindowForTeam()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblTeamTitle.Content = team.DisplayName;
            lblWins.Content = team.Wins;
            lblLoses.Content = team.Losses;
            lblDraws.Content = team.Draws;
            lblGamesPLayed.Content = team.GamesPlayed;
            lblGoalDiff.Content = team.GoalDifferential;
            lblGoalsAgainst.Content = team.GoalsAgainst;
            lblGoalsFor.Content = team.GoalsFor;
        }
    }
}
