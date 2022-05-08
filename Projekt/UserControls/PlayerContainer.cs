using Lib.Dal;
using Lib.Model;
using Lib.Utils;
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
        public Player player;

        private static readonly int listLimit = 3;
        private PlayerImageRepository playerImage = new PlayerImageRepository();

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
            lbPlrName.Text = player.Name;
            PlayerContainerUtils.Center(lbPlrName, this.Width);

            lbPlrNumber.Text = player.ShirtNumber.ToString();
            PlayerContainerUtils.Center(lbPlrNumber, this.Width);
            
            lbPosition.Text = player.Position;
            PlayerContainerUtils.Center(lbPosition, this.Width);

            SetPicture();
        }

        private void SetPicture()
        {
            if (PlayerImageRepository.PlayerHasPicture(player.Name))
            {
                string imgPath = PlayerImageRepository.GetImage(player.Name);
                ChangeImage(Image.FromFile(imgPath), imgPath);
            }
            else if (player.Captain)
            {
                // SetImage(Images.captainShirt);
                PicBoxShirt.Image = Images.captainShirt;
            }
            ShowFavoriteStar();
        }

        public void ShowFavoriteStar() => PlayerContainerUtils.ShowFavoriteStar(PicBoxFavorite, player);

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
            else if (plContainer.Parent.Name == "flpPlayers")
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

            playerImage.GivePlayerImage(player.Name, filePath);
            PicBoxShirt.Image = image;
            

            playerImage.SaveToFile();
        }

        internal void DefaultImage()
        {
            lbPlrName.Visible = true;
            lbPlrNumber.Visible = true;
            lbPosition.Visible = true;

            if (player.Captain)
            {
                PicBoxShirt.Image = Images.captainShirt;
            }
            else
            {
                PicBoxShirt.Image = Images.shirt;
            }

            playerImage.RemovePlayerImage(player.Name);
            playerImage.SaveToFile();
        }
    }
}
