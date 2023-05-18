using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO19_Encapsulation
{
    internal class User
    {

        /* Private attributes or fields. */
        private int userID;
        private string userName;
        private string firstName, lastName;

        // Properties of encapsulated attributes.
        public int UserID
        {
            get { return userID; }
            set { 
                userID = value;
                if (value >= 1) userID = value;
                else Console.WriteLine("Invalid: User ID must not be below 1.");
            }
        }

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }

        // we can also use constructor, object methods here ...
        public User(int userID, string userName, string firstName, string lastName)
        {
            UserID = userID;
            Username = userName;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}