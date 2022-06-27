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
    /// Interaction logic for ChosenPlayerWindow.xaml
    /// </summary>
    public partial class ChosenPlayerWindow : Window
    {
        public Team Team { get; set; }
        public Player Player { get; set; }
        public Match Match { get; set; }

        public ChosenPlayerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblPlrName.Content = Player.Name;
            lblPlrNumber.Content = Player.ShirtNumber;
            lblPlrPosition.Content = Player.Position;
            lblPlrIsCaptain.Visibility = Player.Captain ? Visibility.Visible : Visibility.Hidden;
            lblPlrGoalCount.Content = Match.GetGoalsForPlayer(Player, Team);
            lblPlryellowCardCount.Content = Match.GetYellowCardsForPlayer(Player, Team);
        }
    }
}
