using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServerLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatService" in both code and config file together.
    public class ChatService : IChatService
    {
        private Person user { get; set; }

        public void PostNote(string from, string note)
        {
            Console.WriteLine("{0}: {1}", from, note);
        }
        public void CreateUser(string nm)
        {
            user = new Person(nm);
        }
        public void LoginUser(string nm, string pass)
        {
            Person loginAttempt = new Person("Jorrit");
            if(loginAttempt.ValidateLogin(nm, pass))
                Console.WriteLine("Login succeeded with: {0}, {1}", nm, pass);
            else
                Console.WriteLine("Loggin failed");
        }
    }
}
