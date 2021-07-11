using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoWebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStudentInfo();
           
            }
        }
        SqlConnection con = new SqlConnection("Data Source=ES-LAPTOP-521\\SQL2017;Initial Catalog=StudentInfo;Integrated Security=True");
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text, name = TextBoxName.Text, classname = TextBoxClass.Text, gender = RadioButtonList1.SelectedValue, dob = TextBoxDOB.Text, email = TextBoxEmail.Text, phone = TextBoxPhone.Text, address = TextBoxAddress.Text;
            con.Open();
            SqlCommand com = new SqlCommand("insert into StudentDetails values ('" + id + "','" + name + "','" + classname + "','" + gender + "','" + dob + "','" + email + "','" + phone + "','" + address + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted');", true);
            GetStudentInfo();
        }

        public void GetStudentInfo()
        {
            SqlCommand com = new SqlCommand("select * from StudentDetails",con);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text, name = TextBoxName.Text, classname = TextBoxClass.Text, gender = RadioButtonList1.SelectedValue, dob = TextBoxDOB.Text, email = TextBoxEmail.Text, phone = TextBoxPhone.Text, address = TextBoxAddress.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("update StudentDetails set name='" + name + "',class='" + classname + "',gender='"+gender+"',dob='"+dob+"',email='"+email+"',phone='"+phone+"',address='"+address+"' where id='"+id+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this,this.GetType(),"script","alert('Successfully updated');",true);
            GetStudentInfo();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text;
            con.Open();
            SqlCommand com = new SqlCommand("select * from StudentDetails where id='"+id+"'",con);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                TextBoxName.Text = dr.GetValue(1).ToString();
                TextBoxClass.Text = dr.GetValue(2).ToString();
                RadioButtonList1.SelectedValue = dr.GetValue(3).ToString();
                TextBoxDOB.Text = dr.GetValue(4).ToString();
                TextBoxEmail.Text = dr.GetValue(5).ToString();
                TextBoxPhone.Text = dr.GetValue(6).ToString();
                TextBoxAddress.Text = dr.GetValue(7).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text;
            con.Open();
            SqlCommand com = new SqlCommand("delete StudentDetails where id='" + id + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted');", true);
            GetStudentInfo();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = null;
            TextBoxName.Text = null;
            TextBoxClass.Text = null;
            RadioButtonList1.SelectedValue = null;
            TextBoxDOB.Text = null;
            TextBoxEmail.Text = null;
            TextBoxPhone.Text = null;
            TextBoxAddress.Text = null;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }

        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    string id = TextBoxID.Text;
        //    SqlCommand com = new SqlCommand("select * from StudentDetails where id='" + id + "'", con);
        //    SqlDataAdapter sd = new SqlDataAdapter(com);
        //    DataTable dt = new DataTable();
        //    sd.Fill(dt);
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();
        //}
    }
}