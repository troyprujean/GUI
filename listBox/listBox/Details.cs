using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listBox
{
    class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string DisplayName()
        {
            return FirstName + " " + LastName;
        }
    }
}
