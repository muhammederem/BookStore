using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Kitap : Urun
    {
        public string bookType;
        public string bookDetail;
        public string bookISBN;
        public Kitap()
        {

        }
        public Kitap(string bookType, string bookDetail, string bookISBN, string urun_Name, int urun_Page, string urun_Author, string urun_Price, int urun_Stock, DateTime urun_publishDate)
            : base(urun_Name, urun_Page, urun_Author, urun_Price, urun_Stock, urun_publishDate)


        {
            this.bookType = bookType;
            this.bookDetail = bookDetail;
            this.bookISBN = bookISBN;

        }

        public string BookType { get => bookType; set => bookType = value; }
        public string BookDetail { get => bookDetail; set => bookDetail = value; }
        public string BookISBN { get => bookISBN; set => bookISBN = value; }
        public override int Add()
        {
            return 0;
        }
        public int Add(Kitap k)
        {
            try
            {
                string query = string.Format("INSERT INTO Kitap(Kitap_Adi,Kitap_Türü,Kitap_Yazar,Kitap_Sayfa,Kitap_Detay,Kitap_ISBN,Kitap_Yayin_Tarihi,Kitap_Fiyat,Kitap_Adet)" +
                    "VALUES('{0}','{1}','{2}',{3},'{4}',{5},'{6}',{7},{8})", k.Urun_Name, k.BookType, k.Urun_Author, k.Urun_Page, k.BookDetail, k.BookISBN, k.Urun_PublishDate, k.Urun_Price, k.Urun_Stock);
                ;
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
                string query = string.Format("DELETE FROM Kitap WHERE Kitap_ISBN={0}", id);
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
                string query = "SELECT * FROM Kitap";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        public int SatısEkle(string isim, int fiyat, string tarih)
        {
            try
            {
                string query = string.Format("INSERT INTO Satış(Urun Adı,Fiyat,Tarih)" + "VALUES('{0}',{1},'{2}')", isim, fiyat, tarih);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Sell(int isbn)
        {
            try
            {
                DateTime simdi = DateTime.Now;
                Dictionary<string, string> dictionay = satilanBilgi(isbn);
                string query = string.Format("BEGIN TRANSACTION;" +
                    "UPDATE Kitap set Kitap_Adet=Kitap_Adet -1 WHERE Kitap_ISBN={0};" +
                    "insert into Satis values('{1}',{2},'{3}');" +
                    "COMMIT;", isbn, dictionay["Adi"], dictionay["Fiyat"], simdi);

                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Dictionary<String, string> satilanBilgi(int isbn)
        {
            try
            {
                Dictionary<string, string> dictionay = new Dictionary<string, string>();
                string query = string.Format("select * from Kitap  WHERE Kitap_ISBN={0} ", isbn);
                DataAcess da = new DataAcess();
                DataTable data = da.ExecuteQuery(query);
                dictionay.Add("Adi", data.Rows[0]["Kitap_Adi"].ToString());
                dictionay.Add("Fiyat", data.Rows[0]["Kitap_Fiyat"].ToString());
                return dictionay;

            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
        }

        public override int Sell()
        {
            throw new NotImplementedException();
        }

        public override int Update()
        {
            throw new NotImplementedException();
        }
        public int Update(Kitap k)
        {
            try
            {
                string query = string.Format("UPDATE Kitap set Kitap_Adi='{0}',Kitap_Türü='{1}',Kitap_Yazar='{2}',Kitap_Sayfa={3},Kitap_Detay='{4}',Kitap_ISBN={5},Kitap_Yayin_Tarihi='{6}',Kitap_Fiyat={7},Kitap_Adet={8}" +
                    " WHERE Kitap_I" +
                    "SBN={5}", k.Urun_Name, k.BookType, k.Urun_Author, k.Urun_Page, k.BookDetail, k.BookISBN, k.Urun_PublishDate, k.Urun_Price, k.Urun_Stock);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable SatisListele()
        {
            try
            {
                string query = "SELECT * FROM Satis";
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

