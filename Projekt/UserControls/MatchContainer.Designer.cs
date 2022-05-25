namespace Projekt.UserControls
{
    partial class MatchContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchContainer));
            this.lbHomeTeamName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAwayTeamName = new System.Windows.Forms.Label();
            this.lbHomeTeamGoals = new System.Windows.Forms.Label();
            this.lbAwayTeamGoals = new System.Windows.Forms.Label();
            this.lbMatchLocation = new System.Windows.Forms.Label();
            this.lbVisitorsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbHomeTeamName
            // 
            resources.ApplyResources(this.lbHomeTeamName, "lbHomeTeamName");
            this.lbHomeTeamName.Name = "lbHomeTeamName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbAwayTeamName
            // 
            resources.ApplyResources(this.lbAwayTeamName, "lbAwayTeamName");
            this.lbAwayTeamName.Name = "lbAwayTeamName";
            // 
            // lbHomeTeamGoals
            // 
            resources.ApplyResources(this.lbHomeTeamGoals, "lbHomeTeamGoals");
            this.lbHomeTeamGoals.Name = "lbHomeTeamGoals";
            // 
            // lbAwayTeamGoals
            // 
            resources.ApplyResources(this.lbAwayTeamGoals, "lbAwayTeamGoals");
            this.lbAwayTeamGoals.Name = "lbAwayTeamGoals";
            // 
            // lbMatchLocation
            // 
            resources.ApplyResources(this.lbMatchLocation, "lbMatchLocation");
            this.lbMatchLocation.Name = "lbMatchLocation";
            // 
            // lbVisitorsCount
            // 
            resources.ApplyResources(this.lbVisitorsCount, "lbVisitorsCount");
            this.lbVisitorsCount.Name = "lbVisitorsCount";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // MatchContainer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVisitorsCount);
            this.Controls.Add(this.lbMatchLocation);
            this.Controls.Add(this.lbAwayTeamGoals);
            this.Controls.Add(this.lbHomeTeamGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAwayTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHomeTeamName);
            this.Name = "MatchContainer";
            this.Load += new System.EventHandler(this.MatchContainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHomeTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAwayTeamName;
        private System.Windows.Forms.Label lbHomeTeamGoals;
        private System.Windows.Forms.Label lbAwayTeamGoals;
        private System.Windows.Forms.Label lbMatchLocation;
        private System.Windows.Forms.Label lbVisitorsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
