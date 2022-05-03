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
        public static List<PlayerContainer> selectedList = new List<PlayerContainer>();
        public static List<PlayerContainer> selectedListFavorites = new List<PlayerContainer>();

        //private static int selectedCount = 0;
        private static int listLimit = 3;

        public Player player;

        public PlayerContainer()
        {
            InitializeComponent();
        }

        internal static int GetListLimit() => listLimit;

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
            //if (selectedCount == listLimit && this.BackColor == Color.White)
            //{
            //    this.BackColor = this.BackColor;
            //    return;
            //}

            if (this.BackColor == Color.White)
            {
                
                //ResetCounter();
                //selectedCount++;
                AddFavoriteOrPlayerList(this);
            }
            else
            {
                
                //ResetCounter();
                //selectedCount--;
                RemoveFavoriteOrPlayerList(this);
            }
        }

        private void RemoveFavoriteOrPlayerList(PlayerContainer plContainer)
        {
            if(plContainer.Parent.Name == "flpFavorites" )
            {
                this.BackColor = Color.White;
                selectedListFavorites.Remove(this);
            }
            else if (plContainer.Parent.Name == "flpPlayers" )
            {
                this.BackColor = Color.White;
                selectedList.Remove(this);
            }
        }

        private void AddFavoriteOrPlayerList(PlayerContainer plContainer)
        {
            if (plContainer.Parent.Name == "flpFavorites" && selectedListFavorites.Count < listLimit)
            {
                this.BackColor = Color.DodgerBlue;
                selectedListFavorites.Add(this);
            }
            else if (plContainer.Parent.Name == "flpPlayers" && selectedList.Count < listLimit)
            {
                this.BackColor = Color.DodgerBlue;
                selectedList.Add(this);
            }
        }
    }
}
