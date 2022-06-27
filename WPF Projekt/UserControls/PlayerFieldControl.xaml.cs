﻿using Lib.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Projekt.Windows;

namespace WPF_Projekt.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerFieldControl.xaml
    /// </summary>
    public partial class PlayerFieldControl : UserControl
    {
        public Team Team { get; set; }
        public Player Player { get; set; }
        public Match Match { get; set; }

        public PlayerFieldControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lblPlrName.Content = Player.Name;
            lblPlrShrtNmbr.Content = Player.ShirtNumber;
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ChosenPlayerWindow cpw = new ChosenPlayerWindow();

            cpw.Player = Player;
            cpw.Team = Team;
            cpw.Match = Match;

            cpw.Show();
        }
    }
}
