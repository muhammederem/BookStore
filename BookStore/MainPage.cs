using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BookStore
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            dataBookList.DataSource = Kitap.Search("Kitap", "Kitap_Adi",txtSearch.Text);
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap k = new Kitap(txt_Type.Text, txt_Detay.Text, txt_ISBN.Text, txt_Name.Text, int.Parse(txt_Page.Text), txt_Author.Text, txt_Price.Text, int.Parse(txt_Stock.Text), DateTime.Parse(txt_publishDate.Text));
           int result= k.Add(k);
                    if (result > 0)
                    {
                         MessageBox.Show("Added");
                       
                    }
                    else
                         MessageBox.Show("Not Added" + result);


            }
            catch (Exception)
            {

                throw;
            }
          
            
          
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap d = new Kitap();
                d.BookDetail = txt_Detay.Text.Trim();
                d.BookISBN = txt_ISBN.Text.Trim();
                d.BookType = txt_Type.Text.Trim();
                d.Urun_Author = txt_Author.Text.Trim();
                d.Urun_Name = txt_Name.Text.Trim();
                d.Urun_Page = int.Parse(txt_Page.Text.Trim());
                d.Urun_Price = txt_Price.Text.Trim();
                d.Urun_PublishDate = DateTime.Parse(txt_publishDate.Text.Trim());
                d.Urun_Stock = int.Parse(txt_Stock.Text.Trim());
                int result = d.Update(d);
                if (result > 0)
                {
                    d.List();
                    MessageBox.Show("Güncellendi");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            dataBookList.DataSource = k.List();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearch.Text.Trim();
                if (text == "Arama")
                {
                    dataBookList.DataSource = null;
                    return;
                }
                else if (text=="")
                {
                    dataBookList.DataSource = null;
                    return;
                }
                Kitap k = new Kitap();
                dataBookList.DataSource = Kitap.Search("Kitap", "Kitap_Adi", text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_sat_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            int isbn = int.Parse(txtKitapSat.Text.Trim());
            k.Sell(isbn);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            int id = int.Parse(textDelete.Text.Trim());
            k.Delete(id);
        }
    }
}
