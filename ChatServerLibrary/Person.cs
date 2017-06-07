using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServerLibrary
{
    class Person
    {
        public string name { get; private set; }
        private string password { get; set; }
        public Person(string nm)
        {
            name = nm;
            password = nm.Reverse().ToString();
        }
        public bool ValidateLogin(string nm, string pass)
        {
            if (nm.Equals(name) && pass.Equals(pass))
                return true;
            else
                return false;
        }
    }
}
