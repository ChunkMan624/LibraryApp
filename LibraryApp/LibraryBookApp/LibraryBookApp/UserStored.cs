using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp
{
    public class UserStored
    {
        public string username;
        public string password;
        public int score;

        public UserStored(string username, string password, int score)
        {
            this.username = username;
            this.password = password;
            this.score = score;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
