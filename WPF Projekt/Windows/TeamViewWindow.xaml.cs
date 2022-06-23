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
    /// Interaction logic for TeamViewWindow.xaml
    /// </summary>
    public partial class TeamViewWindow : Window
    {
        public Team team { get; set; }
        public List<Team> teams { get; set; }

        private Match currentMatch;
        public List<Match> matches = new List<Match>();
        private List<Team> opponentList =new List<Team>();
        public TeamViewWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblSelectedTeam.Content = team.DisplayName;
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            matches.ForEach(m =>
            {
                opponentList.Add(m.GetTeamOpponent(team));
                //cbOpponentTeams.Items.Add(m.GetTeamOpponent(team));
            });

            cbOpponents.SetBinding(
            ItemsControl.ItemsSourceProperty,
            new Binding { Source = opponentList });

            cbOpponents.DisplayMemberPath = nameof(Team.DisplayName);

            //cbOpponentTeams.SelectedValue = opponentList.First();
        }

        private void cbOpponentTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentMatch = matches.FirstOrDefault(m => m.GetTeamOpponent(team).Country == ((Team)cbOpponents.SelectedValue).Country);
            lblTeamGoals.Content = (currentMatch.HomeTeam.Country == team.Country) ? currentMatch.HomeTeam.Goals : currentMatch.AwayTeam.Goals;
            lblOpponentGoals.Content = (currentMatch.HomeTeam.Country == currentMatch.GetTeamOpponent(team).Country) ? currentMatch.HomeTeam.Goals : currentMatch.AwayTeam.Goals;
        }


        private void OpponentTeamDetail_Click(object sender, RoutedEventArgs e)
        {
            if (cbOpponents.SelectedItem != null)
            {
                OpenWinForTeam(teams.FirstOrDefault(t => t.Country == ((Team)cbOpponents.SelectedItem).Country));
            }
            else
            {
                lblOpponentValidation.Visibility = Visibility.Visible;
            }
        }
        private void SelectedTeamDetail_Click(object sender, RoutedEventArgs e)
        {
            //OpenWinForTeam(team);
            OpenWinForTeam(teams.FirstOrDefault(t => t.Country == team.Country));
        }

        private void OpenWinForTeam(Team team)
        {
            lblOpponentValidation.Visibility = Visibility.Hidden;
            WindowForTeam detailWin = new WindowForTeam();
            detailWin.team = team;
            detailWin.Show();
        }

        private void PlrPosition_Click(object sender, RoutedEventArgs e)
        {
            lblOpponentValidation.Visibility = Visibility.Hidden;
            if (cbOpponents.SelectedItem != null)
            {
                FieldPositionWindow fpw = new FieldPositionWindow();
                fpw.selectedTeam = team;
                fpw.oppponentTeam = (Team)cbOpponents.SelectedItem;
                fpw.match = currentMatch;
                fpw.Show();
            }
            else
            {
                lblOpponentValidation.Visibility = Visibility.Visible;
            }
        }
    }
}
