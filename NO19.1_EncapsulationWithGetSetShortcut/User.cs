using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO19._1_EncapsulationWithGetSetShortcut
{
    internal class User
    {

        // Automatic Properties
        public int userID
        {
            get;
            set;
        }
        public string userName
        {
            get;
            set;
        }
        public string firstName
        {
            get;
            set;
        }
        public string lastName
        {
            get;
            set;
        }

        public User(int userID, string userName, string firstName, string lastName)
        {
            this.userID = userID;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}
