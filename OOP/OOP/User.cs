using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    public class User
    {
        private static int _id;
        public readonly int Id;
        public string UserName { get; set; }
        public string Password { get; set; }

        private User()
        {
            _id++;
            Id = _id;
        }
        public User(string username , string password):this()
        {
            UserName = username;
            Password = password;
        }
        public void ShowInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($@"Id : {Id}
UserName : {UserName}
Password : {Password}");
            Console.WriteLine("-----------------------------");
        }

    }
}
