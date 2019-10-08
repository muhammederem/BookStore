using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class Dergi:Urun
    {
        int dergi_Sayi;

        public Dergi(int dergi_Sayi, string urun_Name, int urun_Page, string urun_Author, string urun_Price, int urun_Stock, DateTime urun_publishDate) :base( urun_Name, urun_Page, urun_Author, urun_Price, urun_Stock,urun_publishDate)
        {
            this.dergi_Sayi = dergi_Sayi;
        }

        public Dergi()
        {

        }

        public int Dergi_Sayi { get => dergi_Sayi; set => dergi_Sayi = value; }

        public  override int Add()
        {
            throw new NotImplementedException();
        }

        public  int Add(Dergi d)
        {
            try
            {

                string query = string.Format("INSERT INTO Dergi(Dergi_Ad,Dergi_Sayfa,Dergi_Adet,Dergi_Sayı,Dergi_Yayın_Tarihi,Dergi_Fiyat,Dergi_Yazar)" +
                    "VALUES('{0}',{1},{2},{3},'{4}','{5}','{6}')", d.Urun_Name,d.Urun_Page,d.Urun_Stock,d.Dergi_Sayi,d.Urun_PublishDate,d.Urun_Price,d.Urun_Author);
                
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override int Delete(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM Dergi" + "WHERE Kitap_ISBN={0}", id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override DataTable List()
        {
            try
            {
                string query = "SELECT * FROM Dergi";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public override int Sell()
        {
            throw new NotImplementedException();
        }
        public int Sell(string ad)
        {
            try
            {
                DateTime simdi = DateTime.Now;
                Dictionary<string, string> dictionay = satilanBilgi(ad);
                string query = string.Format("BEGIN TRANSACTION;" +
                    "UPDATE Dergi set Dergi_Adet=Dergi_Adet -1 WHERE Dergi_Ad='{0}';" +
                    "insert into Satis values('{1}',{2},'{3}');" +
                    "COMMIT;", ad, dictionay["Adi"], dictionay["Fiyat"], simdi.ToString());

                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Dictionary<String, string> satilanBilgi(string ad)
        {
            try
            {
                Dictionary<string, string> dictionay = new Dictionary<string, string>();
                string query = string.Format("select * from Dergi  WHERE Dergi_Ad='{0}' ", ad);
                DataAcess da = new DataAcess();
                DataTable data = da.ExecuteQuery(query);
                dictionay.Add("Adi", data.Rows[0]["Dergi_Ad"].ToString());
                dictionay.Add("Fiyat", data.Rows[0]["Dergi_Fiyat"].ToString());
                return dictionay;

            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
        }




        public  override int Update()
        {
            throw new NotImplementedException();
        }
        public  int Update(Dergi d)
        {
            try
            {
                string query = string.Format("UPDATE Dergi set Dergi_Ad='{0}',Dergi_Sayfa={1},Dergi_Adet={2},Dergi_Sayı={3},Dergi_Yayın_Tarihi='{4}',Dergi_Fiyat={5},Dergi_Yazar='{6}'" 
                    + "WHERE Dergi_Ad='{0}'",d.Urun_Name,d.Urun_Page,d.Urun_Stock,d.Dergi_Sayi,d.Urun_PublishDate,d.Urun_Price,d.Urun_Author);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
