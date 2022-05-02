using Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class PlayerContainer : UserControl
    {
        private static int selectedCount = 0;
        public static IList<PlayerContainer> selectedList;
        public static IList<PlayerContainer> selectedListFavorites;
        public bool selected;

        public Player player;

        public PlayerContainer()
        {
            InitializeComponent();
        }

        public static void ResetCounter(int listLimit) {

            if (selectedCount == listLimit)
            {
                selectedCount = 0;
            }
        }

        private void PlayerContainer_Load(object sender, EventArgs e)
        {
            pictureBoxCaptain.Visible = false;

            lbPlrName.Text = player.Name;
            Center(lbPlrName);

            lbPlrNumber.Text = player.ShirtNumber.ToString();
            Center(lbPlrNumber);

            if (player.Captain)
            {
                pictureBoxCaptain.Visible = true;
                pictureBox.Visible = false;
            }
        }


        private void Center(Label label)
        {
            //int shirtWidth = (int)Math.Round((pictureBox.Width * 0.6), 0);
            //if (label.Width >= shirtWidth)
            //{                                                     STAVLJA LABEL U DVA REDA
            //    label.MaximumSize = new Size(shirtWidth, 0);
            //}
            int middle = this.Width / 2;
            int labelMid = (label.Width / 2);
            label.Location = new Point(middle - labelMid, label.Location.Y);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (selectedCount == 3 && this.BackColor == Color.White)
            {
                this.BackColor = this.BackColor;
                return;
            }

            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.DodgerBlue;
                //selectedCount++;
                FavoriteOrPlayerList(this);
                selected = true;
            }
            else
            {
                this.BackColor = Color.White;
                //selectedCount--;
                selectedList.Remove(this);
                selected = false;
            }
        }

        private void FavoriteOrPlayerList(PlayerContainer plContainer)
        {
            if (plContainer.Parent.Name == "flpFavorites")
            {
                selectedListFavorites.Add(this);
            }
            else if (plContainer.Parent.Name == "flpPlayers")
            {
                selectedList.Add(this);
            }

        }
    }
}
