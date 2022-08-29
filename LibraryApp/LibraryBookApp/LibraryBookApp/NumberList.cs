using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp
{
    public class NumberList
    {
        public string genCallNo;

        public NumberList(string genCallNo)
        {
            this.genCallNo = genCallNo;
        }

        public string GenCallNo
        {
            get { return genCallNo; }
            set { genCallNo = value; }
        }
    }

    
}
