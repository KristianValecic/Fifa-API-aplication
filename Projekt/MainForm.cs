using Lib.Dal;
using Lib.Model;
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
            settings.LoadFromFile();
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

            if (Application.OpenForms.Count == 2)
            {
                //((TeamViewForm)Application.OpenForms[1]).closeWithoutConfirm = true;
                closeWithoutConfirm = true;
                Application.OpenForms[1].Close();
                //teamViewForm = (TeamViewForm)Application.OpenForms[1];
            }

            //MessageBox.Show(Application.OpenForms.Count.ToString());

            try
            {
                teamViewForm.matches = (settings.IsOnline) ? await repo.GetOnlineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, teamViewForm.team.ToString()))
                                   : await repo.GetOfflineDataAsync<List<Match>>(Match.GetEndpoint(settings.IsOnline, settings.IsMale, teamViewForm.team.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (closeWithoutConfirm)
            {
                return;
            }
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Application.Exit();
            }
            else if (MessageBox.Show($"Želite li izaći iz forme", "Upozorenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ||
                    KeyResult == DialogResult.Yes) //ConfirmationPopUp((Form)sender)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCloseConfirm(e);
            settings.SaveToFile();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                KeyResult = DialogResult.No;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                KeyResult = DialogResult.Yes;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                KeyResult = DialogResult.None;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                KeyResult = DialogResult.None;
            }
        }

        private void SetCulture(string language) 
        {
            var culture = new CultureInfo(language);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

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
