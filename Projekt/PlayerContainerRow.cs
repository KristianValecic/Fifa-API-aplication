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
    public partial class PlayerContainerRow : UserControl
    {
        public Player player;
        private PlayerImageRepository playerImage = new PlayerImageRepository();

        public PlayerContainerRow()
        {
            InitializeComponent();
        }

        private void PlayerControlRow_Load(object sender, EventArgs e)
        {
            lbName.Text = $"{player.Name}";
            lbShirtNumber.Text = $"{player.ShirtNumber}";
            lbGoals.Text = player.Goals.ToString();
            lbYellowCards.Text = player.YellowCards.ToString();


            if (playerImage.PlayerHasPicture(player.Name))
            {
                string imgPath = playerImage.GetImage(player.Name);
                ChangeImage(Image.FromFile(imgPath), imgPath);
            }
            else
            {
                PicBoxShirt.Image = Images.shirt;
            }
            ShowFavoriteStar();
        }

        private void ChangeImage(Image image, string imgPath)
        {
            playerImage.GivePlayerImage(player.Name, imgPath);
            PicBoxShirt.Image = image;

            playerImage.SaveToFile();
        }


        public void ShowFavoriteStar()
        {
            if (player.Favorite)
            {
                PicBoxFavorite.Visible = true;
            }
            else
            {
                PicBoxFavorite.Visible = false;
            }
        }
    }
}
