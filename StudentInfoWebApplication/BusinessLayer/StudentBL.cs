using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class StudentBL
    {
        public int CreateUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            int value = default(int);
            try
            {
                value = objStudentDAL.CreateUserDAL(objStudentDTO);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }
        public int DeleteUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            int value = default(int);
            try
            {
                value = objStudentDAL.DeleteUserDAL(objStudentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }
        public SqlDataReader SelectUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            SqlDataReader value = null;
            try
            {
                value = objStudentDAL.SelectUserDAL(objStudentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }
        public int UpdateUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            int value = default(int);
            try
            {
                value = objStudentDAL.UpdateUserDAL(objStudentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }     
        public DataTable GetStudentInfoFromDAL()
        {
            StudentDAL studentDAL = new StudentDAL();
            DataTable value=null;
            try
            {
                value = studentDAL.GetStudentInfo();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                studentDAL = null;
            }
            return value;
        }
        public int RegisterUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            int value = default(int);
            try
            {
                value = objStudentDAL.RegisterUserDAL(objStudentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }
        public DataTable GetRegisteredUserBL()
        {
            StudentDAL studentDAL = new StudentDAL();
            DataTable value = null;
            try
            {
                value = studentDAL.GetRegisteredUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                studentDAL = null;
            }
            return value;
        }
        public SqlDataReader CheckUserBL(StudentDTO objStudentDTO)
        {
            StudentDAL objStudentDAL = new StudentDAL();
            SqlDataReader value = null;
            try
            {
                value = objStudentDAL.CheckUserDAL(objStudentDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                objStudentDAL = null;
            }
            return value;
        }
    }
}
