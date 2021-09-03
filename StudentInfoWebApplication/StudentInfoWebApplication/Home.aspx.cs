using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using BusinessLayer;
using DTO;

namespace StudentInfoWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStudentInfo();
                GetRegisteredUser();
            }
            gvStudent.Columns[9].Visible = false;
            btnInsert.Visible = true;
        }
 
        protected void BtnCreateUser(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();
            string  name = txtName.Text, classname = txtClass.Text, gender = rdbnGender.SelectedValue, dob = txtDOB.Text, email = txtEmail.Text, phone = txtPhone.Text, address = txtAddress.Text;
            objStudentDTO.Name = name;
            objStudentDTO.ClassName = classname;
            objStudentDTO.Gender = gender;
            objStudentDTO.DOB = dob;
            objStudentDTO.Email = email;
            objStudentDTO.Phone = phone;
            objStudentDTO.Address = address;
            objStudentDTO.DateTime = DateTime.Now;
            try
            {
                int effectedRows = objStudentBL.CreateUserBL(objStudentDTO);
                if (effectedRows > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted');", true);
                    GetStudentInfo();
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

        public void GetStudentInfo()
        {
            StudentBL objStudentBL = new StudentBL();
            try
            {
                DataTable dt = objStudentBL.GetStudentInfoFromDAL();
                gvStudent.DataSource = dt;
                gvStudent.DataBind();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentBL = null;
            }
        }

        public void GetRegisteredUser()
        {
            StudentBL objStudentBL = new StudentBL();
            try
            { 
            DataTable dt = objStudentBL.GetRegisteredUserBL();
            gvRegisteredUser.DataSource = dt;
            gvRegisteredUser.DataBind();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentBL = null;
            }
        }

        protected void BtnUpdateUser(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();
            string  name = txtName.Text, classname = txtClass.Text, gender = rdbnGender.SelectedValue, dob = txtDOB.Text, email = txtEmail.Text, phone = txtPhone.Text, address = txtAddress.Text;
            //objStudentDTO.Id = id;
            int Id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            objStudentDTO.Id = Id.ToString();
            objStudentDTO.Name = name;
            objStudentDTO.ClassName = classname;
            objStudentDTO.Gender = gender;
            objStudentDTO.DOB = dob;
            objStudentDTO.Email = email;
            objStudentDTO.Phone = phone;
            objStudentDTO.Address = address;
            objStudentDTO.DateTime = DateTime.Now;
            try
            {
                int effectedRows = objStudentBL.UpdateUserBL(objStudentDTO);
                if (effectedRows > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully updated');", true);
                    GetStudentInfo();
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

        protected void BtnSelectUser(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();
            //objStudentDTO.Id = id;
            int Id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            objStudentDTO.Id = Id.ToString();
            try
            {
                SqlDataReader dr = objStudentBL.SelectUserBL(objStudentDTO);
                while (dr.Read())
                {
                    txtName.Text = dr.GetValue(0).ToString();
                    txtClass.Text = dr.GetValue(1).ToString();
                    rdbnGender.SelectedValue = dr.GetValue(2).ToString();
                    txtDOB.Text = dr.GetValue(3).ToString();
                    txtEmail.Text = dr.GetValue(4).ToString();
                    txtPhone.Text = dr.GetValue(5).ToString();
                    txtAddress.Text = dr.GetValue(6).ToString();
                }
                gvStudent.Columns[9].Visible = true;
                btnInsert.Visible = false;
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

        protected void BtnDeleteUser(object sender, EventArgs e)
        {
            StudentBL objStudentBL = new StudentBL();
            StudentDTO objStudentDTO = new StudentDTO();
            // objStudentDTO.Id = id;
            int Id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            objStudentDTO.Id = Id.ToString();
            try
            {
                int effectedRows = objStudentBL.DeleteUserBL(objStudentDTO);
                if (effectedRows > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
                    GetStudentInfo();
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

        protected void BtnClearUser(object sender, EventArgs e)
        {
            txtName.Text =  txtClass.Text =   txtDOB.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = "";
            rdbnGender.SelectedValue = null;
        }

        protected void BtnLogout(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }

        protected void gvRegisteredUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}