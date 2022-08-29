
namespace LibraryBookApp
{
    partial class MenuMain
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
            this.btnReplaceBooksSel = new System.Windows.Forms.Button();
            this.btnIdAreaSel = new System.Windows.Forms.Button();
            this.btnFindNoSel = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReplaceBooksSel
            // 
            this.btnReplaceBooksSel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceBooksSel.Location = new System.Drawing.Point(107, 76);
            this.btnReplaceBooksSel.Name = "btnReplaceBooksSel";
            this.btnReplaceBooksSel.Size = new System.Drawing.Size(171, 40);
            this.btnReplaceBooksSel.TabIndex = 0;
            this.btnReplaceBooksSel.Text = "Replace Books";
            this.btnReplaceBooksSel.UseVisualStyleBackColor = true;
            this.btnReplaceBooksSel.Click += new System.EventHandler(this.ReplaceBooksSel_Click);
            // 
            // btnIdAreaSel
            // 
            this.btnIdAreaSel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdAreaSel.Location = new System.Drawing.Point(107, 155);
            this.btnIdAreaSel.Name = "btnIdAreaSel";
            this.btnIdAreaSel.Size = new System.Drawing.Size(171, 40);
            this.btnIdAreaSel.TabIndex = 1;
            this.btnIdAreaSel.Text = "Identifying Areas";
            this.btnIdAreaSel.UseVisualStyleBackColor = true;
            this.btnIdAreaSel.Click += new System.EventHandler(this.IdAreaSel_Click);
            // 
            // btnFindNoSel
            // 
            this.btnFindNoSel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindNoSel.Location = new System.Drawing.Point(107, 244);
            this.btnFindNoSel.Name = "btnFindNoSel";
            this.btnFindNoSel.Size = new System.Drawing.Size(171, 40);
            this.btnFindNoSel.TabIndex = 2;
            this.btnFindNoSel.Text = "Finding Call Numbers";
            this.btnFindNoSel.UseVisualStyleBackColor = true;
            this.btnFindNoSel.Click += new System.EventHandler(this.FindNoSel_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(12, 12);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(89, 31);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(89, 31);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "The Dewey App";
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryBookApp.Properties.Resources.BookBack1;
            this.ClientSize = new System.Drawing.Size(389, 339);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnFindNoSel);
            this.Controls.Add(this.btnIdAreaSel);
            this.Controls.Add(this.btnReplaceBooksSel);
            this.Name = "MenuMain";
            this.Text = "LibraryBookApp";
            this.Load += new System.EventHandler(this.MenuMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplaceBooksSel;
        private System.Windows.Forms.Button btnIdAreaSel;
        private System.Windows.Forms.Button btnFindNoSel;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTitle;
    }
}

