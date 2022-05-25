namespace Projekt
{
    partial class PlayerContainerSelected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerContainerSelected));
            this.lbShirtNumber = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbYellowCards = new System.Windows.Forms.Label();
            this.PicBoxFavorite = new System.Windows.Forms.PictureBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbShirtNumber
            // 
            resources.ApplyResources(this.lbShirtNumber, "lbShirtNumber");
            this.lbShirtNumber.BackColor = System.Drawing.Color.DarkGray;
            this.lbShirtNumber.Name = "lbShirtNumber";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Name = "lbName";
            // 
            // lbPosition
            // 
            resources.ApplyResources(this.lbPosition, "lbPosition");
            this.lbPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbPosition.Name = "lbPosition";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // lbGoals
            // 
            resources.ApplyResources(this.lbGoals, "lbGoals");
            this.lbGoals.BackColor = System.Drawing.Color.Transparent;
            this.lbGoals.Name = "lbGoals";
            // 
            // lbYellowCards
            // 
            resources.ApplyResources(this.lbYellowCards, "lbYellowCards");
            this.lbYellowCards.BackColor = System.Drawing.Color.Transparent;
            this.lbYellowCards.Name = "lbYellowCards";
            // 
            // PicBoxFavorite
            // 
            resources.ApplyResources(this.PicBoxFavorite, "PicBoxFavorite");
            this.PicBoxFavorite.Image = global::Projekt.Images.favorite;
            this.PicBoxFavorite.Name = "PicBoxFavorite";
            this.PicBoxFavorite.TabStop = false;
            // 
            // PicBox
            // 
            resources.ApplyResources(this.PicBox, "PicBox");
            this.PicBox.BackColor = System.Drawing.Color.Transparent;
            this.PicBox.Image = global::Projekt.Images.shirt;
            this.PicBox.Name = "PicBox";
            this.PicBox.TabStop = false;
            // 
            // PlayerContainerSelected
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PicBoxFavorite);
            this.Controls.Add(this.lbYellowCards);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbShirtNumber);
            this.Controls.Add(this.PicBox);
            this.Name = "PlayerContainerSelected";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbShirtNumber;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbYellowCards;
        private System.Windows.Forms.PictureBox PicBoxFavorite;
    }
}
