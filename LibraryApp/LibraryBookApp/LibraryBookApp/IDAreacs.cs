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
    public partial class IDAreacs : Form
    {
        Dictionary<string, string> calls = new Dictionary<string, string>();
        Dictionary<string, string> tempSto = new Dictionary<string, string>();
        Dictionary<string, string> comp = new Dictionary<string, string>();
        Dictionary<string, string> ansComp = new Dictionary<string, string>();
        public List<string> callLi = new List<string>();
        public List<string> tempLi = new List<string>();
        public List<string> clues = new List<string>();
        public List<string> answers = new List<string>();
        public static List<UserStored> userDets = new List<UserStored>();
        //public static List<MatchCompare> ansComp = new List<MatchCompare>();
        string descrip { get; set; }
        int totalScore = 0;
        int totalFinal { get; set; }
        public IDAreacs()
        {
            InitializeComponent();
        }

        private void lblNo1_Click(object sender, EventArgs e)
        {

        }

        private void IDAreacs_Load(object sender, EventArgs e)
        {
            
        }

        private void NumGen()
        {
            //Populates the dictionary
            Random rnd = new Random();

            int numberRandFir = rnd.Next(1, 99);
            string descripFir = "General works";
            tempSto.Add(numberRandFir.ToString("000"), descripFir);
            ansComp.Add(numberRandFir.ToString("000"), descripFir);

            int numberRandSec = rnd.Next(100, 199);
            string descripSec = "Philosophy and Psychology";
            tempSto.Add(numberRandSec.ToString("000"), descripSec);
            ansComp.Add(numberRandSec.ToString("000"), descripSec);

            int numberRandThir = rnd.Next(200, 299);
            string descripThir = "Religion";
            tempSto.Add(numberRandThir.ToString("000"), descripThir);
            ansComp.Add(numberRandThir.ToString("000"), descripThir);

            int numberRandFour = rnd.Next(300, 399);
            string descripFour = "Social Sciences";
            tempSto.Add(numberRandFour.ToString("000"), descripFour);
            ansComp.Add(numberRandFour.ToString("000"), descripFour);

            int numberRandFif = rnd.Next(400, 499);
            string descripFif = "Language";
            tempSto.Add(numberRandFif.ToString("000"), descripFif);
            ansComp.Add(numberRandFif.ToString("000"), descripFif);


            int numberRandSix = rnd.Next(500, 599);
            string descripSix = "Natural Sciences and Mathematics";
            tempSto.Add(numberRandSix.ToString("000"), descripSix);
            ansComp.Add(numberRandSix.ToString("000"), descripSix);


            int numberRandSev = rnd.Next(600, 699);
            string descripSev = "Technology";
            tempSto.Add(numberRandSev.ToString("000"), descripSev);
            ansComp.Add(numberRandSev.ToString("000"), descripSev);


            int numberRandEigh = rnd.Next(700, 799);
            string descripEigh = "The Arts";
            tempSto.Add(numberRandEigh.ToString("000"), descripEigh);
            ansComp.Add(numberRandEigh.ToString("000"), descripEigh);


            int numberRandNin = rnd.Next(800, 899);
            string descripNin = "Literature and Rhetoric";
            tempSto.Add(numberRandNin.ToString("000"), descripNin);
            ansComp.Add(numberRandNin.ToString("000"), descripNin);


            int numberRandTen = rnd.Next(900, 999);
            string descripTen = "History, Biography, and Geography";
            tempSto.Add(numberRandTen.ToString("000"), descripTen);
            ansComp.Add(numberRandTen.ToString("000"), descripTen);

            //for (int i = 0; i < 10; i++)
            //{


            /*//foreach(KeyValuePair<string, string> kid in calls)
            //{
            //if (numberRand.ToString("000") == kid.Key)
            //{
            if (numberRand >= 0 && numberRand <= 99)
                        {
                            descrip = "General works";
                        }
                        else if (numberRand >= 100 && numberRand <= 199)
                        {
                            descrip = "Philosophy and Psychology";
                        }
                        else if (numberRand >= 200 && numberRand <= 299)
                        {
                            descrip = "Religion";
                        }
                        else if (numberRand >= 300 && numberRand <= 399)
                        {
                            descrip = "Social Sciences";
                        }
                        else if (numberRand >= 400 && numberRand <= 499)
                        {
                            descrip = "Language";
                        }
                        else if (numberRand >= 500 && numberRand <= 599)
                        {
                            descrip = "Natural Sciences and Mathematics";
                        }
                        else if (numberRand >= 600 && numberRand <= 699)
                        {
                            descrip = "Technology";
                        }
                        else if (numberRand >= 700 && numberRand <= 799)
                        {
                            descrip = "The Arts";
                        }
                        else if (numberRand >= 800 && numberRand <= 899)
                        {
                            descrip = "Literature and Rhetoric";
                        }
                        else if (numberRand >= 900 && numberRand <= 999)
                        {
                            descrip = "History, Biography, and Geography";
                        }
                        calls.Add(numberRand.ToString("000"), descrip);
                    //}

               // }
               
                
            //}*/

        }

        public void AddNew()
        {
            foreach(KeyValuePair<string, string> kid in tempSto)
            {

                try
                {
                    calls.Add(kid.Key, kid.Value);
                }
                catch(ArgumentException e)
                {

                }


            }
        }


        private void Selct()
        {
            Random rnd = new Random();
            //Attributed from stack overflow
            var randomNumbers = Enumerable.Range(0, 9).OrderBy(x => rnd.Next()).Take(7).ToList();

            foreach(int item in randomNumbers)
            {
                int dataType = rnd.Next(1, 3);

                if (dataType == 1)
                {
                    clues.Add(tempSto.Keys.ElementAt(item));
                    answers.Add(tempSto.Values.ElementAt(item));
                }
                else if (dataType == 2)
                {
                    clues.Add(tempSto.Values.ElementAt(item));
                    answers.Add(tempSto.Keys.ElementAt(item));
                }
                
            }
            tempSto.Clear();
        }
        

        private void Outputs()
        {
            Random rnd = new Random();

            //Outputs for the clues
            txbClueFir.Text = clues.ElementAt(0);
            txbClueSec.Text = clues.ElementAt(1);
            txbClueThir.Text = clues.ElementAt(2);
            txbClueFour.Text = clues.ElementAt(3);

            //Outputs for answers
            //Attributed from code grepper
            var shuffled = answers.OrderBy(a => Guid.NewGuid()).ToList();

            foreach (var value in shuffled)
            {
                txbAnsFir.Text = shuffled.ElementAt(0);
                txbAnsSec.Text = shuffled.ElementAt(1);
                txbAnsThir.Text = shuffled.ElementAt(2);
                txbAnsFour.Text = shuffled.ElementAt(3);
                txbAnsFif.Text = shuffled.ElementAt(4);
                txbAnsSix.Text = shuffled.ElementAt(5);
                txbAnsSev.Text = shuffled.ElementAt(6);
            }

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnEnd.Visible = true;
            btnStart.Visible = false;
            Clear();
            NumGen();

            //AddNew();
            Selct();
            Outputs();
            DataPersist();           
            
        }

        private void Clear()
        {
            //Clears all stored data
            calls.Clear();
            tempSto.Clear();
            clues.Clear();
            answers.Clear();
        }

        private void lbxKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataPersist()
        {
            //Made to store data
            foreach (KeyValuePair<string, string> cid in tempSto)
            {
                if(callLi.Contains(cid.Key))
                {

                }
                else
                {
                    callLi.Add(cid.Key);
                    tempLi.Add(cid.Value);
                    ansComp.Add(cid.Key, cid.Value);
                }
                
            }


                    
            
            callLi.Sort();


        }

        private void AnsMatch()
        {
            //Matches the answers to the clues based on the number slected
            comp.Clear();
            if(nudFir.Value == 1)
            {
                comp.Add(txbClueFir.Text, txbAnsFir.Text);
            }
            else if (nudFir.Value == 2)
            {
                comp.Add(txbClueFir.Text, txbAnsSec.Text);
            }
            else if (nudFir.Value == 3)
            {
                comp.Add(txbClueFir.Text, txbAnsThir.Text);
            }
            else if (nudFir.Value == 4)
            {
                comp.Add(txbClueFir.Text, txbAnsFour.Text);
            }
            else if (nudFir.Value == 5)
            {
                comp.Add(txbClueFir.Text, txbAnsFif.Text);
            }
            else if (nudFir.Value == 6)
            {
                comp.Add(txbClueFir.Text, txbAnsSix.Text);
            }
            else if (nudFir.Value == 7)
            {
                comp.Add(txbClueFir.Text, txbAnsSev.Text);
            }

            if (nudSec.Value == 1)
            {
                comp.Add(txbClueSec.Text, txbAnsFir.Text);
            }
            else if (nudSec.Value == 2)
            {
                comp.Add(txbClueSec.Text, txbAnsSec.Text);
            }
            else if (nudSec.Value == 3)
            {
                comp.Add(txbClueSec.Text, txbAnsThir.Text);
            }
            else if (nudSec.Value == 4)
            {
                comp.Add(txbClueSec.Text, txbAnsFour.Text);
            }
            else if (nudSec.Value == 5)
            {
                comp.Add(txbClueSec.Text, txbAnsFif.Text);
            }
            else if (nudSec.Value == 6)
            {
                comp.Add(txbClueSec.Text, txbAnsSix.Text);
            }
            else if (nudSec.Value == 7)
            {
                comp.Add(txbClueSec.Text, txbAnsSev.Text);
            }

            if (nudThir.Value == 1)
            {
                comp.Add(txbClueThir.Text, txbAnsFir.Text);
            }
            else if (nudThir.Value == 2)
            {
                comp.Add(txbClueThir.Text, txbAnsSec.Text);
            }
            else if (nudThir.Value == 3)
            {
                comp.Add(txbClueThir.Text, txbAnsThir.Text);
            }
            else if (nudThir.Value == 4)
            {
                comp.Add(txbClueThir.Text, txbAnsFour.Text);
            }
            else if (nudThir.Value == 5)
            {
                comp.Add(txbClueThir.Text, txbAnsFif.Text);
            }
            else if (nudThir.Value == 6)
            {
                comp.Add(txbClueThir.Text, txbAnsSix.Text);
            }
            else if (nudThir.Value == 7)
            {
                comp.Add(txbClueThir.Text, txbAnsSev.Text);
            }

            if (nudFour.Value == 1)
            {
                comp.Add(txbClueFour.Text, txbAnsFir.Text);
            }
            else if (nudFour.Value == 2)
            {
                comp.Add(txbClueFour.Text, txbAnsSec.Text);
            }
            else if (nudFour.Value == 3)
            {
                comp.Add(txbClueFour.Text, txbAnsThir.Text);
            }
            else if (nudFour.Value == 4)
            {
                comp.Add(txbClueFour.Text, txbAnsFour.Text);
            }
            else if (nudFour.Value == 5)
            {
                comp.Add(txbClueFour.Text, txbAnsFif.Text);
            }
            else if (nudFour.Value == 6)
            {
                comp.Add(txbClueFour.Text, txbAnsSix.Text);
            }
            else if (nudFour.Value == 7)
            {
                comp.Add(txbClueFour.Text, txbAnsSev.Text);
            }


            tempSto.Clear();
            //Attributed form Stack Overflow
            foreach (KeyValuePair<string, string> anc in ansComp)
            {
                if (anc.Key.Length > 4)
                {
                    tempSto.Add(anc.Value, anc.Key);

                }
                else
                {
                    tempSto.Add(anc.Key, anc.Value);

                }
            }

            calls.Clear();
            //Attributed from stack overflow
            foreach (KeyValuePair<string, string> coc in comp)
            {
                if (coc.Key.Length > 4)
                {
                    calls.Add(coc.Value, coc.Key);

                }
                else
                {

                    calls.Add(coc.Key, coc.Value);
                }
            }


            if (txbAnsFir.Text.Length < 3)
            {
                if (calls[txbClueFir.Text].Equals(tempSto[txbClueFir.Text]))
                {
                    totalScore++;
                }
            }
            else
            {
                if (tempSto.ContainsValue(txbClueFir.Text))
                {
                    totalScore++;
                }
            }

            if (txbAnsSec.Text.Length < 3)
            {
                if (calls[txbClueSec.Text].Equals(tempSto[txbClueSec.Text]))
                {
                    totalScore++;
                }
            }
            else
            {
                if (tempSto.ContainsValue(txbClueSec.Text))
                {
                    totalScore++;
                }
            }

            if (txbAnsThir.Text.Length < 3)
            {
                if (calls[txbClueThir.Text].Equals(tempSto[txbClueThir.Text]))
                {
                    totalScore++;
                }
            }
            else
            {
                if (tempSto.ContainsValue(txbClueThir.Text))
                {
                    totalScore++;
                }
            }

            if (txbAnsFour.Text.Length < 3)
            {
                if (calls[txbClueFour.Text].Equals(tempSto[txbClueFour.Text]))
                {
                    totalScore++;
                }
            }

            else
            {
                if (tempSto.ContainsValue(txbClueFour.Text))
                {
                    totalScore++;
                }
            }



        }

        private void Score()
        {
            UserGet();
            AnsMatch();

            int finalRes = totalScore;
            //Attributed from Stack overflow
            switch (finalRes)
            {
                case 0:
                    totalFinal = 0;
                    MessageBox.Show("Your final score was " + totalFinal, "Attention");
                    break;
                case 1:
                    totalFinal = 250;
                    MessageBox.Show("Your final score was " + totalFinal, "Attention");
                    break;

                case 2:
                    totalFinal = 500;
                    MessageBox.Show("Your final score was " + totalFinal, "Attention");
                    break;

                case 3:
                    totalFinal = 750;
                    MessageBox.Show("Your final score was " + totalFinal, "Attention");
                    break;

                case 4:
                    totalFinal = 1000;
                    MessageBox.Show("Your final score was " + totalFinal, "Attention");
                    break;
            }
            StreamReader loggedUser = new StreamReader(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\loggedIn.txt");
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


        private void UserUpdate()
        {
            //Updates the text file with new data
            File.WriteAllText(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt", String.Empty);
            StreamWriter update = new StreamWriter(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt");
            foreach (UserStored item in userDets)
            {

                update.WriteLine("----------------------" + "\r\n" + "" + item.username + "\r\n" + "" + item.password + "\r\n" + item.score);

            }
            update.Close();
        }

        private void UserGet()
        {
            //fetches user details from a text file
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //Submits the answers
            Score();
            GameEnd();
            
        }

        private void Swapper()
        {
            tempSto.Clear();
            foreach(KeyValuePair<string, string> anc in ansComp)
            {
                if(anc.Key.Length < 3)
                {
                    tempSto.Add(anc.Value, anc.Key);
                    
                }
                else
                {
                    tempSto.Add(anc.Key, anc.Value);

                }
            }

            calls.Clear();
            foreach (KeyValuePair<string, string> coc in comp)
            {
                if (coc.Key.Length < 3)
                {
                    calls.Add(coc.Value, coc.Key);

                }
                else
                {
                    
                    calls.Add(coc.Key, coc.Value);
                }
            }

            
        }
        private void GameEnd()
        {
            //Clears texboxes and ends game
            txbAnsFir.Text = "";
            txbAnsSec.Text = "";
            txbAnsThir.Text = "";
            txbAnsFour.Text = "";
            txbAnsFif.Text = "";
            txbAnsSix.Text = "";
            txbAnsSev.Text = "";
            txbClueFir.Text = "";
            txbClueSec.Text = "";
            txbClueThir.Text = "";
            txbClueFour.Text = "";
            btnEnd.Visible = false;
            btnStart.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Ends the game
            GameEnd();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Returns user to the main menu
            MenuMain mainMenu = new MenuMain();
            mainMenu.Show();
            this.Close();
        }
    }
}
