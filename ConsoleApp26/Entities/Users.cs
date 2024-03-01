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
      
        public override bool Equals(object? obj)    //This method is used for comparison
        {
            if(!(obj is Users))     //Defensive programming. If the object isn't type "Users", it will return false
            {
                return false;
            }
            Users users = obj as Users;     //First we have to downcast the object that came as a parameter to the same level as the class we're working with
            return Username.Equals(users.Username);     //Now we just we have to compare both objects using Equals and the selected atribute
        }

        public override int GetHashCode()       //This method is used to get the the hash code from a certain atribute, in this case
        {                                       //the Username. The method will return the has code as an int.
            return Username.GetHashCode();
        }
       
    }
}
