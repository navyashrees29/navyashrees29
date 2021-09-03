using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using DTO;
using System.Data.SqlClient;

namespace StudentInfoWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnLogin(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();
            string username = txtUserName.Text, password = txtPassword.Text;
            objStudentDTO.UserName = username;
            objStudentDTO.Password = password;
            try
            {
                SqlDataReader dr = objStudentBL.CheckUserBL(objStudentDTO);
                if (dr.HasRows)
                {
                    Session["name"] = txtUserName.Text;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter correct user name and password');", true);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDTO = null;
                objStudentBL = null;
            }
        }
    }
}