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
    public partial class CreateUser : Form
    {
        public static List<UserStored> userDets = new List<UserStored>();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void txbCreUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            //Creates a new user
            //Checks to see if username is taken
            string match = "False";
            StreamReader compare = new StreamReader(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt");
            while (compare.ReadLine() != null)
            {
                string line1 = compare.ReadLine();
                string line2 = compare.ReadLine();
                int line3 = Convert.ToInt32(compare.ReadLine());

                userDets.Add(new UserStored(line1, line2, line3));
            }
            compare.Close();

            foreach(UserStored item in userDets)
            {
                if(item.username == txbCreUser.Text)
                {
                    
                    match = "True";
                    break;
                }
                
            }
            //If username is taken
            if(match == "True")
            {
                MessageBox.Show("This username is taken", "Attention");
                
            }
            //If username is available
            else
            {
                StreamWriter newUser = new StreamWriter(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt", true);
                if ((txbCreUser.Text != "") && (txbCrePass.Text != "") && (txbConfPass.Text == txbCrePass.Text))
                {
                    newUser.WriteLine("----------------------" + "\r\n" + "" + txbCreUser.Text + "\r\n" + "" + txbCrePass.Text + "\r\n" + "0");
                    newUser.Close();
                    MessageBox.Show("User " + txbCreUser.Text + " has been created", "User Created");
                    AccountMenu acMen = new AccountMenu();
                    acMen.Show();
                    this.Close();
                }
                else if ((txbCrePass.Text == "") || (txbCreUser.Text == "") || (txbConfPass.Text == ""))
                {
                    MessageBox.Show("Please fill in all fields", "Error");
                }
                else if ((txbCreUser.Text != "") && (txbCrePass.Text != "") && (txbConfPass.Text != txbCrePass.Text))
                {
                    MessageBox.Show("Passwords do not match", "Error");
                }
            }

            userDets.Clear();

        }

        private void btnRetMain_Click(object sender, EventArgs e)
        {
            //returns the user to the main menu
            MenuMain mainMenu = new MenuMain();
            mainMenu.Show();
            this.Close();
        }

        private void btnSignShow_Click(object sender, EventArgs e)
        {
            //Returns the user to the sign in menu
            AccountMenu acMen = new AccountMenu();
            acMen.Show();
            this.Close();
        }

        private void txbCrePass_TextChanged(object sender, EventArgs e)
        {
            //Hides the password
            //Code applied from Stack Overflow
            txbCrePass.UseSystemPasswordChar = true;
        }

        private void txbConfPass_TextChanged(object sender, EventArgs e)
        {
            //Hides the password
            //Code applied from Stack Overflow
            txbConfPass.UseSystemPasswordChar = true;
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
