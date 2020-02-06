using Online_Book_Shopping_System.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Book_Shopping_System.Entity
{
    public class User
    {
        protected internal string Name;
        protected internal string UserName;
        protected internal string MailId;
        protected internal string Password;
        protected internal string Role;
        protected internal int UserID;

        public Dictionary<int, User> userList = new Dictionary<int, User>();

        public bool getUserRegistration(string name,string userName,string mailID,string role,string password)
        {

            User user = new User
            {
                Name = name,
                UserName = userName,
                MailId = mailID,
                Role = role,
                Password =password
            };

            UserRepositary reposObj = new UserRepositary();
            if (reposObj.addUser(user)>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}