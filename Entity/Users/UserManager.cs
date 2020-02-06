using Online_Book_Shopping_System.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Online_Book_Shopping_System.Entity
{
    public class UserManager
    {
        public string userLogIn(string userName,string password)
        {
            UserRepositary reposObj = new UserRepositary();
            string Role;
            try
            {
                reposObj.addUserIntoList();

                foreach (KeyValuePair<int, User> user in reposObj.userList)
                {

                    if (user.Value.Password == password && user.Value.UserName == userName)
                    {
                        Role = user.Value.Role;
                        return Role;
                    }

                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}