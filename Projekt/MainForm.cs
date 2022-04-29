using Lib.Dal;
using Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MainForm : Form
    {
        private static readonly IRepository repo = RepositoryFactory.GetRepo();
        private IList<Team> teams;
        private Settings settings = new Settings();

        public MainForm()
        {
            InitializeComponent();
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
        }

        private void SetSettings()
        {
            settings.ReadFromFile();
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
            lblInstructionForComboBox.Visible = true;
            lblInstructionForComboBox.Text = "Pričekajte...";

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
            //cbTeams.ValueMember = "FifaCode";

            TrySetSelectedTeam();

            lblInstructionForComboBox.Visible = false;
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
            settings.SaveFile();

            TeamViewForm teamViewForm = new TeamViewForm();
            teamViewForm.Show();
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
    }
}
