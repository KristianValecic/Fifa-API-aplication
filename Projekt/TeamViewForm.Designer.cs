namespace Projekt
{
    partial class TeamViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveFromFavorites = new System.Windows.Forms.Button();
            this.MoveToFavorites = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsFavoritesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makniOznačeneFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makniSlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsPlayerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajIgračeUFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makniSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlSelectedPlayerPlaceholder = new System.Windows.Forms.Panel();
            this.lbyellowCardsSort = new System.Windows.Forms.Label();
            this.lbGoalsSort = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortGoals = new System.Windows.Forms.Button();
            this.btnSortYellowCards = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbAttendenceSort = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpMatchRangList = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmsFavoritesList.SuspendLayout();
            this.cmsPlayerList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(846, 564);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RemoveFromFavorites);
            this.tabPage1.Controls.Add(this.MoveToFavorites);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flpFavorites);
            this.tabPage1.Controls.Add(this.flpPlayers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(838, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Omiljeni igrači";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveFromFavorites
            // 
            this.RemoveFromFavorites.Location = new System.Drawing.Point(420, 262);
            this.RemoveFromFavorites.Name = "RemoveFromFavorites";
            this.RemoveFromFavorites.Size = new System.Drawing.Size(84, 35);
            this.RemoveFromFavorites.TabIndex = 5;
            this.RemoveFromFavorites.Text = "Maknite iz favorita";
            this.RemoveFromFavorites.UseVisualStyleBackColor = true;
            this.RemoveFromFavorites.Click += new System.EventHandler(this.RemoveFromFavorites_Click);
            // 
            // MoveToFavorites
            // 
            this.MoveToFavorites.Location = new System.Drawing.Point(330, 262);
            this.MoveToFavorites.Name = "MoveToFavorites";
            this.MoveToFavorites.Size = new System.Drawing.Size(84, 35);
            this.MoveToFavorites.TabIndex = 4;
            this.MoveToFavorites.Text = "Prebacite u favorite";
            this.MoveToFavorites.UseVisualStyleBackColor = true;
            this.MoveToFavorites.Click += new System.EventHandler(this.MoveToFavorites_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Favoriti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Igraci:";
            // 
            // flpFavorites
            // 
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavorites.ContextMenuStrip = this.cmsFavoritesList;
            this.flpFavorites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFavorites.Location = new System.Drawing.Point(3, 305);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(832, 230);
            this.flpFavorites.TabIndex = 1;
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpFavorites_DragDrop);
            this.flpFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragEnter);
            // 
            // cmsFavoritesList
            // 
            this.cmsFavoritesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makniOznačeneFavoriteToolStripMenuItem,
            this.dodajSlikuToolStripMenuItem1,
            this.makniSlikuToolStripMenuItem1});
            this.cmsFavoritesList.Name = "cmsFavoritesList";
            this.cmsFavoritesList.Size = new System.Drawing.Size(204, 70);
            // 
            // makniOznačeneFavoriteToolStripMenuItem
            // 
            this.makniOznačeneFavoriteToolStripMenuItem.Name = "makniOznačeneFavoriteToolStripMenuItem";
            this.makniOznačeneFavoriteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.makniOznačeneFavoriteToolStripMenuItem.Text = "Makni označene favorite";
            this.makniOznačeneFavoriteToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromFavorites_Click);
            // 
            // dodajSlikuToolStripMenuItem1
            // 
            this.dodajSlikuToolStripMenuItem1.Name = "dodajSlikuToolStripMenuItem1";
            this.dodajSlikuToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.dodajSlikuToolStripMenuItem1.Text = "Dodaj Sliku";
            this.dodajSlikuToolStripMenuItem1.Click += new System.EventHandler(this.AddPlayerImg_Click);
            // 
            // makniSlikuToolStripMenuItem1
            // 
            this.makniSlikuToolStripMenuItem1.Name = "makniSlikuToolStripMenuItem1";
            this.makniSlikuToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.makniSlikuToolStripMenuItem1.Text = "Makni sliku";
            this.makniSlikuToolStripMenuItem1.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // flpPlayers
            // 
            this.flpPlayers.AllowDrop = true;
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.ContextMenuStrip = this.cmsPlayerList;
            this.flpPlayers.Location = new System.Drawing.Point(3, 26);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(827, 230);
            this.flpPlayers.TabIndex = 0;
            this.flpPlayers.WrapContents = false;
            this.flpPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragDrop);
            this.flpPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragEnter);
            // 
            // cmsPlayerList
            // 
            this.cmsPlayerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajIgračeUFavoriteToolStripMenuItem,
            this.dodajSlikuToolStripMenuItem,
            this.makniSlikuToolStripMenuItem});
            this.cmsPlayerList.Name = "cmsPlayerList";
            this.cmsPlayerList.Size = new System.Drawing.Size(247, 70);
            // 
            // dodajIgračeUFavoriteToolStripMenuItem
            // 
            this.dodajIgračeUFavoriteToolStripMenuItem.Name = "dodajIgračeUFavoriteToolStripMenuItem";
            this.dodajIgračeUFavoriteToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.dodajIgračeUFavoriteToolStripMenuItem.Text = "Dodaj označene igrače u favorite";
            this.dodajIgračeUFavoriteToolStripMenuItem.Click += new System.EventHandler(this.MoveToFavorites_Click);
            // 
            // dodajSlikuToolStripMenuItem
            // 
            this.dodajSlikuToolStripMenuItem.Name = "dodajSlikuToolStripMenuItem";
            this.dodajSlikuToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.dodajSlikuToolStripMenuItem.Text = "Dodaj sliku";
            this.dodajSlikuToolStripMenuItem.Click += new System.EventHandler(this.AddPlayerImg_Click);
            // 
            // makniSlikuToolStripMenuItem
            // 
            this.makniSlikuToolStripMenuItem.Name = "makniSlikuToolStripMenuItem";
            this.makniSlikuToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.makniSlikuToolStripMenuItem.Text = "Makni sliku";
            this.makniSlikuToolStripMenuItem.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlSelectedPlayerPlaceholder);
            this.tabPage2.Controls.Add(this.lbyellowCardsSort);
            this.tabPage2.Controls.Add(this.lbGoalsSort);
            this.tabPage2.Controls.Add(this.flpList);
            this.tabPage2.Controls.Add(this.btnSortGoals);
            this.tabPage2.Controls.Add(this.btnSortYellowCards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rang lista igrača";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlSelectedPlayerPlaceholder
            // 
            this.pnlSelectedPlayerPlaceholder.Location = new System.Drawing.Point(469, 97);
            this.pnlSelectedPlayerPlaceholder.Name = "pnlSelectedPlayerPlaceholder";
            this.pnlSelectedPlayerPlaceholder.Size = new System.Drawing.Size(361, 438);
            this.pnlSelectedPlayerPlaceholder.TabIndex = 7;
            // 
            // lbyellowCardsSort
            // 
            this.lbyellowCardsSort.AutoSize = true;
            this.lbyellowCardsSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbyellowCardsSort.Location = new System.Drawing.Point(413, 73);
            this.lbyellowCardsSort.Name = "lbyellowCardsSort";
            this.lbyellowCardsSort.Size = new System.Drawing.Size(19, 13);
            this.lbyellowCardsSort.TabIndex = 6;
            this.lbyellowCardsSort.Text = "\\/";
            // 
            // lbGoalsSort
            // 
            this.lbGoalsSort.AutoSize = true;
            this.lbGoalsSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoalsSort.Location = new System.Drawing.Point(254, 73);
            this.lbGoalsSort.Name = "lbGoalsSort";
            this.lbGoalsSort.Size = new System.Drawing.Size(19, 13);
            this.lbGoalsSort.TabIndex = 5;
            this.lbGoalsSort.Text = "\\/";
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpList.Location = new System.Drawing.Point(6, 97);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(431, 436);
            this.flpList.TabIndex = 4;
            this.flpList.WrapContents = false;
            // 
            // btnSortGoals
            // 
            this.btnSortGoals.Location = new System.Drawing.Point(154, 68);
            this.btnSortGoals.Name = "btnSortGoals";
            this.btnSortGoals.Size = new System.Drawing.Size(94, 23);
            this.btnSortGoals.TabIndex = 3;
            this.btnSortGoals.Text = "Sortiraj golove";
            this.btnSortGoals.UseVisualStyleBackColor = true;
            this.btnSortGoals.Click += new System.EventHandler(this.SortGoals_Click);
            // 
            // btnSortYellowCards
            // 
            this.btnSortYellowCards.Location = new System.Drawing.Point(295, 68);
            this.btnSortYellowCards.Name = "btnSortYellowCards";
            this.btnSortYellowCards.Size = new System.Drawing.Size(112, 23);
            this.btnSortYellowCards.TabIndex = 2;
            this.btnSortYellowCards.Text = "Sortiraj žute kartone";
            this.btnSortYellowCards.UseVisualStyleBackColor = true;
            this.btnSortYellowCards.Click += new System.EventHandler(this.SortYellowCards_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbAttendenceSort);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.flpMatchRangList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(838, 538);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Utakmice";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbAttendenceSort
            // 
            this.lbAttendenceSort.AutoSize = true;
            this.lbAttendenceSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttendenceSort.Location = new System.Drawing.Point(671, 33);
            this.lbAttendenceSort.Name = "lbAttendenceSort";
            this.lbAttendenceSort.Size = new System.Drawing.Size(19, 13);
            this.lbAttendenceSort.TabIndex = 2;
            this.lbAttendenceSort.Text = "\\/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sortiraj po posjetiteljima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortMatchAttendence_Click);
            // 
            // flpMatchRangList
            // 
            this.flpMatchRangList.AutoScroll = true;
            this.flpMatchRangList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMatchRangList.Location = new System.Drawing.Point(144, 57);
            this.flpMatchRangList.Name = "flpMatchRangList";
            this.flpMatchRangList.Size = new System.Drawing.Size(550, 467);
            this.flpMatchRangList.TabIndex = 0;
            this.flpMatchRangList.WrapContents = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 564);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(846, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Projekt.Images.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 588);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamViewForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cmsFavoritesList.ResumeLayout(false);
            this.cmsPlayerList.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpFavorites;
        private System.Windows.Forms.FlowLayoutPanel flpPlayers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveToFavorites;
        private System.Windows.Forms.Button RemoveFromFavorites;
        private System.Windows.Forms.ContextMenuStrip cmsFavoritesList;
        private System.Windows.Forms.ToolStripMenuItem makniOznačeneFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSlikuToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsPlayerList;
        private System.Windows.Forms.ToolStripMenuItem dodajIgračeUFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makniSlikuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makniSlikuToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSortGoals;
        private System.Windows.Forms.Button btnSortYellowCards;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Label lbyellowCardsSort;
        private System.Windows.Forms.Label lbGoalsSort;
        private System.Windows.Forms.Panel pnlSelectedPlayerPlaceholder;
        private System.Windows.Forms.FlowLayoutPanel flpMatchRangList;
        private System.Windows.Forms.Label lbAttendenceSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}