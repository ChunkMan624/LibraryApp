using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp
{
    public class MatchCompare
    {
        public string callNo;
        public string description;

        public MatchCompare(string callNo, string description)
        {
            this.callNo = callNo;
            this.description = description;
        }

        public string CallNo
        {
            get { return callNo; }
            set { callNo = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
