using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_C_Sharp
{
    class Person
    {
        public string firstname;
        public string middlename;
        public string lastname;

        public string GetFullName()
        {
            string FullName = firstname + " " + middlename + " " + lastname;
            return FullName;
        }
    }
}
