using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp
{
    public class LeaderBoard
    {
        public string lbUsername;
        public int lbScore;

        public LeaderBoard(string lbUsername, int lbScore)
        {
            this.lbUsername = lbUsername;
            this.lbScore = lbScore;
        }

        public string LbUsername
        {
            get { return lbUsername; }
            set { lbUsername = value; }
        }

        public int LbScore
        {
            get { return lbScore; }
            set { lbScore = value; }
        }
    }
}
