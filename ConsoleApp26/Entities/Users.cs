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

        public Users(string username, DateTime accessDate)
        {
            Username = username;
            AccessDate = accessDate;
        }
    }
}
