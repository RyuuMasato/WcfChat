using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatClient.ChatService;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatServiceClient chatProxy = new ChatServiceClient();
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Type a note (or hit enter to quit):");
                string note = Console.ReadLine();
                if (string.IsNullOrEmpty(note))
                {
                    break;
                }
                chatProxy.PostNote(name, note);
            }
        }
    }
}
