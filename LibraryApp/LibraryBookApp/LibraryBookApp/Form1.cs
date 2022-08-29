using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookApp
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        private void ReplaceBooksSel_Click(object sender, EventArgs e)
        {
            //Takes user to the Replace menu Page
            ReplaceMenu repMenu = new ReplaceMenu();
            repMenu.Show();
            this.Hide();
        }

        private void IdAreaSel_Click(object sender, EventArgs e)
        {
            //Takes the user to the area select menu
            IDAreacs idArea = new IDAreacs();
            idArea.Show();
            this.Hide();
        }

        private void FindNoSel_Click(object sender, EventArgs e)
        {
            //Takes the user to the number select menu
            FindingCallMenu find = new FindingCallMenu();
            find.Show();
            this.Hide();
        }

        private void MenuMain_Load(object sender, EventArgs e)
        {
            LoggedIn();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Takes the user to the sign in menu
            AccountMenu acMen = new AccountMenu();
            acMen.Show();
            this.Hide();
        }

        private void LoggedIn()
        {
            //Checks to see if the user is currently logged in
            StreamReader loggedUser = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_Task2\LibraryBookApp\LibraryBookApp\loggedIn.txt");
            string line1 = loggedUser.ReadLine();
            string line2 = loggedUser.ReadLine();

            if((line1 == null) || (line2 == null))
            {
                btnLogIn.Visible = true;
                btnLogOut.Visible = false;
                btnReplaceBooksSel.Enabled = false;
                btnIdAreaSel.Enabled = false;
                btnFindNoSel.Enabled = false;
            }
            else
            {
                btnLogIn.Visible = false;
                btnLogOut.Visible = true;
                btnReplaceBooksSel.Enabled = true;
                btnIdAreaSel.Enabled = true;
                btnFindNoSel.Enabled = true;
            }
            loggedUser.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Logs the user out
            File.WriteAllText(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\loggedIn.txt", String.Empty);
            btnLogIn.Visible = true;
            btnLogOut.Visible = false;
            btnReplaceBooksSel.Enabled = false;
            btnIdAreaSel.Enabled = false;
            btnFindNoSel.Enabled = false;
        }

        
    }
}
