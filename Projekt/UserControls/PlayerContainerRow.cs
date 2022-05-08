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
    public partial class PlayerContainerRow : UserControl
    {
        public static Player selectedPlayer;
        public static PlayerContainerRow selectedPlayerContainerRow;
        public Player player;
        private static PlayerImageRepository playerImage = new PlayerImageRepository();

        public PlayerContainerRow()
        {
            InitializeComponent();
        }

        private void PlayerControlRow_Load(object sender, EventArgs e)
        {
            SetLabels();
            SetPicture();
        }

        private void SetLabels()
        {
            lbName.Text = $"{player.Name}";
            lbShirtNumber.Text = $"{player.ShirtNumber}";
            lbGoals.Text = player.Goals.ToString();
            lbYellowCards.Text = player.YellowCards.ToString();
        }

        private void SetPicture()
        {
            //PlayerContainerUtils.SetSavedPicture(PicBoxShirt, player);

            if (PlayerImageRepository.PlayerHasPicture(player.Name))
            {
                string imgPath = PlayerImageRepository.GetImage(player.Name);
                PlayerContainerUtils.ChangeImage(imgPath, PicBoxShirt, player);
            }
            else if (player.Captain)
            {
                PicBoxShirt.Image = Images.captainShirt;
            }
            else
            {
                PicBoxShirt.Image = Images.shirt;
            }
            PlayerContainerUtils.ShowFavoriteStar(PicBoxFavorite, player);
        }

        private void PlayerContainerRow_Click(object sender, EventArgs e)
        {
            TeamViewForm parent = (TeamViewForm)this.TopLevelControl;

            SetSelectedControl();
            selectedPlayer = this.player;

            parent.ShowSelectedPlayerFromRow();
        }

        private void SetSelectedControl()
        {
            if (selectedPlayerContainerRow != null) 
            {
                selectedPlayerContainerRow.BackColor = Color.White;
            }
            selectedPlayerContainerRow = this;
            BackColor = Color.DodgerBlue;

        }
    }
}
