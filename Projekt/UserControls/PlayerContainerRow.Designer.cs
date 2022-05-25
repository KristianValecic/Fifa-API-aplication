namespace Projekt
{
    partial class PlayerContainerRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerContainerRow));
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbYellowCards = new System.Windows.Forms.Label();
            this.lbShirtNumber = new System.Windows.Forms.Label();
            this.PicBoxFavorite = new System.Windows.Forms.PictureBox();
            this.PicBoxShirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            this.lbName.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // lbGoals
            // 
            resources.ApplyResources(this.lbGoals, "lbGoals");
            this.lbGoals.Name = "lbGoals";
            // 
            // lbYellowCards
            // 
            resources.ApplyResources(this.lbYellowCards, "lbYellowCards");
            this.lbYellowCards.Name = "lbYellowCards";
            this.lbYellowCards.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // lbShirtNumber
            // 
            resources.ApplyResources(this.lbShirtNumber, "lbShirtNumber");
            this.lbShirtNumber.Name = "lbShirtNumber";
            this.lbShirtNumber.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // PicBoxFavorite
            // 
            resources.ApplyResources(this.PicBoxFavorite, "PicBoxFavorite");
            this.PicBoxFavorite.Image = global::Projekt.Images.favorite;
            this.PicBoxFavorite.Name = "PicBoxFavorite";
            this.PicBoxFavorite.TabStop = false;
            this.PicBoxFavorite.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // PicBoxShirt
            // 
            resources.ApplyResources(this.PicBoxShirt, "PicBoxShirt");
            this.PicBoxShirt.Image = global::Projekt.Images.shirt;
            this.PicBoxShirt.Name = "PicBoxShirt";
            this.PicBoxShirt.TabStop = false;
            this.PicBoxShirt.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // PlayerContainerRow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbShirtNumber);
            this.Controls.Add(this.PicBoxFavorite);
            this.Controls.Add(this.lbYellowCards);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.PicBoxShirt);
            this.Name = "PlayerContainerRow";
            this.Load += new System.EventHandler(this.PlayerControlRow_Load);
            this.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxShirt;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbYellowCards;
        private System.Windows.Forms.PictureBox PicBoxFavorite;
        private System.Windows.Forms.Label lbShirtNumber;
    }
}
