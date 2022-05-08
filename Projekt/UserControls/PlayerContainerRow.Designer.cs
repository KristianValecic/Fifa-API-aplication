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
            this.PicBoxShirt = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbYellowCards = new System.Windows.Forms.Label();
            this.PicBoxFavorite = new System.Windows.Forms.PictureBox();
            this.lbShirtNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxShirt
            // 
            this.PicBoxShirt.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicBoxShirt.Image = global::Projekt.Images.shirt;
            this.PicBoxShirt.Location = new System.Drawing.Point(0, 0);
            this.PicBoxShirt.Name = "PicBoxShirt";
            this.PicBoxShirt.Size = new System.Drawing.Size(73, 73);
            this.PicBoxShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxShirt.TabIndex = 0;
            this.PicBoxShirt.TabStop = false;
            this.PicBoxShirt.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(79, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Ime i broj";
            this.lbName.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Golovi: ";
            this.label2.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Žuti karton:";
            this.label3.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // lbGoals
            // 
            this.lbGoals.AutoSize = true;
            this.lbGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoals.Location = new System.Drawing.Point(275, 29);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(14, 16);
            this.lbGoals.TabIndex = 5;
            this.lbGoals.Text = "1";
            // 
            // lbYellowCards
            // 
            this.lbYellowCards.AutoSize = true;
            this.lbYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowCards.Location = new System.Drawing.Point(380, 29);
            this.lbYellowCards.Name = "lbYellowCards";
            this.lbYellowCards.Size = new System.Drawing.Size(14, 16);
            this.lbYellowCards.TabIndex = 6;
            this.lbYellowCards.Text = "1";
            this.lbYellowCards.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // PicBoxFavorite
            // 
            this.PicBoxFavorite.Image = global::Projekt.Images.favorite;
            this.PicBoxFavorite.Location = new System.Drawing.Point(55, 54);
            this.PicBoxFavorite.Name = "PicBoxFavorite";
            this.PicBoxFavorite.Size = new System.Drawing.Size(17, 18);
            this.PicBoxFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxFavorite.TabIndex = 7;
            this.PicBoxFavorite.TabStop = false;
            this.PicBoxFavorite.Visible = false;
            this.PicBoxFavorite.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // lbShirtNumber
            // 
            this.lbShirtNumber.AutoSize = true;
            this.lbShirtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShirtNumber.Location = new System.Drawing.Point(78, 41);
            this.lbShirtNumber.Name = "lbShirtNumber";
            this.lbShirtNumber.Size = new System.Drawing.Size(61, 16);
            this.lbShirtNumber.TabIndex = 8;
            this.lbShirtNumber.Text = "Ime i broj";
            this.lbShirtNumber.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            // 
            // PlayerContainerRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(402, 73);
            this.Load += new System.EventHandler(this.PlayerControlRow_Load);
            this.Click += new System.EventHandler(this.PlayerContainerRow_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).EndInit();
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
