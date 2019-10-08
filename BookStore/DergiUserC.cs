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
    public partial class DergiUserC : UserControl
    {
        public DergiUserC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dergi d = new Dergi();
            dataGridView1.DataSource = d.List();
        }

        private void btn_DergiSil_Click(object sender, EventArgs e)
        {
            Dergi d = new Dergi();
            int id = int.Parse(txt_DergiSil.Text.Trim());
            d.Delete(id);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Dergi d = new Dergi();
                d.Urun_Name = txt_Ad.Text.Trim();
                d.Urun_Page = int.Parse(txt_Sayfa.Text.Trim());
                d.Urun_Stock = int.Parse(txt_Adet.Text.Trim());
                d.Dergi_Sayi = int.Parse(txt_Sayi.Text.Trim());
                d.Urun_PublishDate = DateTime.Parse(txt_PublishDate.Text.Trim());
                d.Urun_Price = txt_Fiyat.Text.Trim();
                d.Urun_Author = txt_Yazar.Text.Trim();

                d.Add(d);
                if (txt_Ad.Text == "")
                {
                    MessageBox.Show("Dergi Adı Girin");
                }
                if (txt_Sayfa.Text == "")
                {
                    MessageBox.Show("Sayfa Sayısı Girin");
                    
                }
                if (txt_Adet.Text == "")
                {
                    MessageBox.Show("Adet Girin");
                }
                if (txt_Sayi.Text == "")
                {
                    MessageBox.Show("Dergi Sayısı Girin");
                }
                if (txt_PublishDate.Text == "")
                {
                    MessageBox.Show("Dergi Yayın Tarihi Girin");
                }
                if(txt_Fiyat.Text == "")
                {
                    MessageBox.Show("Dergi Fiyatı Girin");
                }
                if (txt_Yazar.Text == "")
                {
                    MessageBox.Show("Yazar Girin");
                }



            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dergi d = new Dergi();
            d.Urun_Name = txt_Ad.Text.Trim();
            d.Urun_Page = int.Parse(txt_Sayfa.Text.Trim());
            d.Urun_Stock = int.Parse(txt_Adet.Text.Trim());
            d.Dergi_Sayi = int.Parse(txt_Sayi.Text.Trim());
            d.Urun_PublishDate = DateTime.Parse(txt_PublishDate.Text.Trim());
            d.Urun_Price = txt_Fiyat.Text.Trim();
            d.Urun_Author = txt_Yazar.Text.Trim();
            d.Update(d);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Dergi.Search("Dergi", "Dergi_Ad", txt_Arama.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Dergi d = new Dergi();
            string ad = txt_Sat.Text.Trim();
                d.Sell(ad);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           ;
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txt_Arama.Text.Trim();
                if (text == "Arama")
                {
                    dataGridView1.DataSource = null;
                    return;
                }
                else if (text == "")
                {
                    dataGridView1.DataSource = null;
                    return;
                }
                Dergi d = new Dergi();
                dataGridView1.DataSource = Kitap.Search("Dergi", "Dergi_Ad", text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
