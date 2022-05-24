using Lib.Dal;
using Lib.Model;
using Projekt.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class TeamViewForm : Form
    {
        public List<Match> matches;
        public Team team;
        public MainForm parentForm;
        //public bool closeWithoutConfirm;
        //public FlowLayoutPanel flpStartedDnD;

        private OpenFileDialog ofd = new OpenFileDialog();
        private FavoritePlayers favoritePlayers = new FavoritePlayers();
        private List<Player> allPlayers = new List<Player>();
        //private HashSet<Player> allPlayers = new HashSet<Player>();
        private List<Player> playersListForSort = new List<Player>();
        private List<Player> players = new List<Player>();
        private HashSet<Player> printedPlayers = new HashSet<Player>(); // control list for players who have been printed
        //private bool successfulDnD;
        private bool teamHasFavorites = false;
        private bool initialLoad = true;
        private bool goalsDesc = true;
        private bool yellowCardsDesc = true;
        private bool matchAttendenceDesc = true;
        //private bool matchAttendenceDesc = true;
        private string descCharacter = @"\/";
        private string ascCharacter = @"/\";
        //private int passesCounter = 0;
        private int printanoStranica;


        public TeamViewForm()
        {
            InitializeComponent();
            InitOpenFileDialog();
            matches = new List<Match>();
        }

        private void TeamViewForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            LoadFavoritePlayers();
            LoadFlpPlayers();
            LoadListOfPlayers();
            LoadflpFavorites();
            LoadMatchRangList();
        }

        private void LoadFavoritePlayers()
        {
            if (favoritePlayers.IfFileExists())
            {
                SetFavorites(allPlayers);
            }
        }

        private void LoadMatchRangList()
        {
            flpMatchRangList.Controls.Clear();

            matches.ToList().ForEach(m => {
                flpMatchRangList.Controls.Add(
                    new MatchContainer
                    {
                        match = m
                    }
                );
            });
        }

        private void LoadListOfPlayers()
        {
            if (initialLoad == true)
            {
                allPlayers.ForEach(playersListForSort.Add);
                initialLoad = false;
            }

            flpPlayerSortList.Controls.Clear();

            playersListForSort.ForEach(p =>
            {
                flpPlayerSortList.Controls.Add(
                    new PlayerContainerRow
                    {
                        player = p
                    }
                );
            });
        }

        private void LoadFlpPlayers()
        {
            allPlayers.ForEach(players.Add);

            players.ForEach(p =>
             {
                 if (p.Favorite == false)
                 {
                     flpPlayers.Controls.Add(
                         new PlayerContainer
                         {
                             player = p
                         }
                     );
                 }
             }) ;
        }

        private void InitOpenFileDialog()
        {
            ofd.Filter = "Pictures|*.jpeg;*.jpg;*.png;|All files|*.*";
            ofd.Title = "Load pictures...";
            ofd.InitialDirectory = Application.StartupPath;
        }

        private void SetFavorites(List<Player> players)
        {
            foreach (Player p in favoritePlayers.favoritePlayersList)
            {
                Player player = players.FirstOrDefault(p.Equals);
                if (player != null)
                {
                    player.Favorite = true;
                }
            }
        }

        private void LoadflpFavorites()
        {
            allPlayers.ForEach(p => { 
                if (p != null && p.Favorite == true)
                {
                    players.Remove(p);
                    flpFavorites.Controls.Add(
                    new PlayerContainer
                    {
                        player = p
                    });
                }
            });
        }

        private void LoadPlayers()
        {
            allPlayers = matches.FirstOrDefault(m => m.HomeTeam.Country == team.Country || m.AwayTeam.Country == team.Country).GetPlayersFromTeam(team);

            foreach (var match in matches)
            {
                var tempPlayers = match.GetPlayersFromTeam(team);
                tempPlayers.ForEach(p => {

                    match.GetAllPlayerGoalsCards(p, team);
                    allPlayers.ForEach((player) =>
                    {
                        if (p.Equals(player) && (p.Goals != 0 || p.YellowCards != 0))
                        {
                            player.Goals += p.Goals;
                            player.YellowCards += p.YellowCards;
                        }
                    }); 
                }); 
            }
        }

        private void MoveToFavorites_Click(object sender, EventArgs e)
        {
            CheckIfSelected(PlayerContainer.selectedList.Count == 0 );
            if (CheckFavoriteList())
            {
                return;
            }
            MoveSelectedPlayersFromToList(PlayerContainer.selectedList, flpFavorites.Controls, true);
        }

        private void RemoveFromFavorites_Click(object sender, EventArgs e)
        { 
            CheckIfSelected(PlayerContainer.selectedListFavorites.Count == 0);
            MoveSelectedPlayersFromToList(PlayerContainer.selectedListFavorites, flpPlayers.Controls, false);
        }

        private bool CheckFavoriteList()
        {
            if (flpFavorites.Controls.Count >= PlayerContainer.GetListLimit() ||
            (PlayerContainer.selectedList.Count > (PlayerContainer.GetListLimit() - flpFavorites.Controls.Count)/* && flpFavorites.Controls.Count != 0*/) ||
            PlayerContainer.selectedList.Count > PlayerContainer.GetListLimit())
            {
                MessageBox.Show($"Lista favorita prima samo {PlayerContainer.GetListLimit()} igrača");
                return true;
            }
            return false;
        }

        private void CheckIfSelected(bool condition)
        {
            if (condition)
            {
                MessageBox.Show("Odaberite igrače");
                return;
            }
        }

        private void MoveSelectedPlayersFromToList(List<PlayerContainer> fromList, Control.ControlCollection toList, bool isFavorite)
        {
            fromList.ForEach(p => {
                p.SetDefaultBackColor();
                p.player.Favorite = isFavorite;
                p.ShowFavoriteStar();
               toList.Add(p);
            });

            fromList.Clear();
            SaveFavorites();
            LoadListOfPlayers();
        }

        private void SaveFavorites()
        {
            List<Player> tempList = new List<Player>();

            foreach (PlayerContainer c in flpFavorites.Controls)
            {
                tempList.Add(c.player);
            }
            favoritePlayers.favoritePlayersList = tempList;
            //if (flpFavorites.Controls.Count != 0)
            //{
                favoritePlayers.SaveToFile(); 
            //}
        }

        private void AddPlayerImg_Click(object sender, EventArgs e) => LoadPictures();

        private void RemoveImage_click(object sender, EventArgs e) => RemovePictures();

        private void LoadPictures()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //var selectedLi = PlayerContainer.selectedList.Concat(PlayerContainer.selectedListFavorites);
                //foreach (PlayerContainer plContainer in selectedList)
                //{                                                                                 THIS IS FOR CHANGING IMAGES FROM LIST OF PLAYERS
                //    plContainer.ChangeImage(Image.FromFile(ofd.FileName), ofd.FileName);
                //}
                PlayerContainer.selected.ChangeImage(Image.FromFile(ofd.FileName), ofd.FileName);
            }
            LoadListOfPlayers();
        }

        private void RemovePictures()
        {
            PlayerContainer.selected.DefaultImage();
            LoadListOfPlayers();
        }

        private void SortYellowCards_Click(object sender, EventArgs e)
        {
            if (yellowCardsDesc)
            {
                playersListForSort.Sort((a, b) => -a.YellowCards.CompareTo(b.YellowCards));
                yellowCardsDesc = false;
                lbyellowCardsSort.Text = ascCharacter;
            }
            else
            {
                playersListForSort.Sort((a, b) => a.YellowCards.CompareTo(b.YellowCards));
                yellowCardsDesc = true;
                lbyellowCardsSort.Text = descCharacter;
            }
            LoadListOfPlayers();
        }

        private void SortGoals_Click(object sender, EventArgs e)
        {
            if (goalsDesc)
            {
                playersListForSort.Sort((a, b) => -a.Goals.CompareTo(b.Goals));
                goalsDesc = false;
                lbGoalsSort.Text = ascCharacter;
            }
            else
            {
                playersListForSort.Sort((a, b) => a.Goals.CompareTo(b.Goals));
                goalsDesc = true;
                lbGoalsSort.Text = descCharacter;
            }
            LoadListOfPlayers();
        }

        public void ShowSelectedPlayerFromRow()
        {
            pnlSelectedPlayerPlaceholder.Controls.Clear();
            pnlSelectedPlayerPlaceholder.Controls.Add(PlayerContainerSelected.GetSelectedPlayerControl(PlayerContainerRow.selectedPlayer));
        }

        private void SortMatchAttendence_Click(object sender, EventArgs e)
        {
            if (matchAttendenceDesc)
            {
                matches.Sort((a, b) => -a.Attendance.CompareTo(b.Attendance));
                matchAttendenceDesc = false;
                lbAttendenceSort.Text = ascCharacter;
            }
            else
            {
                matches.Sort((a, b) => a.Attendance.CompareTo(b.Attendance));
                matchAttendenceDesc = true;
                lbAttendenceSort.Text = descCharacter;
            }
            LoadMatchRangList();
        }

        private void FlpPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void FlpPlayers_DragDrop(object sender, DragEventArgs e)
        {
            //Prebaci liste players u favorites i orbnuto ovisno o tome tko je sender
            MoveSelectedPlayersFromToList(PlayerContainer.selectedListFavorites, flpPlayers.Controls, false); 
        }

        private void FlpFavorites_DragDrop(object sender, DragEventArgs e)
        {
            if (CheckFavoriteList()) {
                return;
            }
            MoveSelectedPlayersFromToList(PlayerContainer.selectedList, flpFavorites.Controls, true);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //otvori MainFormu
            parentForm.Show();
        }

        private void TeamViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.FormCloseConfirm(e);
        }

        private void printDocumentPlayersSort_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            int x = 0;
            int y = e.MarginBounds.Top;
            int controlHeightCounter = 0;
            int passCount = 0;
            Rectangle tempRect = new Rectangle();

            List<Bitmap> bitmaps = new List<Bitmap>();

            //ovaj foreach trpa listu s bitmapama
            foreach (Control control in flpPlayerSortList.Controls)
            {
                //if (!printedPlayers.Exists(p => p.Equals(((PlayerContainerRow)control).player)))
                //{
                //    printedPlayers.Add(((PlayerContainerRow)control).player); 
                //}

                passCount++;

                tempRect.Width = control.Width;
                tempRect.Height = control.Height;

                if (printedPlayers.Add(((PlayerContainerRow)control).player)) // ako uspije ubacit 
                {
                    controlHeightCounter += control.Height;
                    var tempBmp = new Bitmap(tempRect.Width, tempRect.Height);
                    control.DrawToBitmap(tempBmp, tempRect);
                    bitmaps.Add(tempBmp);

                    if (controlHeightCounter >= e.MarginBounds.Height)
                    {
                        x = GetCenterFromPage(e.PageBounds.Width, control.Width);

                        DrawBitmaps(e, x, y, bitmaps);

                        e.HasMorePages = true;
                        controlHeightCounter = 0;
                        return; // you need to return, then it will go into this function again
                    }
                    else if(flpPlayerSortList.Controls.Count == passCount)
                    {
                        //e.Graphics.Clear(Color.White);
                        DrawBitmaps(e, x, y, bitmaps);
                        e.HasMorePages = false;
                    }
                    
                }
                else
                {
                    //bitmaps.Clear();
                    //return;
                }


                //IfHasMorePages(e.HasMorePages, e.PageBounds.Height);
            }

            //Bitmap bmp = Combine(bitmaps);
            //e.Graphics.DrawImage(bmp, x, y);
        }

        private static void DrawBitmaps(PrintPageEventArgs e, int x, int y, List<Bitmap> bitmaps)
        {
            Bitmap bmp = Combine(bitmaps);
            bitmaps.Clear();
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void IfHasMorePages(bool hasMorePages, int pageHeight, int offsetY)
        {
            if (offsetY >= pageHeight)
            {
                hasMorePages = true;
                offsetY = 0;
                return; // you need to return, then it will go into this function again
            }
            else
            {
                hasMorePages = false;
            }
        }

        private int GetCenterFromPage(int pageLength, int controlLength)
        => (pageLength - controlLength) / 2;
     
        public static Bitmap Combine(List<Bitmap> bitmaps /*params Bitmap[] sources*/)
        {
            List<int> imageHeights = new List<int>();
            List<int> imageWidths = new List<int>();
            int imageHeight = 0;
            int imageStartPointY = 0;
            foreach (Bitmap img in bitmaps) //sources
            {
                //imageHeights.Add(img.Height);
                imageWidths.Add(img.Width);
                imageHeight += img.Height;
            }
            Bitmap result = new Bitmap(imageWidths.Max(), imageHeight);//imageHeights.Max()
            using (Graphics g = Graphics.FromImage(result))
            {
                foreach (Bitmap img in bitmaps) //sources
                {
                    g.DrawImage(img, new Point(0, imageStartPointY));
                    imageStartPointY += img.Height;
                }
            }
            return result;
        }

        private void btnPrintPlayerSort_Click(object sender, EventArgs e)
        {

            printPreviewDialogPlayersSort.ShowDialog();
        }
    }
}
