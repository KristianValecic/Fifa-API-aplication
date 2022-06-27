using Lib.Dal;
using Lib.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lib.Utils
{
    public static class PlayerContainerUtils
    {
        public static PlayerImageRepository playerImage = new PlayerImageRepository();

        public static void ShowFavoriteStar(PictureBox picBox, Player player)
        {
            if (player.Favorite)
            {
                picBox.Visible = true;
            }
            else
            {
                picBox.Visible = false;
            }
        }

        public static void Center(Control label, int width)
        {
            //int shirtWidth = (int)Math.Round((pictureBox.Width * 0.6), 0);
            //if (label.Width >= shirtWidth)
            //{                                                     STAVLJA LABEL U DVA REDA
            //    label.MaximumSize = new Size(shirtWidth, 0);
            //}
            int middle = width / 2;
            int labelMid = (label.Width / 2);
            label.Location = new Point(middle - labelMid, label.Location.Y);
        }

        //public static void SetSavedPicture(PictureBox picBox, Player player)
        //{
        //    if (PlayerImageRepository.PlayerHasPicture(player.Name))
        //    {
        //        string imgPath = PlayerImageRepository.GetImage(player.Name);
        //        ChangeImage(imgPath, picBox, player);
        //    }
        //    ShowFavoriteStar(picBox, player);
        //}

        public static void ChangeImage(string imgPath, PictureBox picBox, Player player)
        {
            playerImage.GivePlayerImage(player.Name, imgPath);
            picBox.Image = Image.FromFile(imgPath);

            PlayerImageRepository.SaveImgToFile();
        }
    }
}
