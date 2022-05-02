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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbPlrNumber = new System.Windows.Forms.Label();
            this.lbPlrName = new System.Windows.Forms.Label();
            this.pictureBoxCaptain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Projekt.Images.shirt;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 207);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
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
            this.lbPlrNumber.Click += new System.EventHandler(this.pictureBox_Click);
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
            this.lbPlrName.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxCaptain
            // 
            this.pictureBoxCaptain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCaptain.Image = global::Projekt.Images.captainShirt;
            this.pictureBoxCaptain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCaptain.Name = "pictureBoxCaptain";
            this.pictureBoxCaptain.Size = new System.Drawing.Size(207, 207);
            this.pictureBoxCaptain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptain.TabIndex = 3;
            this.pictureBoxCaptain.TabStop = false;
            this.pictureBoxCaptain.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PlayerContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbPlrName);
            this.Controls.Add(this.lbPlrNumber);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBoxCaptain);
            this.Name = "PlayerContainer";
            this.Size = new System.Drawing.Size(207, 207);
            this.Load += new System.EventHandler(this.PlayerContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbPlrNumber;
        private System.Windows.Forms.Label lbPlrName;
        private System.Windows.Forms.PictureBox pictureBoxCaptain;
    }
}
