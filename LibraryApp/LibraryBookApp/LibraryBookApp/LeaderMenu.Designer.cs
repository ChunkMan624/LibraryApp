
namespace LibraryBookApp
{
    partial class LeaderMenu
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
            this.lbxExamp = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbxNameEx = new System.Windows.Forms.ListBox();
            this.lblLeadName = new System.Windows.Forms.Label();
            this.lblLeadScore = new System.Windows.Forms.Label();
            this.lblLeadTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxExamp
            // 
            this.lbxExamp.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExamp.FormattingEnabled = true;
            this.lbxExamp.ItemHeight = 22;
            this.lbxExamp.Location = new System.Drawing.Point(254, 63);
            this.lbxExamp.Name = "lbxExamp";
            this.lbxExamp.Size = new System.Drawing.Size(193, 268);
            this.lbxExamp.TabIndex = 1;
            this.lbxExamp.SelectedIndexChanged += new System.EventHandler(this.lbxExamp_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(159, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbxNameEx
            // 
            this.lbxNameEx.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNameEx.FormattingEnabled = true;
            this.lbxNameEx.ItemHeight = 22;
            this.lbxNameEx.Location = new System.Drawing.Point(12, 63);
            this.lbxNameEx.Name = "lbxNameEx";
            this.lbxNameEx.Size = new System.Drawing.Size(193, 268);
            this.lbxNameEx.TabIndex = 3;
            // 
            // lblLeadName
            // 
            this.lblLeadName.AutoSize = true;
            this.lblLeadName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadName.Location = new System.Drawing.Point(63, 38);
            this.lblLeadName.Name = "lblLeadName";
            this.lblLeadName.Size = new System.Drawing.Size(80, 22);
            this.lblLeadName.TabIndex = 4;
            this.lblLeadName.Text = "Username";
            // 
            // lblLeadScore
            // 
            this.lblLeadScore.AutoSize = true;
            this.lblLeadScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadScore.Location = new System.Drawing.Point(324, 38);
            this.lblLeadScore.Name = "lblLeadScore";
            this.lblLeadScore.Size = new System.Drawing.Size(53, 22);
            this.lblLeadScore.TabIndex = 5;
            this.lblLeadScore.Text = "Scores";
            // 
            // lblLeadTitle
            // 
            this.lblLeadTitle.AutoSize = true;
            this.lblLeadTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeadTitle.Location = new System.Drawing.Point(95, 9);
            this.lblLeadTitle.Name = "lblLeadTitle";
            this.lblLeadTitle.Size = new System.Drawing.Size(282, 26);
            this.lblLeadTitle.TabIndex = 6;
            this.lblLeadTitle.Text = "Welcome To The Leaderboard";
            // 
            // LeaderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryBookApp.Properties.Resources.BookBack1;
            this.ClientSize = new System.Drawing.Size(459, 419);
            this.Controls.Add(this.lblLeadTitle);
            this.Controls.Add(this.lblLeadScore);
            this.Controls.Add(this.lblLeadName);
            this.Controls.Add(this.lbxNameEx);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxExamp);
            this.Name = "LeaderMenu";
            this.Text = "LeaderMenu";
            this.Load += new System.EventHandler(this.LeaderMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxExamp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbxNameEx;
        private System.Windows.Forms.Label lblLeadName;
        private System.Windows.Forms.Label lblLeadScore;
        private System.Windows.Forms.Label lblLeadTitle;
    }
}