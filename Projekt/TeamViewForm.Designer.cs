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
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsPlayerList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajIgračeUFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.makniSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makniSlikuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cmsFavoritesList.SuspendLayout();
            this.cmsPlayerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(846, 567);
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
            this.tabPage1.Size = new System.Drawing.Size(838, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.flpFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavorites.ContextMenuStrip = this.cmsFavoritesList;
            this.flpFavorites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFavorites.Location = new System.Drawing.Point(3, 308);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(832, 230);
            this.flpFavorites.TabIndex = 1;
            // 
            // cmsFavoritesList
            // 
            this.cmsFavoritesList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makniOznačeneFavoriteToolStripMenuItem,
            this.dodajSlikuToolStripMenuItem1,
            this.makniSlikuToolStripMenuItem1});
            this.cmsFavoritesList.Name = "cmsFavoritesList";
            this.cmsFavoritesList.Size = new System.Drawing.Size(204, 92);
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
            // flpPlayers
            // 
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.ContextMenuStrip = this.cmsPlayerList;
            this.flpPlayers.Location = new System.Drawing.Point(3, 26);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(827, 230);
            this.flpPlayers.TabIndex = 0;
            this.flpPlayers.WrapContents = false;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // makniSlikuToolStripMenuItem
            // 
            this.makniSlikuToolStripMenuItem.Name = "makniSlikuToolStripMenuItem";
            this.makniSlikuToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.makniSlikuToolStripMenuItem.Text = "Makni sliku";
            this.makniSlikuToolStripMenuItem.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // makniSlikuToolStripMenuItem1
            // 
            this.makniSlikuToolStripMenuItem1.Name = "makniSlikuToolStripMenuItem1";
            this.makniSlikuToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.makniSlikuToolStripMenuItem1.Text = "Makni sliku";
            this.makniSlikuToolStripMenuItem1.Click += new System.EventHandler(this.RemoveImage_click);
            // 
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 567);
            this.Controls.Add(this.tabControl);
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cmsFavoritesList.ResumeLayout(false);
            this.cmsPlayerList.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}