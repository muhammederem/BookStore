using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BLL
{
    public class Kullanıcı:Kişi
    {
        
    
        DateTime dateOfBirth;
        DateTime hiringDate;
        string password;
        string tCKN;
        float salary;
        int employeeID;
        int level;

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public DateTime HiringDate { get => hiringDate; set => hiringDate = value; }
        public string Password { get => password; set => password = value; }
        public string TCKN { get => tCKN; set => tCKN = value; }
        public float Salary { get => salary; set => salary = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int Level { get => level; set => level = value; }

        public Kullanıcı()
        {

        }

        public Kullanıcı(DateTime dateOfBirth, DateTime hiringDate, string password, string tCKN, float salary, int employeeID, int level, string name, string address, string mobileNumber, string email) :base( name,  address,  mobileNumber,  email)
        {
            this.dateOfBirth = dateOfBirth;
            this.hiringDate = hiringDate;
            this.password = password;
            this.tCKN = tCKN;
            this.salary = salary;
            this.employeeID = employeeID;
            this.level = level;
        }

        public int Login(string Email, string Password)
        {
            string query = string.Format("SELECT * FROM Kullanıcı WHERE " +
        "Kullanıcı_TCKN = '{0}' AND Kullanıcı_Password = '{1}'", Email, Password);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public override DataTable ListKullaici(){
            try 
	        {
                string query = "SELECT * FROM Kullanıcı";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
	        }
	        catch (Exception e)
	        {

		        throw new Exception(e.Message);
	        }

        }
        public int AddKullanici(Kullanıcı k)
        {
            try
            {

                string query = string.Format("INSERT INTO Kullanıcı(Kullanıcı_ID,Kullanıcı_First_Name,Kullanıcı_Surname,Kullanıcı_Date_of_Birth,Kullanıcı_Address,Kullanıcı_Mobile_Number,Kullanıcı_TCKN,Kullanıcı_Email,Kullanıcı_Password,Kullanıcı_Salary,Kullanıcı_Hiring_Date,Kullanıcı_Level)"+
                    "VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',{10})",k.EmployeeID,k.Name,k.dateOfBirth,k.Address,k.MobileNumber,k.TCKN,k.Email,k.Password,k.Salary,k.HiringDate,k.Level);
                    ;
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public override int UpdateKullanici(Kişi k)
        {
            throw new NotImplementedException();
        }
        public  int UpdateKullanici(Kullanıcı k)
        {
            try
            {
                string query = string.Format("UPDATE Kullanıcı set Kullanıcı_ID={0}, Kullanıcı_First_Name='{1}',Kullanıcı_Date_of_Birth='{2}',Kullanıcı_Address='{3}',Kullanıcı_Mobile_Number={4},Kullanıcı_TCKN='{5}',Kullanıcı_Email='{6}',Kullanıcı_Password='{7}',Kullanıcı_Salary={8},Kullanıcı_Hiring_Date='{9},Kullanıcı_Level={10})"+
                    "WHERE Kullanıcı_ID={0}", k.EmployeeID, k.Name, k.dateOfBirth, k.Address, k.MobileNumber, k.TCKN, k.Email, k.Password, k.Salary, k.HiringDate, k.Level);
                ;
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public override int DeleteKullanici(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Kullanıcı" + "WHERE Kullanıcı_ID={0}", id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
    

}
