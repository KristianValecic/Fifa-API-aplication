using Lib.Dal;
using Lib.Model;
using Projekt.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MainForm : Form
    {
        public static bool closeWithoutConfirm;
        public static bool closePending;

        private const string HR = "hr", EN = "en";
        private static readonly IRepository repo = RepositoryFactory.GetRepo();
        private IList<Team> teams;
        private Settings settings = new Settings();
        private static DialogResult KeyResult;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (settings.IfFileExists())
            {
                ////otvori s postojecim postavkama.
                //this.Visible = false;
                SetSettings();
            }
            //nastavi s podesavanjem postavki
           SetCulture(HR);
        }

        private void SetSettings()
        {
            if (settings.IfFileExists())
            {
                settings.LoadFromFile(); 
            }

            if (settings.IsMale)
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
            }

            if (settings.IsOnline)
            {
                rbOnline.Checked = true;
                rbOffline.Checked = false;
            }
            else
            {
                rbOnline.Checked = false;
                rbOffline.Checked = true;
            }

            //SetCulture(settings.Culture);

            InitDataComboBox();
        }

        private async void InitDataComboBox()
        {
            if (!IfChecked())
            {
                return;
            }
            cbTeams.Visible = false;

            PicBoxLoadingAnimation.Visible = true;
            lblInstructionForComboBox.Visible = false;

            try
            {
                teams = (settings.IsOnline) ? await repo.GetOnlineDataAsync<List<Team>>(Team.GetEndpoint(settings.IsOnline, settings.IsMale))
                                   : await repo.GetOfflineDataAsync<List<Team>>(Team.GetEndpoint(settings.IsOnline, settings.IsMale));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cbTeams.DataSource = teams;
            cbTeams.DisplayMember = "FifaCode";

            TrySetSelectedTeam();

            PicBoxLoadingAnimation.Visible = false;
            cbTeams.Visible = true;
        }

        private void TrySetSelectedTeam()
        {
            if (settings.SelectedTeam != null)
            {
                cbTeams.SelectedItem = teams.FirstOrDefault(settings.SelectedTeam.Equals);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            settings.IsMale = true;
            InitDataComboBox();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            settings.IsMale = false;
            InitDataComboBox();
        }

        private void rbOffline_CheckedChanged(object sender, EventArgs e)
        {
            settings.IsOnline = false;
            InitDataComboBox();
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            settings.IsOnline = true;
            InitDataComboBox();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (!IfChecked() || lblInstructionForComboBox.Visible)
            {
                MessageBox.Show("Molim Vas odaberite potrebne opcije.");
                return;
            }
            settings.SelectedTeam = teams.FirstOrDefault(cbTeams.SelectedItem.Equals);
            //settings.TeamCode = cbTeams.SelectedItem.ToString();
            //Spremi postavke.
            settings.SaveToFile();
            OpenTeamViewForm();
        }

        private async Task OpenTeamViewForm()
        {
            //[1] is openned child form, mainForm is [0]
            TeamViewForm teamViewForm = new TeamViewForm();
            teamViewForm.team = settings.SelectedTeam;
            teamViewForm.parentForm = this;

            if (Application.OpenForms.Count >= 2)
            {
                //((TeamViewForm)Application.OpenForms[1]).closeWithoutConfirm = true;
                closeWithoutConfirm = true;
                Application.OpenForms[1].Close();
                //teamViewForm = (TeamViewForm)Application.OpenForms[1];
            }

            IList<Match> allMatches = new List<Match>();

            try
            {
               allMatches = (settings.IsOnline) ? await repo.GetOnlineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, teamViewForm.team.ToString()))
                                   : await repo.GetOfflineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, teamViewForm.team.ToString()));
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
                    teamViewForm.matches.Add(match); 
                }
            }

            this.Hide();
            if (!teamViewForm.Visible)
            {
                closeWithoutConfirm = false;
                teamViewForm.Show();
            }
        }

        private bool IfChecked()
        {
            if ((rbFemale.Checked || rbMale.Checked)&&
                (rbOnline.Checked || rbOffline.Checked))
            {
                return true;
            }
            return false;
        }

        public static void FormCloseConfirm(FormClosingEventArgs e)
        {
            if (/*e.CloseReason == CloseReason.ApplicationExitCall*/closeWithoutConfirm)
            {
                return;
            }
            else if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Application.Exit();
            }
            if (e.CloseReason == CloseReason.UserClosing && !closePending)
            {
                e.Cancel = true;
                closePending = true;
                ConfirmExitForm f = new ConfirmExitForm();
                f.Show();
            }
            //else
            //{
            //    e.Cancel = true;
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCloseConfirm(e);
            settings.SaveToFile();
        }

        private void SetCulture(string language)
        {
            var culture = new CultureInfo(language);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            settings.Culture = language;

            UpdateForm();
        }

        private void Cro_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == EN)
            {
                SetCulture(HR);
            }
        }

        private void Eng_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR )
            {
                SetCulture(EN);
            }
        }

        private void UpdateForm() //CultureInfo culture
        {
            this.Controls.Clear();
            InitializeComponent();
            SetSettings();
        }
    }
}
