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
        public static PlayerContainer selected = new PlayerContainer();
        public Player player;

        //private PlayerContainer ControlStartedDnD;
        private Color DefaultColor = Color.White;
        private Color SelectedColor = Color.DodgerBlue;
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

        //private void SelectPlayerContainer_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    ////if (e.Button == MouseButtons.Left)
        //    ////{
        //    //    if (this.BackColor == DefaultColor)
        //    //    {
        //    //        AddFavoriteOrPlayerList(this);
        //    //    }
        //    //    else                                              
        //    //    {
        //    //        RemoveFavoriteOrPlayerList(this);
        //    //    }
        //    ////}
        //}

        private void RemoveFavoriteOrPlayerList(PlayerContainer plContainer)
        {
            if(plContainer.Parent.Name == "flpFavorites" )
            {
                this.BackColor = DefaultColor;
                selectedListFavorites.Remove(this);
            }
            else if (plContainer.Parent.Name == "flpPlayers" )
            {
                this.BackColor = DefaultColor;
                selectedList.Remove(this);
            }
        }

        private void AddFavoriteOrPlayerList(PlayerContainer plContainer)
        {
            if (plContainer.Parent.Name == "flpFavorites" && selectedListFavorites.Count < listLimit)
            {
                this.BackColor = SelectedColor;
                selectedListFavorites.Add(this);
            }
            else if (plContainer.Parent.Name == "flpPlayers")
            {
                this.BackColor = SelectedColor;
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

        private void PlayerContainer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (IfLeftMouse(e))
            {
                StartDnD(this); //sender as Control 
                AddOrRemoveSelected();
            }
            else
            {
                selected = this;
                //contextMenuStrip1 = new ContextMenuStrip();
            }

        }

        private bool IfLeftMouse(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return true;
            }
            return false;
        }

        private void AddOrRemoveSelected()
        {
            if (this.BackColor == DefaultColor)
            {
                AddFavoriteOrPlayerList(this);
            }
            else
            {
                RemoveFavoriteOrPlayerList(this);
            }
        }

        private void StartDnD(PlayerContainer pContainer)
        {
            if (pContainer.BackColor == DefaultColor) return;


            //ControlStartedDnD = pContainer;
            pContainer.DoDragDrop(pContainer, DragDropEffects.Move);
        }

        internal void SetDefaultBackColor()
        {
            this.BackColor = DefaultBackColor; 
        }
    }
}
