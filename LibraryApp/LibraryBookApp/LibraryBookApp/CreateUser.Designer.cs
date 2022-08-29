
namespace LibraryBookApp
{
    partial class CreateUser
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
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnSignShow = new System.Windows.Forms.Button();
            this.btnRetMain = new System.Windows.Forms.Button();
            this.lblCreUsername = new System.Windows.Forms.Label();
            this.lblCrePass = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.txbCreUser = new System.Windows.Forms.TextBox();
            this.txbCrePass = new System.Windows.Forms.TextBox();
            this.txbConfPass = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(83, 230);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(116, 33);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create User";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnSignShow
            // 
            this.btnSignShow.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignShow.Location = new System.Drawing.Point(12, 12);
            this.btnSignShow.Name = "btnSignShow";
            this.btnSignShow.Size = new System.Drawing.Size(83, 32);
            this.btnSignShow.TabIndex = 8;
            this.btnSignShow.Text = "Sign In";
            this.btnSignShow.UseVisualStyleBackColor = true;
            this.btnSignShow.Click += new System.EventHandler(this.btnSignShow_Click);
            // 
            // btnRetMain
            // 
            this.btnRetMain.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetMain.Location = new System.Drawing.Point(308, 230);
            this.btnRetMain.Name = "btnRetMain";
            this.btnRetMain.Size = new System.Drawing.Size(116, 33);
            this.btnRetMain.TabIndex = 9;
            this.btnRetMain.Text = "Back";
            this.btnRetMain.UseVisualStyleBackColor = true;
            this.btnRetMain.Click += new System.EventHandler(this.btnRetMain_Click);
            // 
            // lblCreUsername
            // 
            this.lblCreUsername.AutoSize = true;
            this.lblCreUsername.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreUsername.Location = new System.Drawing.Point(80, 84);
            this.lblCreUsername.Name = "lblCreUsername";
            this.lblCreUsername.Size = new System.Drawing.Size(80, 22);
            this.lblCreUsername.TabIndex = 10;
            this.lblCreUsername.Text = "Username";
            // 
            // lblCrePass
            // 
            this.lblCrePass.AutoSize = true;
            this.lblCrePass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrePass.Location = new System.Drawing.Point(80, 125);
            this.lblCrePass.Name = "lblCrePass";
            this.lblCrePass.Size = new System.Drawing.Size(74, 22);
            this.lblCrePass.TabIndex = 11;
            this.lblCrePass.Text = "Password";
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.Location = new System.Drawing.Point(80, 171);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(135, 22);
            this.lblConfPass.TabIndex = 12;
            this.lblConfPass.Text = "Confirm Password";
            // 
            // txbCreUser
            // 
            this.txbCreUser.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCreUser.Location = new System.Drawing.Point(242, 81);
            this.txbCreUser.Name = "txbCreUser";
            this.txbCreUser.Size = new System.Drawing.Size(219, 29);
            this.txbCreUser.TabIndex = 13;
            this.txbCreUser.TextChanged += new System.EventHandler(this.txbCreUser_TextChanged);
            // 
            // txbCrePass
            // 
            this.txbCrePass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCrePass.Location = new System.Drawing.Point(242, 122);
            this.txbCrePass.Name = "txbCrePass";
            this.txbCrePass.Size = new System.Drawing.Size(219, 29);
            this.txbCrePass.TabIndex = 14;
            this.txbCrePass.TextChanged += new System.EventHandler(this.txbCrePass_TextChanged);
            // 
            // txbConfPass
            // 
            this.txbConfPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfPass.Location = new System.Drawing.Point(242, 168);
            this.txbConfPass.Name = "txbConfPass";
            this.txbConfPass.Size = new System.Drawing.Size(219, 29);
            this.txbConfPass.TabIndex = 15;
            this.txbConfPass.TextChanged += new System.EventHandler(this.txbConfPass_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 26);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Create New User";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryBookApp.Properties.Resources.BookBack;
            this.ClientSize = new System.Drawing.Size(508, 287);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txbConfPass);
            this.Controls.Add(this.txbCrePass);
            this.Controls.Add(this.txbCreUser);
            this.Controls.Add(this.lblConfPass);
            this.Controls.Add(this.lblCrePass);
            this.Controls.Add(this.lblCreUsername);
            this.Controls.Add(this.btnRetMain);
            this.Controls.Add(this.btnSignShow);
            this.Controls.Add(this.btnCreateNew);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnSignShow;
        private System.Windows.Forms.Button btnRetMain;
        private System.Windows.Forms.Label lblCreUsername;
        private System.Windows.Forms.Label lblCrePass;
        private System.Windows.Forms.Label lblConfPass;
        private System.Windows.Forms.TextBox txbCreUser;
        private System.Windows.Forms.TextBox txbCrePass;
        private System.Windows.Forms.TextBox txbConfPass;
        private System.Windows.Forms.Label lblTitle;
    }
}