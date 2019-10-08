using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public abstract class Kişi
    {
        string name;
        string address;
        string mobileNumber;
        string email;

        public Kişi()
        {

        }
        protected Kişi(string name, string address, string mobileNumber, string email)
        {
            this.name = name;
            this.address = address;
            this.mobileNumber = mobileNumber;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string Email { get => email; set => email = value; }

        public abstract int DeleteKullanici(int id);
        public abstract int UpdateKullanici(Kişi k);
        public abstract int AddKullanici(Kişi k);
        public abstract DataTable ListKullaici();

        public static DataTable Search(string tableName, string coloumName, string name)
        {
            try
            {
                string query = string.Format("SELECT * FROM {0} WHERE {1}='{2}'", tableName, coloumName, name);
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        





    }
}
