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
            });

            cbOpponentTeams.SetBinding(
            ItemsControl.ItemsSourceProperty,
            new Binding { Source = opponentList });

            cbOpponentTeams.DisplayMemberPath = nameof(Team.DisplayName);

            //cbOpponentTeams.SelectedValue = opponentList.First();
        }



        //private void cbOpponentTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    cbOpponentTeams.Background = Brushes.Teal;
        //}
    }
}
