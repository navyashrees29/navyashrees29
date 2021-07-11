using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    string uname = TextBoxUserName.Text,pwd = TextBoxPassword.Text;
            if(TextBoxUserName.Text == "admin" && TextBoxPassword.Text == "123")
            {
                Session["name"] = TextBoxUserName.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this,this.GetType(),"script","alert('Please enter correct user name and password');",true);
            }
        }

        
    }
}