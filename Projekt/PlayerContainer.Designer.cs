namespace Projekt
{
    partial class PlayerContainer
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
            this.lbPlrNumber = new System.Windows.Forms.Label();
            this.lbPlrName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.PicBoxFavorite = new System.Windows.Forms.PictureBox();
            this.PicBoxShirt = new System.Windows.Forms.PictureBox();
            this.PicBoxCaptain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCaptain)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlrNumber
            // 
            this.lbPlrNumber.AutoSize = true;
            this.lbPlrNumber.BackColor = System.Drawing.Color.DarkGray;
            this.lbPlrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlrNumber.Location = new System.Drawing.Point(87, 90);
            this.lbPlrNumber.Name = "lbPlrNumber";
            this.lbPlrNumber.Size = new System.Drawing.Size(29, 31);
            this.lbPlrNumber.TabIndex = 1;
            this.lbPlrNumber.Text = "1";
            this.lbPlrNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // lbPlrName
            // 
            this.lbPlrName.AutoSize = true;
            this.lbPlrName.BackColor = System.Drawing.Color.DarkGray;
            this.lbPlrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlrName.Location = new System.Drawing.Point(64, 35);
            this.lbPlrName.Name = "lbPlrName";
            this.lbPlrName.Size = new System.Drawing.Size(74, 16);
            this.lbPlrName.TabIndex = 2;
            this.lbPlrName.Text = "Testno ime";
            this.lbPlrName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.DarkGray;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(64, 169);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(74, 16);
            this.lbPosition.TabIndex = 4;
            this.lbPosition.Text = "Testno ime";
            this.lbPosition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // PicBoxFavorite
            // 
            this.PicBoxFavorite.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxFavorite.Image = global::Projekt.Images.favorite;
            this.PicBoxFavorite.Location = new System.Drawing.Point(154, 155);
            this.PicBoxFavorite.Name = "PicBoxFavorite";
            this.PicBoxFavorite.Size = new System.Drawing.Size(50, 49);
            this.PicBoxFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxFavorite.TabIndex = 5;
            this.PicBoxFavorite.TabStop = false;
            this.PicBoxFavorite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // PicBoxShirt
            // 
            this.PicBoxShirt.Image = global::Projekt.Images.shirt;
            this.PicBoxShirt.Location = new System.Drawing.Point(0, 0);
            this.PicBoxShirt.Name = "PicBoxShirt";
            this.PicBoxShirt.Size = new System.Drawing.Size(207, 207);
            this.PicBoxShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxShirt.TabIndex = 0;
            this.PicBoxShirt.TabStop = false;
            this.PicBoxShirt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // PicBoxCaptain
            // 
            this.PicBoxCaptain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxCaptain.Image = global::Projekt.Images.captainShirt;
            this.PicBoxCaptain.Location = new System.Drawing.Point(0, 0);
            this.PicBoxCaptain.Name = "PicBoxCaptain";
            this.PicBoxCaptain.Size = new System.Drawing.Size(207, 207);
            this.PicBoxCaptain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCaptain.TabIndex = 3;
            this.PicBoxCaptain.TabStop = false;
            this.PicBoxCaptain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectPlayerContainer_MouseClick);
            // 
            // PlayerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PicBoxFavorite);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbPlrName);
            this.Controls.Add(this.lbPlrNumber);
            this.Controls.Add(this.PicBoxShirt);
            this.Controls.Add(this.PicBoxCaptain);
            this.Name = "PlayerContainer";
            this.Size = new System.Drawing.Size(207, 207);
            this.Load += new System.EventHandler(this.PlayerContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCaptain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxShirt;
        private System.Windows.Forms.Label lbPlrNumber;
        private System.Windows.Forms.Label lbPlrName;
        private System.Windows.Forms.PictureBox PicBoxCaptain;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.PictureBox PicBoxFavorite;
    }
}
