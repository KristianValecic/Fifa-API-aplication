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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveFromFavorites = new System.Windows.Forms.Button();
            this.MoveToFavorites = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.flpFavorites.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpFavorites.Location = new System.Drawing.Point(3, 308);
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.Size = new System.Drawing.Size(832, 230);
            this.flpFavorites.TabIndex = 1;
            // 
            // flpPlayers
            // 
            this.flpPlayers.AutoScroll = true;
            this.flpPlayers.Location = new System.Drawing.Point(3, 26);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(827, 230);
            this.flpPlayers.TabIndex = 0;
            this.flpPlayers.WrapContents = false;
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
            // TeamViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 567);
            this.Controls.Add(this.tabControl);
            this.Name = "TeamViewForm";
            this.Text = "TeamViewForm";
            this.Load += new System.EventHandler(this.TeamViewForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}