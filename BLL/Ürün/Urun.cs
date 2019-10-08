using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public abstract class Urun
    {
        string urun_Name;
        int urun_Page;
        string urun_Author;
        
        string urun_Price;
        int urun_Stock;
        DateTime urun_publishDate;

        public Urun()
        {

        }

        public Urun(string urun_Name, int urun_Page, string urun_Author, string urun_Price, int urun_Stock,DateTime urun_publishDate)
        {
            this.urun_Name = urun_Name;
            this.urun_Page = urun_Page;
            this.urun_Author = urun_Author;
           
            this.urun_Price = urun_Price;
            this.urun_Stock = urun_Stock;
            this.urun_publishDate = urun_publishDate;

        }

        public string Urun_Name { get => urun_Name; set => urun_Name = value; }
        public int Urun_Page { get => urun_Page; set => urun_Page = value; }
        public string Urun_Author { get => urun_Author; set => urun_Author = value; }
        
        public string Urun_Price { get => urun_Price; set => urun_Price = value; }
        public int Urun_Stock { get => urun_Stock; set => urun_Stock = value; }
        public DateTime Urun_PublishDate { get => urun_publishDate; set => urun_publishDate = value; }

        public abstract int Sell();

        public abstract int Update();
        public abstract int Delete(int id);
        public abstract DataTable List();

        public abstract int Add();

        public static DataTable Search(string table_Name, string coloumn_Name, string name)
        {
            try
            {
                string query = string.Format("SELECT * FROM {0} WHERE {1} like '{2}%'", table_Name, coloumn_Name, name);
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

