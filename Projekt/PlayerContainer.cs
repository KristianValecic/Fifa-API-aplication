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
    public partial class PlayerContainer : UserControl
    {
        public Player player;

        public PlayerContainer()
        {
            InitializeComponent();
        }

        private void PlayerContainer_Load(object sender, EventArgs e)
        {
            lbPlrName.Text = player.Name;
            Center(lbPlrName);

            lbPlrNumber.Text = player.ShirtNumber.ToString();
            Center(lbPlrNumber);


        }


        private void Center(Label label)
        {
            //int shirtWidth = (int)Math.Round((pictureBox.Width * 0.6), 0);
            //if (label.Width >= shirtWidth)
            //{
            //    label.MaximumSize = new Size(shirtWidth, 0);
            //}
            int middle = this.Width / 2;
            int labelMid = (label.Width / 2);
            label.Location = new Point(middle - labelMid, label.Location.Y);
        }

    }
}
