
namespace LibraryBookApp
{
    partial class ReplaceMenu
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
            this.lbxOptions = new System.Windows.Forms.ListBox();
            this.lbxAnswers = new System.Windows.Forms.ListBox();
            this.btnAddAns = new System.Windows.Forms.Button();
            this.btnRemAns = new System.Windows.Forms.Button();
            this.btnSubAns = new System.Windows.Forms.Button();
            this.btnStartRep = new System.Windows.Forms.Button();
            this.btnEndRep = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnViewLead = new System.Windows.Forms.Button();
            this.lblInstruc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxOptions
            // 
            this.lbxOptions.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxOptions.FormattingEnabled = true;
            this.lbxOptions.ItemHeight = 22;
            this.lbxOptions.Location = new System.Drawing.Point(26, 91);
            this.lbxOptions.Name = "lbxOptions";
            this.lbxOptions.Size = new System.Drawing.Size(172, 224);
            this.lbxOptions.TabIndex = 0;
            this.lbxOptions.SelectedIndexChanged += new System.EventHandler(this.lbxOptions_SelectedIndexChanged);
            // 
            // lbxAnswers
            // 
            this.lbxAnswers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAnswers.FormattingEnabled = true;
            this.lbxAnswers.ItemHeight = 22;
            this.lbxAnswers.Location = new System.Drawing.Point(332, 91);
            this.lbxAnswers.Name = "lbxAnswers";
            this.lbxAnswers.Size = new System.Drawing.Size(172, 224);
            this.lbxAnswers.TabIndex = 1;
            this.lbxAnswers.SelectedIndexChanged += new System.EventHandler(this.lbxAnswers_SelectedIndexChanged);
            // 
            // btnAddAns
            // 
            this.btnAddAns.Enabled = false;
            this.btnAddAns.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAns.Location = new System.Drawing.Point(204, 107);
            this.btnAddAns.Name = "btnAddAns";
            this.btnAddAns.Size = new System.Drawing.Size(122, 39);
            this.btnAddAns.TabIndex = 2;
            this.btnAddAns.Text = "Add";
            this.btnAddAns.UseVisualStyleBackColor = true;
            this.btnAddAns.Click += new System.EventHandler(this.btnAddAns_Click);
            // 
            // btnRemAns
            // 
            this.btnRemAns.Enabled = false;
            this.btnRemAns.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemAns.Location = new System.Drawing.Point(204, 172);
            this.btnRemAns.Name = "btnRemAns";
            this.btnRemAns.Size = new System.Drawing.Size(122, 39);
            this.btnRemAns.TabIndex = 3;
            this.btnRemAns.Text = "Remove";
            this.btnRemAns.UseVisualStyleBackColor = true;
            this.btnRemAns.Click += new System.EventHandler(this.btnRemAns_Click);
            // 
            // btnSubAns
            // 
            this.btnSubAns.Enabled = false;
            this.btnSubAns.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubAns.Location = new System.Drawing.Point(204, 238);
            this.btnSubAns.Name = "btnSubAns";
            this.btnSubAns.Size = new System.Drawing.Size(122, 39);
            this.btnSubAns.TabIndex = 4;
            this.btnSubAns.Text = "Submit";
            this.btnSubAns.UseVisualStyleBackColor = true;
            this.btnSubAns.Click += new System.EventHandler(this.btnSubAns_Click);
            // 
            // btnStartRep
            // 
            this.btnStartRep.Location = new System.Drawing.Point(26, 368);
            this.btnStartRep.Name = "btnStartRep";
            this.btnStartRep.Size = new System.Drawing.Size(122, 39);
            this.btnStartRep.TabIndex = 5;
            this.btnStartRep.Text = "Begin";
            this.btnStartRep.UseVisualStyleBackColor = true;
            this.btnStartRep.Click += new System.EventHandler(this.btnStartRep_Click);
            // 
            // btnEndRep
            // 
            this.btnEndRep.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndRep.Location = new System.Drawing.Point(26, 368);
            this.btnEndRep.Name = "btnEndRep";
            this.btnEndRep.Size = new System.Drawing.Size(122, 39);
            this.btnEndRep.TabIndex = 6;
            this.btnEndRep.Text = "End";
            this.btnEndRep.UseVisualStyleBackColor = true;
            this.btnEndRep.Visible = false;
            this.btnEndRep.Click += new System.EventHandler(this.btnEndRep_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(382, 368);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 39);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnViewLead
            // 
            this.btnViewLead.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLead.Location = new System.Drawing.Point(204, 368);
            this.btnViewLead.Name = "btnViewLead";
            this.btnViewLead.Size = new System.Drawing.Size(122, 39);
            this.btnViewLead.TabIndex = 8;
            this.btnViewLead.Text = "Leaderboard";
            this.btnViewLead.UseVisualStyleBackColor = true;
            this.btnViewLead.Click += new System.EventHandler(this.btnViewLead_Click);
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruc.Location = new System.Drawing.Point(84, 47);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(377, 22);
            this.lblInstruc.TabIndex = 9;
            this.lblInstruc.Text = "Sort the dewey decimal numbers into the correct order";
            this.lblInstruc.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(131, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 28);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Call Number Sorting Game";
            // 
            // ReplaceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryBookApp.Properties.Resources.BookBack1;
            this.ClientSize = new System.Drawing.Size(535, 423);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstruc);
            this.Controls.Add(this.btnViewLead);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEndRep);
            this.Controls.Add(this.btnStartRep);
            this.Controls.Add(this.btnSubAns);
            this.Controls.Add(this.btnRemAns);
            this.Controls.Add(this.btnAddAns);
            this.Controls.Add(this.lbxAnswers);
            this.Controls.Add(this.lbxOptions);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ReplaceMenu";
            this.Text = "ReplaceMenu";
            this.Load += new System.EventHandler(this.ReplaceMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOptions;
        private System.Windows.Forms.ListBox lbxAnswers;
        private System.Windows.Forms.Button btnAddAns;
        private System.Windows.Forms.Button btnRemAns;
        private System.Windows.Forms.Button btnSubAns;
        private System.Windows.Forms.Button btnStartRep;
        private System.Windows.Forms.Button btnEndRep;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnViewLead;
        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.Label lblTitle;
    }
}