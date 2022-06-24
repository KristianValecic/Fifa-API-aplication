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
        public Team selectedTeam { get; set; }
        public Team oppponentTeam { get; set; }
        public Match match { get; set; }

        private IList<Player> selectedPlayers;
        private IList<Player> opponentPlayers;

        // TODO load player image
        public FieldPositionWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            selectedPlayers = match.GetStartingEleven(selectedTeam);
            opponentPlayers = match.GetStartingEleven(oppponentTeam);

            SetPlayerPositons(selectedPlayers);
            SetOpponentPlayerPositons(opponentPlayers);

        }

        //private void SetOpponentPlayerPositons(IList<Player> Players)
        //{
        //    foreach (Player plr in Players)
        //    {
        //        PlayerFieldControl pfc = new PlayerFieldControl();
        //        pfc.lblPlrName.Content = plr.Name;
        //        pfc.lblPlrShrtNmbr.Content = plr.ShirtNumber;

        //        if (plr.Position == nameof(PlayerPosition.Goalie))
        //        {
        //            gridField.RowDefinitions.Add(new RowDefinition());

        //            gridField.Children.Add(pfc);
        //            Grid.SetRow(pfc, gridField.RowDefinitions.Count - 1);
        //        }
        //        else if (plr.Position == nameof(PlayerPosition.Defender))
        //        {

        //        }
        //        else if (plr.Position == nameof(PlayerPosition.Midfield))
        //        {

        //        }
        //        else if (plr.Position == nameof(PlayerPosition.Forward))
        //        {

        //        }
        //    }
        //}

        private void SetOpponentPlayerPositons(IList<Player> Players)
        {
            foreach (Player plr in Players)
            {
                PlayerFieldControl pfc = new PlayerFieldControl();

                //string[] name = plr.Name.Split(' ');
                //pfc.lblPlrName.Content = name[0];
                //pfc.lblPlrSurame.Content = name[1];
                //pfc.lblPlrShrtNmbr.Content = plr.ShirtNumber;
                pfc.lblPlrName.Content = plr.Name;
                pfc.lblPlrShrtNmbr.Content = plr.ShirtNumber;

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

                //string[] name = plr.Name.Split(' ');
                //pfc.lblPlrName.Content = name[0];
                //pfc.lblPlrSurame.Content = name[1];
                //pfc.lblPlrShrtNmbr.Content = plr.ShirtNumber;
                pfc.lblPlrName.Content = plr.Name;
                pfc.lblPlrShrtNmbr.Content = plr.ShirtNumber;

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
    }
}
