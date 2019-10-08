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
using System.IO;

namespace BookStore
{
    public partial class KullanıcıUserC : UserControl
    {
        public KullanıcıUserC()
        {
            InitializeComponent();
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanıcı k = new Kullanıcı();
                k.Name = text_name.Text.Trim();
                k.Email = text_mail.Text.Trim();
                k.Password = text_pass.Text.Trim();
                k.Address = txt_adress.Text.Trim();
                k.EmployeeID = int.Parse(txt_id.Text.Trim());
                k.DateOfBirth = DateTime.Parse(txt_dateofbirth.Text.Trim());
                k.MobileNumber = txt_mobile.Text.Trim();
                k.TCKN = txt_tckn.Text.Trim();
                k.Salary = int.Parse(txt_salary.Text.Trim());
                k.HiringDate = DateTime.Parse(txt_hiring.Text.Trim());
                k.Level = int.Parse(txt_level.Text.Trim());

                if (text_name.Text=="")
                {
                    return;
                }
                if (txt_level.Text == "")
                {
                    return;
                }
                if (txt_mobile.Text == "")
                {

                    return;
                }
                if (txt_salary.Text == "")
                {
                    return;
                }
                if (txt_tckn.Text == "")
                {
                    return;
                }
                if (txt_id.Text == "")
                {
                    return;
                }
                if (txt_adress.Text == "")
                {
                    return;
                }
                if (txt_dateofbirth.Text == "")
                {
                    return;
                }
                if (txt_hiring.Text == "")
                {
                    return;
                }
                if (text_mail.Text == "")
                {
                    return;
                }
                if (text_pass.Text== "")
                {
                    return;
                }



                Guid guid = Guid.NewGuid();
                try
                {
                    string dest = @"../../../img/" + guid.ToString() + ".jpg";


                    File.Copy(txtPath.Text, dest);
                    k.Picture = dest;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    k.Picture = "";
                }
                int result = k.AddKullanici(k);
                if (result > 0)
                {
                    BindDataGridView();

                }
                text_name.Text = "";
                txt_level.Text = "";
                txt_mobile.Text = "";
                txt_salary.Text = "";
                txt_tckn.Text = "";
                txt_id.Text = "";
                txt_adress.Text = "";
                txt_dateofbirth.Text = "";
                txt_hiring.Text = "";
                text_mail.Text = "" ;
                text_pass.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        private void BindDataGridView()
        {
            try
            {
                Kullanıcı s = new Kullanıcı();
                dataGridView1.DataSource = s.ListKullaici();

                // hide the path column
                dataGridView1.Columns["Picture"].Visible = false;

                // create and add a new column in the datagridview
                if (!dataGridView1.Columns.Contains("Image"))
                {
                    DataGridViewImageColumn col = new DataGridViewImageColumn();
                    col.Width = 100;
                    col.HeaderText = "image";
                    col.Name = "Image";
                    col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGridView1.Columns.Add(col);
                }

                Bitmap img = null;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    string path = row.Cells["picture"].Value.ToString();
                    if (path != "")
                    {
                        img = new Bitmap(path);
                        dataGridView1.Rows[i].Cells["Image"].Value = img;
                        dataGridView1.Rows[i].Height = 100;
                    }
                    else
                    {
                        img = new Bitmap(@"..\..\images\default.jpg"); ;
                        dataGridView1.Rows[i].Cells["Image"].Value = img;
                        dataGridView1.Rows[i].Height = 100;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                BindDataGridView();
            }
            catch (Exception)
            {

                MessageBox.Show("Test");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanıcı k = new Kullanıcı();
                k.Name = text_name.Text.Trim();
                k.Email = text_mail.Text.Trim();
                k.Password = text_pass.Text.Trim();
                k.Address = txt_adress.Text.Trim();
                k.EmployeeID = int.Parse(txt_id.Text.Trim());
                k.DateOfBirth = DateTime.Parse(txt_dateofbirth.Text.Trim());
                k.MobileNumber = txt_mobile.Text.Trim();
                k.TCKN = txt_tckn.Text.Trim();
                k.Salary = int.Parse(txt_salary.Text.Trim());
                k.HiringDate = DateTime.Parse(txt_hiring.Text.Trim());
                k.Level = int.Parse(txt_level.Text.Trim());

                if (text_name.Text == "")
                {
                    return;
                }
                if (txt_level.Text == "")
                {
                    return;
                }
                if (txt_mobile.Text == "")
                {

                    return;
                }
                if (txt_salary.Text == "")
                {
                    return;
                }
                if (txt_tckn.Text == "")
                {
                    return;
                }
                if (txt_id.Text == "")
                {
                    return;
                }
                if (txt_adress.Text == "")
                {
                    return;
                }
                if (txt_dateofbirth.Text == "")
                {
                    return;
                }
                if (txt_hiring.Text == "")
                {
                    return;
                }
                if (text_mail.Text == "")
                {
                    return;
                }
                if (text_pass.Text == "")
                {
                    return;
                }



                Guid guid = Guid.NewGuid();
                try
                {
                    string dest = @"../../img/" + guid.ToString() + ".jpg";


                    File.Copy(txtPath.Text, dest);
                    k.Picture = dest;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    k.Picture = "";
                }
                int result = k.UpdateKullanici(k);
                if (result > 0)
                {
                    MessageBox.Show("Güncellendi");

                }
                text_name.Text = "";
                txt_level.Text = "";
                txt_mobile.Text = "";
                txt_salary.Text = "";
                txt_tckn.Text = "";
                txt_id.Text = "";
                txt_adress.Text = "";
                txt_dateofbirth.Text = "";
                txt_hiring.Text = "";
                text_mail.Text = "";
                text_pass.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int row = int.Parse(dataGridView1.SelectedRows[0].Cells["Kullanıcı_ID"].Value.ToString());
                    Kullanıcı s = new Kullanıcı();
                    int result = s.DeleteKullanici(row);
                    if (result > 0)
                    {
                        MessageBox.Show(row + " Student Deleted.");
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void btn_Sec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG Files(*.jpg)|*.jpeg;*.jpg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dialog.FileName;
                    txtPath.Text = dialog.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtSearch.Text.Trim();
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
                
                dataGridView1.DataSource = Kullanıcı.Search("Kullanıcı", "Kullanıcı_First_Name", text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

