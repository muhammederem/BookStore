using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class Müşteri : Kişi
    {
        public override int AddKullanici(Kişi k)
        {
            throw new NotImplementedException();
        }
        public int AddKullanici(Müşteri m)
        {
            try
            {

                string query = string.Format("INSERT INTO Müşteri(Name,Adres,Mobile_Number,Email)" +
                    "VALUES('{0}','{1}','{2}','{3}',})", m.Name,m.Address,m.MobileNumber,m.Email);
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
                string query = string.Format("DELETE FROM Müşteri" + "WHERE Mobile_Number='{0}'", id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override DataTable ListKullaici()
        {
            try
            {
                string query = "SELECT * FROM Müşteri";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public  int UpdateKullanici(Müşteri m)
        {
            try
            {
                string query = string.Format("UPDATE Müşteri Name='{0}',Adres='{1}',Mobile_Number='{2}',Email='{3}')" +
                    "WHERE Mobile_Number='{0}'", m.Name,m.Address,m.MobileNumber,m.Email);
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


    }
}
