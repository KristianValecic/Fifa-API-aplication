﻿using Lib.Dal;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Projekt.Windows;

namespace WPF_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private const string HR = "hr", EN = "en";
        private Settings settings = new Settings();
        private IList<Team> teams;
        private static readonly IRepository repo = RepositoryFactory.GetRepo();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (settings.IfFileExists())
            {
                settings.LoadFromFile();
                SetSettings();
            }

            //if (settings.Culture == String.Empty)
            //{
            //    SetCulture(HR);
            //}
            //else
            //{
            //    SetCulture(settings.Culture);
            //}
        }
        // //////////
        //private void SetCulture(object hR)
        //{
        //    throw new NotImplementedException();
        //}

        private void SetSettings()
        {
            

            if (settings.IsMale)
            {
                rbMale.IsChecked = true;
                rbFemale.IsChecked = false;
            }
            else
            {
                rbMale.IsChecked = false;
                rbFemale.IsChecked = true;
            }

            if (settings.IsOnline)
            {
                rbOnline.IsChecked = true;
                rbOffline.IsChecked = false;
            }
            else
            {
                rbOnline.IsChecked = false;
                rbOffline.IsChecked = true;
            }

            switch (settings.ScreenSize)
            {
                case ScreenSizes.Small:
                    rbSmall.IsChecked = true;
                    rbMedium.IsChecked = false;
                    rbLarge.IsChecked = false;
                    break;
                case ScreenSizes.Medium:
                    rbSmall.IsChecked = false;
                    rbMedium.IsChecked = true;
                    rbLarge.IsChecked = false;
                    break;
                case ScreenSizes.Large:
                    rbSmall.IsChecked = false;
                    rbMedium.IsChecked = false;
                    rbLarge.IsChecked = true;
                    break;
                    // default:
                    //     break;
            }

            InitDataComboBoxAsync();
        }

        private async Task InitDataComboBoxAsync()
        {
            if (!IfChecked())
            {
                return;
            }

            try
            {
                teams = (settings.IsOnline) ? await repo.GetOnlineDataAsync<List<Team>>(Team.GetEndpoint(settings.IsOnline, settings.IsMale))
                                   : await repo.GetOfflineDataAsync<List<Team>>(Team.GetEndpoint(settings.IsOnline, settings.IsMale));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cbTeams.SetBinding(
            ItemsControl.ItemsSourceProperty,
            new Binding { Source = teams });

            //cbTeams.DataContext = teams;
            cbTeams.DisplayMemberPath = nameof(Team.DisplayName);
            cbTeams.SelectedValue = teams.First();
        }

        private bool IfChecked()
        {
            if ((rbFemale.IsChecked == true || rbMale.IsChecked == true) &&
                (rbOnline.IsChecked == true || rbOffline.IsChecked == true) /*&&
                (rbSmall.IsChecked == true || rbSmall.IsChecked == true || rbSmall.IsChecked == true)*/)
            {
                return true;
            }

            return false;
        }

        private void rbMale_Checked(object sender, RoutedEventArgs e)
        {
            settings.IsMale = true;
            InitDataComboBoxAsync();
        }

        private void rbFemale_Checked(object sender, RoutedEventArgs e)
        {
            settings.IsMale = false;
            InitDataComboBoxAsync();
        }

        private void rbOnline_Checked(object sender, RoutedEventArgs e)
        {
            settings.IsOnline = true;
            InitDataComboBoxAsync();
        }

        private void rbOffline_Checked(object sender, RoutedEventArgs e)
        {
            settings.IsOnline = false;
            InitDataComboBoxAsync();
        }

        private void ShowPlayers_Click(object sender, RoutedEventArgs e)
        {
            IfCheckScreenSize();

        }


        private void rbScreenSize_Checked(object sender, RoutedEventArgs e)
        {

            lbCheckedScreenSizeMessage.Visibility = Visibility.Hidden;
        }

        private void IfCheckScreenSize()
        {
            if (rbSmall.IsChecked == false && rbMedium.IsChecked == false && rbLarge.IsChecked == false)
            {
                lbCheckedScreenSizeMessage.Visibility = Visibility.Visible;
                return;
            }

            try
            {
                settings.SelectedTeam = teams.FirstOrDefault(cbTeams.SelectedItem.Equals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            settings.SaveToFile();
            OpenTeamViewWindowAsync();
        }

        private async Task OpenTeamViewWindowAsync()
        {
            TeamViewWindow teamViewWindow = new TeamViewWindow();
            teamViewWindow.team = settings.SelectedTeam;

            IList<Match> allMatches = new List<Match>();

            try
            {
                allMatches = (settings.IsOnline) ? await repo.GetOnlineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, settings.SelectedTeam.ToString()))
                                    : await repo.GetOfflineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, settings.SelectedTeam.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //find all matches that have that team

            foreach (var match in allMatches)
            {
                if (match.HomeTeam.Country == settings.SelectedTeam.Country || match.AwayTeam.Country == settings.SelectedTeam.Country)
                {
                    teamViewWindow.matches.Add(match);
                }
            }

            teamViewWindow.Show();
        }
    }
}