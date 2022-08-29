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
    public partial class LeaderMenu : Form
    {
        public static List<UserStored> userDets = new List<UserStored>();
        public static List<LeaderBoard> leadBo = new List<LeaderBoard>();
        public LeaderMenu()
        {
            InitializeComponent();
        }

        private void txbUserFir_TextChanged(object sender, EventArgs e)
        {

        }

        public void LeaderGet()
        {
            //Gets the users details and scores from a text file
            userDets.Clear();
            StreamReader userRead = new StreamReader(@"C:\Users\User\Desktop\LibraryBookApp\LibraryBookApp\details.txt");

            while (userRead.ReadLine() != null)
            {
                string line1 = userRead.ReadLine();
                string line2 = userRead.ReadLine();
                int line3 = Convert.ToInt32(userRead.ReadLine());

                userDets.Add(new UserStored(line1, line2, line3));
            }
            userRead.Close();

            var sortItems = userDets.OrderByDescending(x => x.score);
            foreach (UserStored item in sortItems)
            {
                leadBo.Add(new LeaderBoard(item.username, item.score));
            }
        }

        private void lbxExamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Returns the user to the replace menu
            ReplaceMenu repMen = new ReplaceMenu();
            repMen.Show();
            this.Close();
        }

        private void LeaderMenu_Load(object sender, EventArgs e)
        {
            //Displays the users and their scores in descending order
            //Code and logic applied from csharp corner
            leadBo.Clear();
            LeaderGet();
            lbxExamp.DataSource = leadBo;
            lbxExamp.DisplayMember = "lbScore";
            lbxNameEx.DataSource = leadBo;
            lbxNameEx.DisplayMember = "lbUsername";
            
        }
    }
}
