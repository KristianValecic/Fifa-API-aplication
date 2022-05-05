using Lib.Dal;
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
using System.Windows.Input;

namespace Projekt
{
    public partial class PlayerContainer : UserControl
    {
        public static List<PlayerContainer> selectedList = new List<PlayerContainer>();
        public static List<PlayerContainer> selectedListFavorites = new List<PlayerContainer>();

        private static readonly int listLimit = 3;
        //private bool imageChanged = false;
        private PlayerImage playerImage = new PlayerImage();

        public Player player;

        public PlayerContainer()
        {
            InitializeComponent();
            if (playerImage.IfFileExists())
            {
                playerImage.LoadFromFile(); 
            }
        }

        internal static int GetListLimit() => listLimit;

        private void PlayerContainer_Load(object sender, EventArgs e)
        {

            PicBoxFavorite.Visible = false;

            lbPlrName.Text = player.Name;
            Center(lbPlrName);

            lbPlrNumber.Text = player.ShirtNumber.ToString();
            Center(lbPlrNumber);
            
            lbPosition.Text = player.Position;
            Center(lbPosition);

            if (playerImage.PlayerExists(player.Name))
            {
                //load corresponding saved image
                //PicBoxShirt.Image = Image.FromFile(playerImage.GetImage(player.Name));
                string imgPath = playerImage.GetImage(player.Name);
                ChangeImage(Image.FromFile(imgPath), imgPath);
            }
            else if (player.Captain)
            {
                // SetImage(Images.captainShirt);
                PicBoxShirt.Image = Images.captainShirt;
            }
            ShowFavoriteStar();
        }

        public void ShowFavoriteStar() // private/ public
        {
            if (player.Favorite)
            {
                PicBoxFavorite.Visible = true;
            }else
            {
                PicBoxFavorite.Visible = false;
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

        private void SelectPlayerContainer_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
                if (this.BackColor == Color.White)
                {
                    AddFavoriteOrPlayerList(this);
                }
                else
                {
                    RemoveFavoriteOrPlayerList(this);
                }
            //}
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
            else if (plContainer.Parent.Name == "flpPlayers" /*&& selectedList.Count < listLimit*/)
            {
                this.BackColor = Color.DodgerBlue;
                selectedList.Add(this);
            }
        }

        internal void ChangeImage(Image image, string filePath)
        {
            lbPlrName.Visible = false;
            lbPlrNumber.Visible = false;
            lbPosition.Visible = false;

            //imageChanged = true;
            playerImage.GivePlayerImage(player, filePath);
            PicBoxShirt.Image = image;
            

            playerImage.SaveToFile();
        }
    }
}
