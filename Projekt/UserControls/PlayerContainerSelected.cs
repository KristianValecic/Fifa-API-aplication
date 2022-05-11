using Lib.Dal;
using Lib.Model;
using Lib.Utils;
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
    public partial class PlayerContainerSelected : UserControl
    {
        private Player player;
        public PlayerContainerSelected()
        {
            InitializeComponent();
        }

        public static PlayerContainerSelected GetSelectedPlayerControl(Player player)
        {
            PlayerContainerSelected pcs = new PlayerContainerSelected();
            pcs.player = player;
            pcs.SetPicture();
            pcs.SetLabels();
            return pcs;
        }

        private void SetLabels()
        {
            lbName.Text = $"{player.Name} - {player.ShirtNumber}";
            PlayerContainerUtils.Center(lbName, this.Width);

            lbPosition.Text = player.Position;
            lbShirtNumber.Text = player.ShirtNumber.ToString();
            PlayerContainerUtils.Center(lbShirtNumber, this.Width);

            lbGoals.Text = player.Goals.ToString();
            lbYellowCards.Text = player.YellowCards.ToString();
        }
        
        private void SetPicture()
        {
            //PlayerContainerUtils.SetSavedPicture(PicBox, player);

            if (PlayerImageRepository.PlayerHasPicture(player.Name))
            {
                string imgPath = PlayerImageRepository.GetImage(player.Name);
                PlayerContainerUtils.ChangeImage(imgPath, PicBox, player);
                lbShirtNumber.Visible = false;
            }
            else if (player.Captain)
            {
                PicBox.Image = Images.captainShirt;
            }
            else
            {
                PicBox.Image = Images.shirt;
            }
            PlayerContainerUtils.ShowFavoriteStar(PicBoxFavorite, player);
        }
    }
}
