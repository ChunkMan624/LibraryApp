using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookApp
{
    public class CallsDescrips
    {
        public string itemFirst;

        public CallsDescrips(string itemFirst)
        {
            this.itemFirst = itemFirst;
        }

        public string ItemFirst
        {
            get { return itemFirst; }
            set { itemFirst = value; }
        }

    }
}
