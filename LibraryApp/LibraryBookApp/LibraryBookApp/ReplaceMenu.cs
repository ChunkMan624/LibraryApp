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
    public partial class ReplaceMenu : Form
    {
        public static List<UserStored> userDets = new List<UserStored>();
        public List<string> replaceList = new List<string>();
        public List<string> sortList = new List<string>();
        public List<string> finalAns = new List<string>();

        int totalScore = 0;
        int totalFinal { get; set; }
        public ReplaceMenu()
        {
            InitializeComponent();
        }

        private void lbxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void lbxAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAns_Click(object sender, EventArgs e)
        {
            //Adds the answer
            if (lbxOptions.SelectedIndex != -1)
            {
                lbxAnswers.Items.Add(lbxOptions.SelectedItem);
                lbxOptions.Items.Remove(lbxOptions.SelectedItem);
            }

        }

        private void btnRemAns_Click(object sender, EventArgs e)
        {
            //Removes an answer
            if (lbxAnswers.SelectedIndex != -1)
            {
                lbxOptions.Items.Add(lbxAnswers.SelectedItem);
                lbxAnswers.Items.Remove(lbxAnswers.SelectedItem);
            }
            
        }

        private void btnSubAns_Click(object sender, EventArgs e)
        {
            //Submits the users answer
            if (lbxOptions.Items.Count == 0)
            {
                foreach (string item in lbxAnswers.Items)
                {
                    finalAns.Add(item);
                }

                Comparison();
                Ending();
            }
            else
            {
                MessageBox.Show("All options must be selected", "Attention");
            }
            

        }

        private void btnEndRep_Click(object sender, EventArgs e)
        {
            //Ends the game session
            Ending();
        }

        private void btnStartRep_Click(object sender, EventArgs e)
        {
            lblInstruc.Visible = true;
            btnStartRep.Hide();
            btnEndRep.Show();
            btnReturn.Enabled = false;
            btnRemAns.Enabled = true;
            btnSubAns.Enabled = true;
            btnAddAns.Enabled = true;
            btnViewLead.Enabled = false;
            GenerateCalls();
            DisplayList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Returns User to Main Menu
            MenuMain mainMenu = new MenuMain();
            mainMenu.Show();
            this.Close();
        }

        private void GenerateCalls()
        {
            //Randomly creates new call numbers
            //Bug fixes and logic fixes applied from stack overflow
            //Code logic for generator applied from CodeGrepper
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string numberFir = rnd.Next(1, 999).ToString("000");
                string numberSec = rnd.Next(1, 9999).ToString("0000");
                
                int length = 3;
                var authLet = "";
                for (var x = 0; x < length; x++)
                {
                    authLet += ((char)(rnd.Next(1, 26) + 64)).ToString().ToUpper();
                }
                
                string genDec = ("" + numberFir + "." + numberSec + " " + authLet);

                replaceList.Add(genDec);
                sortList.Add(genDec);
            }
            sortList.Sort();
        }
        
        private void DisplayList()
        {
            foreach (string item in replaceList)
                lbxOptions.Items.Add(item);

        }

        private void ReplaceMenu_Load(object sender, EventArgs e)
        {

        }

        public void Comparison()
        {
            //This class talleys the final results of the game
            //Bug fixes and logic fixes applied from Stack Overflow
            UserGet();
            AnswerCount();

            int finalRes = totalScore;
            switch(finalRes)
            {
                case 0:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes*100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;
                case 1:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 2:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 3:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 4:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 5:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 6:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 7:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 8:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;

                case 9:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts", "Final Result");
                    totalFinal = (finalRes * 100);
                    break;
                
                case 10:
                    MessageBox.Show("Your score was " + finalRes + "/10" + "\r\n" + "Your score is:   " + (finalRes * 100) + "pts" + "\r\n" + "Perfect Score Bonus:   250pts", "Final Result");
                    totalFinal = ((finalRes * 100) + 250);
                    break;
            }

            //Applies the final score to the user that is currently logged in
            StreamReader loggedUser = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\loggedIn.txt");
            string line1 = loggedUser.ReadLine();
            string line2 = loggedUser.ReadLine();

            foreach (UserStored item in userDets)
            {
                if (item.username == line1)
                {
                    item.score = item.score + totalFinal;
                }
            }
            loggedUser.Close();

            UserUpdate();
            userDets.Clear();
            
        }

        public void Ending()
        {
            replaceList.Clear();
            sortList.Clear();
            lbxOptions.Items.Clear();
            lbxAnswers.Items.Clear();
            lblInstruc.Visible = false;
            //Makes buttons appear
            btnStartRep.Show();
            btnEndRep.Hide();
            btnReturn.Enabled = true;
            btnRemAns.Enabled = false;
            btnSubAns.Enabled = false;
            btnAddAns.Enabled = false;
            btnViewLead.Enabled = true;
        }

        public void AnswerCount()
        {

            //Adds points for each correct answer made by the user

            if(finalAns.ElementAt(0) == sortList.ElementAt(0))
            {
                totalScore = totalScore + 1;
            }

            if(finalAns.ElementAt(1) == sortList.ElementAt(1))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(2) == sortList.ElementAt(2))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(3) == sortList.ElementAt(3))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(4) == sortList.ElementAt(4))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(5) == sortList.ElementAt(5))
            {
                totalScore = totalScore + 1;
            }
            if (finalAns.ElementAt(6) == sortList.ElementAt(6))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(7) == sortList.ElementAt(7))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(8) == sortList.ElementAt(8))
            {
                totalScore = totalScore + 1;
            }

            if (finalAns.ElementAt(9) == sortList.ElementAt(9))
            {
                totalScore = totalScore + 1;
            }
        }

        private void btnViewLead_Click(object sender, EventArgs e)
        {
            //Takes user to the leaderboard
            LeaderMenu leadBoar = new LeaderMenu();
            leadBoar.Show();
            this.Close();
        }

        private void UserGet()
        {
            //fetches user details from a text file
            StreamReader userRead = new StreamReader(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt");

            while (userRead.ReadLine() != null)
            {
                string line1 = userRead.ReadLine();
                string line2 = userRead.ReadLine();
                int line3 = Convert.ToInt32(userRead.ReadLine());

                userDets.Add(new UserStored(line1, line2, line3));
                
            }
            userRead.Close();
        }

        private void UserUpdate()
        {
            //Updates the text file with new data
            File.WriteAllText(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt", String.Empty);
            StreamWriter update = new StreamWriter(@"C:\Users\User\Desktop\18002919_PROG7312_POE\LibraryBookApp\LibraryBookApp\details.txt");
            foreach (UserStored item in userDets)
            {
                
                update.WriteLine("----------------------" + "\r\n" + "" + item.username + "\r\n" + "" + item.password + "\r\n" + item.score);
                
            }
            update.Close();
        }
    }
}

