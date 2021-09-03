using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        SqlConnection con = new SqlConnection(@"Data Source=ES-LAPTOP-521\SQL2017;Initial Catalog=StudentInfo;Integrated Security=True");
        public int CreateUserDAL(StudentDTO objStudentDTO)
        {
            int effectedRows=default(int);
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("CreateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", (objStudentDTO.Id == "" ? 0 : Convert.ToInt32(objStudentDTO.Id)));
                cmd.Parameters.AddWithValue("@name", objStudentDTO.Name);
                cmd.Parameters.AddWithValue("@class", objStudentDTO.ClassName);
                cmd.Parameters.AddWithValue("@gender", objStudentDTO.Gender);
                cmd.Parameters.AddWithValue("@dob", objStudentDTO.DOB);
                cmd.Parameters.AddWithValue("@email", objStudentDTO.Email);
                cmd.Parameters.AddWithValue("@phone", objStudentDTO.Phone);
                cmd.Parameters.AddWithValue("@address", objStudentDTO.Address);
                cmd.Parameters.AddWithValue("@DateTime", objStudentDTO.DateTime);
                effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
                objStudentDTO = null;
                cmd = null;
            }
            return effectedRows;
        }
        public int DeleteUserDAL(StudentDTO objStudentDTO)
        {
            int effectedRows = default(int);
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("DeleteStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objStudentDTO.Id);
                effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
                objStudentDTO = null;
                cmd = null;
            }
            return effectedRows;
        }
        public SqlDataReader SelectUserDAL(StudentDTO objStudentDTO)
        {
            SqlDataReader dr = null;
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("ViewStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objStudentDTO.Id);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDTO = null;
                cmd = null;
            }
            return dr;
        }
        public int UpdateUserDAL(StudentDTO objStudentDTO)
        {
            int effectedRows = default(int);
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("UpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", objStudentDTO.Id);
                cmd.Parameters.AddWithValue("@name", objStudentDTO.Name);
                cmd.Parameters.AddWithValue("@class", objStudentDTO.ClassName);
                cmd.Parameters.AddWithValue("@gender", objStudentDTO.Gender);
                cmd.Parameters.AddWithValue("@dob", objStudentDTO.DOB);
                cmd.Parameters.AddWithValue("@email", objStudentDTO.Email);
                cmd.Parameters.AddWithValue("@phone", objStudentDTO.Phone);
                cmd.Parameters.AddWithValue("@address", objStudentDTO.Address);
                cmd.Parameters.AddWithValue("@DateTime", objStudentDTO.DateTime);
                effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
                objStudentDTO = null;
                cmd = null;
            }
            return effectedRows;
        }        
        public DataTable GetStudentInfo()
        {
            DataTable dt=null;
            SqlCommand cmd;
            SqlDataAdapter sd;
            try
            {
                cmd = new SqlCommand("ViewAllStudents", con);
                sd = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sd.Fill(dt);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cmd = null;
                sd = null;
            }
            return dt;
        }
        public int RegisterUserDAL(StudentDTO objStudentDTO)
        {
            int effectedRows = default(int);
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("RegisterUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", (objStudentDTO.Id == "" ? 0 : Convert.ToInt32(objStudentDTO.Id)));
                cmd.Parameters.AddWithValue("@name", objStudentDTO.Name);
                cmd.Parameters.AddWithValue("@email", objStudentDTO.Email);
                cmd.Parameters.AddWithValue("@phone", objStudentDTO.Phone);
                cmd.Parameters.AddWithValue("@username", objStudentDTO.UserName);
                cmd.Parameters.AddWithValue("@password", objStudentDTO.Password);
                effectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
                objStudentDTO = null;
                cmd = null;
            }
            return effectedRows;
        }
        public DataTable GetRegisteredUserInfo()
        {
            DataTable dt = null;
            SqlCommand cmd;
            SqlDataAdapter sd;
            try
            {
                cmd = new SqlCommand("ViewAllRegisteredUser", con);
                sd = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sd.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cmd = null;
                sd = null;
            }
            return dt;
        }
        public SqlDataReader CheckUserDAL(StudentDTO objStudentDTO)
        {
            SqlDataReader dr = null;
            SqlCommand cmd;
            try
            {
                con.Open();
                cmd = new SqlCommand("CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", objStudentDTO.UserName);
                cmd.Parameters.AddWithValue("@password", objStudentDTO.Password);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDTO = null;
                cmd = null;
            }
            return dr;
        }
    }
}
