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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamViewForm));
            this.cmsFavoritesList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSelectedFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makniSlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlayerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPlayersToFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeImageGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbAttendenceSort = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpMatchRangList = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlSelectedPlayerPlaceholder = new System.Windows.Forms.Panel();
            this.lbyellowCardsSort = new System.Windows.Forms.Label();
            this.lbGoalsSort = new System.Windows.Forms.Label();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortGoals = new System.Windows.Forms.Button();
            this.btnSortYellowCards = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveFromFavorites = new System.Windows.Forms.Button();
            this.MoveToFavorites = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cmsFavoritesList.SuspendLayout();
            this.cmsPlayerList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsFavoritesList
            // 
            resources.ApplyResources(this.cmsFavoritesList, "cmsFavoritesList");
            this.cmsFavoritesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedFavoriteToolStripMenuItem,
            this.dodajSlikuToolStripMenuItem1,
            this.makniSlikuToolStripMenuItem1});
            this.cmsFavoritesList.Name = "cmsFavoritesList";
            // 
            // removeSelectedFavoriteToolStripMenuItem
            // 
            resources.ApplyResources(this.removeSelectedFavoriteToolStripMenuItem, "removeSelectedFavoriteToolStripMenuItem");
            this.removeSelectedFavoriteToolStripMenuItem.Name = "removeSelectedFavoriteToolStripMenuItem";
            this.removeSelectedFavoriteToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromFavorites_Click);
            // 
            // dodajSlikuToolStripMenuItem1
            // 
            resources.ApplyResources(this.dodajSlikuToolStripMenuItem1, "dodajSlikuToolStripMenuItem1");
            this.dodajSlikuToolStripMenuItem1.Name = "dodajSlikuToolStripMenuItem1";
            this.dodajSlikuToolStripMenuItem1.Click += new System.EventHandler(this.AddPlayerImg_Click);
            // 
            // makniSlikuToolStripMenuItem1
            // 
            resources.ApplyResources(this.makniSlikuToolStripMenuItem1, "makniSlikuToolStripMenuItem1");
            this.makniSlikuToolStripMenuItem1.Name = "makniSlikuToolStripMenuItem1";
            this.makniSlikuToolStripMenuItem1.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // cmsPlayerList
            // 
            resources.ApplyResources(this.cmsPlayerList, "cmsPlayerList");
            this.cmsPlayerList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayersToFavoriteToolStripMenuItem,
            this.addImageToolStripMenuItem,
            this.removeImageGToolStripMenuItem});
            this.cmsPlayerList.Name = "cmsPlayerList";
            // 
            // addPlayersToFavoriteToolStripMenuItem
            // 
            resources.ApplyResources(this.addPlayersToFavoriteToolStripMenuItem, "addPlayersToFavoriteToolStripMenuItem");
            this.addPlayersToFavoriteToolStripMenuItem.Name = "addPlayersToFavoriteToolStripMenuItem";
            this.addPlayersToFavoriteToolStripMenuItem.Click += new System.EventHandler(this.MoveToFavorites_Click);
            // 
            // addImageToolStripMenuItem
            // 
            resources.ApplyResources(this.addImageToolStripMenuItem, "addImageToolStripMenuItem");
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.AddPlayerImg_Click);
            // 
            // removeImageGToolStripMenuItem
            // 
            resources.ApplyResources(this.removeImageGToolStripMenuItem, "removeImageGToolStripMenuItem");
            this.removeImageGToolStripMenuItem.Name = "removeImageGToolStripMenuItem";
            this.removeImageGToolStripMenuItem.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Projekt.Images.settings;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.lbAttendenceSort);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.flpMatchRangList);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbAttendenceSort
            // 
            resources.ApplyResources(this.lbAttendenceSort, "lbAttendenceSort");
            this.lbAttendenceSort.Name = "lbAttendenceSort";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SortMatchAttendence_Click);
            // 
            // flpMatchRangList
            // 
            resources.ApplyResources(this.flpMatchRangList, "flpMatchRangList");
            this.flpMatchRangList.Name = "flpMatchRangList";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.pnlSelectedPlayerPlaceholder);
            this.tabPage2.Controls.Add(this.lbyellowCardsSort);
            this.tabPage2.Controls.Add(this.lbGoalsSort);
            this.tabPage2.Controls.Add(this.flpList);
            this.tabPage2.Controls.Add(this.btnSortGoals);
            this.tabPage2.Controls.Add(this.btnSortYellowCards);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlSelectedPlayerPlaceholder
            // 
            resources.ApplyResources(this.pnlSelectedPlayerPlaceholder, "pnlSelectedPlayerPlaceholder");
            this.pnlSelectedPlayerPlaceholder.Name = "pnlSelectedPlayerPlaceholder";
            // 
            // lbyellowCardsSort
            // 
            resources.ApplyResources(this.lbyellowCardsSort, "lbyellowCardsSort");
            this.lbyellowCardsSort.Name = "lbyellowCardsSort";
            // 
            // lbGoalsSort
            // 
            resources.ApplyResources(this.lbGoalsSort, "lbGoalsSort");
            this.lbGoalsSort.Name = "lbGoalsSort";
            // 
            // flpList
            // 
            resources.ApplyResources(this.flpList, "flpList");
            this.flpList.Name = "flpList";
            // 
            // btnSortGoals
            // 
            resources.ApplyResources(this.btnSortGoals, "btnSortGoals");
            this.btnSortGoals.Name = "btnSortGoals";
            this.btnSortGoals.UseVisualStyleBackColor = true;
            this.btnSortGoals.Click += new System.EventHandler(this.SortGoals_Click);
            // 
            // btnSortYellowCards
            // 
            resources.ApplyResources(this.btnSortYellowCards, "btnSortYellowCards");
            this.btnSortYellowCards.Name = "btnSortYellowCards";
            this.btnSortYellowCards.UseVisualStyleBackColor = true;
            this.btnSortYellowCards.Click += new System.EventHandler(this.SortYellowCards_Click);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.RemoveFromFavorites);
            this.tabPage1.Controls.Add(this.MoveToFavorites);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flpFavorites);
            this.tabPage1.Controls.Add(this.flpPlayers);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveFromFavorites
            // 
            resources.ApplyResources(this.RemoveFromFavorites, "RemoveFromFavorites");
            this.RemoveFromFavorites.Name = "RemoveFromFavorites";
            this.RemoveFromFavorites.UseVisualStyleBackColor = true;
            this.RemoveFromFavorites.Click += new System.EventHandler(this.RemoveFromFavorites_Click);
            // 
            // MoveToFavorites
            // 
            resources.ApplyResources(this.MoveToFavorites, "MoveToFavorites");
            this.MoveToFavorites.Name = "MoveToFavorites";
            this.MoveToFavorites.UseVisualStyleBackColor = true;
            this.MoveToFavorites.Click += new System.EventHandler(this.MoveToFavorites_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // flpFavorites
            // 
            resources.ApplyResources(this.flpFavorites, "flpFavorites");
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavorites.ContextMenuStrip = this.cmsFavoritesList;
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpFavorites_DragDrop);
            this.flpFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragEnter);
            // 
            // flpPlayers
            // 
            resources.ApplyResources(this.flpPlayers, "flpPlayers");
            this.flpPlayers.AllowDrop = true;
            this.flpPlayers.ContextMenuStrip = this.cmsPlayerList;
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragDrop);
            this.flpPlayers.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlpPlayers_DragEnter);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // TeamViewForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "TeamViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamViewForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            this.cmsFavoritesList.ResumeLayout(false);
            this.cmsPlayerList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsFavoritesList;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSlikuToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsPlayerList;
        private System.Windows.Forms.ToolStripMenuItem addPlayersToFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makniSlikuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeImageGToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbAttendenceSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpMatchRangList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlSelectedPlayerPlaceholder;
        private System.Windows.Forms.Label lbyellowCardsSort;
        private System.Windows.Forms.Label lbGoalsSort;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnSortGoals;
        private System.Windows.Forms.Button btnSortYellowCards;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button RemoveFromFavorites;
        private System.Windows.Forms.Button MoveToFavorites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFavorites;
        private System.Windows.Forms.FlowLayoutPanel flpPlayers;
        private System.Windows.Forms.TabControl tabControl;
    }
}