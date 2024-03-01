using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Entities
{
    internal class Users
    {
        public string Username { get; set; }
        public DateTime AccessDate { get; set; }


        public Users() { } 
        public Users(string username, DateTime accessDate)
        {
            Username = username;
            AccessDate = accessDate;
        }

        /*
        public override bool Equals(object? obj)
        {
            if(!(obj is Users))
            {
                return false;
            }
            Users users = obj as Users;
            return Username.Equals(users.Username);
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
        */
    }
}
