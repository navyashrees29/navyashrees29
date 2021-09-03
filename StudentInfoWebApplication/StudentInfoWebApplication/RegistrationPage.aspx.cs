using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BusinessLayer;

namespace StudentInfoWebApplication
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnRegister(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();

            string name = txtName.Text, email = txtEmail.Text, phone = txtPhone.Text, userName = txtUserName.Text, password = txtPassword.Text;
            objStudentDTO.Name = name;
            objStudentDTO.Email = email;
            objStudentDTO.Phone = phone;
            objStudentDTO.UserName = userName;
            objStudentDTO.Password = password;
            try
            {
                int effectedRows = objStudentBL.RegisterUserBL(objStudentDTO);
                if (effectedRows > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Registered');", true);  
                }
                else
                {
                     ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Error');", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentBL = null;
                objStudentDTO = null;
            }
        }
    }
}