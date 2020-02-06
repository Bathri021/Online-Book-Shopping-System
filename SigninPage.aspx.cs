using Online_Book_Shopping_System.Entity;
using System;


namespace Online_Book_Shopping_System
{
    public partial class SigninPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            UserManager userObj = new UserManager();

            string Role;
            Role = userObj.userLogIn(txtUserNameLogin.Text, txtPasswordLogin.Text);
            if (Role != null)
            {
                Response.Write("Login SucccessFul As " + Role);
            }
            else
            {
                Response.Write("Login Failed");
            }
        }
    }
}