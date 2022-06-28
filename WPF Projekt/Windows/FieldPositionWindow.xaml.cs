using Lib.Dal;
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
using WPF_Projekt.UserControls;

namespace WPF_Projekt.Windows
{
    /// <summary>
    /// Interaction logic for FieldPositionWindow.xaml
    /// </summary>
    public partial class FieldPositionWindow : Window
    {
        public Team SelectedTeam { get; set; }
        public Team OppponentTeam { get; set; }
        public Match Match { get; set; }

        private IList<Player> selectedPlayers;
        private IList<Player> opponentPlayers;
        private PlayerImageRepository playerImage = new PlayerImageRepository();

        // TODO load player image
        public FieldPositionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (PlayerImageRepository.IfFileExists())
            {
                playerImage.LoadFromFile();
            }

            selectedPlayers = Match.GetStartingEleven(SelectedTeam);
            opponentPlayers = Match.GetStartingEleven(OppponentTeam);

            SetPlayerPositons(selectedPlayers);
            SetOpponentPlayerPositons(opponentPlayers);
        }

        private void SetOpponentPlayerPositons(IList<Player> Players)
        {
            foreach (Player plr in Players)
            {
                PlayerFieldControl pfc = new PlayerFieldControl();

                SetPlayerFieldControl(pfc, plr, OppponentTeam);

                if (plr.Position == nameof(PlayerPosition.Goalie))
                {
                    pfc.Style = (Style)this.FindResource("styleOpponentGoalie");
                    gridField.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Defender))
                {
                    stckpnlOpponentDefender.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Midfield))
                {
                    stckpnlOpponentMidfield.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Forward))
                {
                    stckpnlOpponentForward.Children.Add(pfc);
                }
            }
        }

        private void SetPlayerPositons(IList<Player> Players)
        {
            foreach (Player plr in Players)
            {
                PlayerFieldControl pfc = new PlayerFieldControl();

                SetPlayerFieldControl(pfc, plr, SelectedTeam);

                if (plr.Position == nameof(PlayerPosition.Goalie))
                {
                    pfc.Style = (Style)this.FindResource("styleGoalie");
                    gridField.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Defender))
                {
                    stckpnlDefender.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Midfield))
                {
                    stckpnlMidfield.Children.Add(pfc);
                }
                else if (plr.Position == nameof(PlayerPosition.Forward))
                {
                    stckpnlForward.Children.Add(pfc);
                }
            }
        }

        private void SetPlayerFieldControl(PlayerFieldControl pfc, Player plr, Team team)
        {
            pfc.Match = Match;
            pfc.Team = team;
            pfc.Player = plr;
            if (PlayerImageRepository.PlayerHasPicture(plr.Name))
            {
                pfc.hasImg = true;
                pfc.imgPlr.Source = new BitmapImage(new Uri(PlayerImageRepository.GetImage(plr.Name)));
            }
        }
    }
}
