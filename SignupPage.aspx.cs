using Online_Book_Shopping_System.Entity;
using System;

namespace Online_Book_Shopping_System
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            User userObj = new User();
            bool istrue = userObj.getUserRegistration(txtName.Text, txtUserName.Text, txtEmail.Text, ddUser.SelectedValue.ToString(), txtPassword.Text);
            if (istrue)
            {
                Response.Write("Sign Up SuccessFul");
            }
            else
            {
                Response.Write("Sign Up Failed");
            }
        }
    }
}