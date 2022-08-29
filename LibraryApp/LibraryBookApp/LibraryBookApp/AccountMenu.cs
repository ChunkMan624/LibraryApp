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
    public partial class AccountMenu : Form
    {
        public static List<UserStored> userDets = new List<UserStored>();
        public AccountMenu()
        {
            InitializeComponent();
        }

        private void btnRetMain_Click(object sender, EventArgs e)
        {
            //takes the user to the main menu
            MenuMain menuMain = new MenuMain();
            menuMain.Show();
            this.Close();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //logs the user in based on whether the credentials are correct
            foreach (UserStored item in userDets)
            {
                if ((item.username == txbUsername.Text) && (item.password == txbPassword.Text))
                {
                    StreamWriter curUser = new StreamWriter(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\loggedIn.txt", true);
                    curUser.WriteLine("" + item.username + "\r\n" + "" + item.score);
                    curUser.Close();
                    MessageBox.Show("Welcome back " + txbUsername.Text , "Welcome");
                    MenuMain return_menu = new MenuMain();
                    this.Close();
                    return_menu.Show();
                }
            }
            StreamReader error = new StreamReader(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\loggedIn.txt");

            string line1 = error.ReadLine();

            if (line1 == null)
            {
                MessageBox.Show("Incorrect username or password");
            }
            error.Close();

        }

        private void btnCreateShow_Click_1(object sender, EventArgs e)
        {
            //Takes the user to the create user page
            CreateUser userCre = new CreateUser();
            userCre.Show();
            this.Close();
        }


        private void AccountMenu_Load(object sender, EventArgs e)
        {
            userDets.Clear();
            GetUsers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetUsers()
        {
            //Fetches user details from a text file
            StreamReader userRead = new StreamReader(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt");

            while (userRead.ReadLine() != null)
            {
                string line1 = userRead.ReadLine();
                string line2 = userRead.ReadLine();
                int line3 = Convert.ToInt32(userRead.ReadLine());

                userDets.Add(new UserStored(line1, line2, line3));
            }
            userRead.Close();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            //Hides the password
            //Code applied from Stack Overflow
            txbPassword.UseSystemPasswordChar = true;
        }
    }
}
