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
    public partial class ImportUC : UserControl
    {
        public ImportUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Kitap k = new Kitap();
            dataGridView1.DataSource = k.SatisListele();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtArama.Text.Trim();
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
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Kullanıcı.Search("Satis", "Urun_Adı", text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
