namespace BookStore
{
    partial class MainPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txt_Detay = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_publishDate = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Page = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label_Stock = new System.Windows.Forms.Label();
            this.label_ISBN = new System.Windows.Forms.Label();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Detail = new System.Windows.Forms.Label();
            this.label_publishDate = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Page = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textDelete = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataBookList = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_sat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtKitapSat = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookList)).BeginInit();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_List);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(327, 48);
            this.panel11.TabIndex = 3;
            // 
            // btn_List
            // 
            this.btn_List.FlatAppearance.BorderSize = 0;
            this.btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_List.ForeColor = System.Drawing.Color.White;
            this.btn_List.Location = new System.Drawing.Point(-3, 3);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(327, 39);
            this.btn_List.TabIndex = 0;
            this.btn_List.Text = "Kitap Listele";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(659, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(95, 28);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(573, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 1);
            this.panel2.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearch.Location = new System.Drawing.Point(573, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 13);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Arama";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Controls.Add(this.txt_Detay);
            this.panel3.Controls.Add(this.btnGüncelle);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_Stock);
            this.panel3.Controls.Add(this.txt_ISBN);
            this.panel3.Controls.Add(this.txt_Type);
            this.panel3.Controls.Add(this.txt_publishDate);
            this.panel3.Controls.Add(this.txt_Price);
            this.panel3.Controls.Add(this.txt_Page);
            this.panel3.Controls.Add(this.txt_Author);
            this.panel3.Controls.Add(this.txt_Name);
            this.panel3.Controls.Add(this.label_Stock);
            this.panel3.Controls.Add(this.label_ISBN);
            this.panel3.Controls.Add(this.label_Type);
            this.panel3.Controls.Add(this.label_Detail);
            this.panel3.Controls.Add(this.label_publishDate);
            this.panel3.Controls.Add(this.label_Price);
            this.panel3.Controls.Add(this.label_Page);
            this.panel3.Controls.Add(this.label_Author);
            this.panel3.Controls.Add(this.label_Name);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.lbl_Add);
            this.panel3.Location = new System.Drawing.Point(541, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 448);
            this.panel3.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.Location = new System.Drawing.Point(24, 352);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(143, 1);
            this.panel20.TabIndex = 31;
            // 
            // txt_Detay
            // 
            this.txt_Detay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Detay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Detay.Location = new System.Drawing.Point(65, 333);
            this.txt_Detay.Name = "txt_Detay";
            this.txt_Detay.Size = new System.Drawing.Size(100, 13);
            this.txt_Detay.TabIndex = 30;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Location = new System.Drawing.Point(3, 396);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(80, 23);
            this.btnGüncelle.TabIndex = 29;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(3, 364);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 26);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(25, 316);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(140, 1);
            this.panel10.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(24, 284);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(140, 1);
            this.panel9.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(24, 248);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 1);
            this.panel8.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 206);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(140, 1);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(24, 173);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 1);
            this.panel7.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(25, 137);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 1);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(25, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 1);
            this.panel5.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(24, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 1);
            this.panel4.TabIndex = 19;
            // 
            // txt_Stock
            // 
            this.txt_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Stock.ForeColor = System.Drawing.Color.White;
            this.txt_Stock.Location = new System.Drawing.Point(77, 300);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(75, 13);
            this.txt_Stock.TabIndex = 18;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ISBN.ForeColor = System.Drawing.Color.White;
            this.txt_ISBN.Location = new System.Drawing.Point(65, 269);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(75, 13);
            this.txt_ISBN.TabIndex = 17;
            // 
            // txt_Type
            // 
            this.txt_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Type.ForeColor = System.Drawing.Color.White;
            this.txt_Type.Location = new System.Drawing.Point(65, 229);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(75, 13);
            this.txt_Type.TabIndex = 16;
            // 
            // txt_publishDate
            // 
            this.txt_publishDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_publishDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_publishDate.ForeColor = System.Drawing.Color.White;
            this.txt_publishDate.Location = new System.Drawing.Point(77, 190);
            this.txt_publishDate.Name = "txt_publishDate";
            this.txt_publishDate.Size = new System.Drawing.Size(75, 13);
            this.txt_publishDate.TabIndex = 15;
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Price.ForeColor = System.Drawing.Color.White;
            this.txt_Price.Location = new System.Drawing.Point(65, 158);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(75, 13);
            this.txt_Price.TabIndex = 14;
            // 
            // txt_Page
            // 
            this.txt_Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Page.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Page.ForeColor = System.Drawing.Color.White;
            this.txt_Page.Location = new System.Drawing.Point(65, 121);
            this.txt_Page.Name = "txt_Page";
            this.txt_Page.Size = new System.Drawing.Size(75, 13);
            this.txt_Page.TabIndex = 13;
            // 
            // txt_Author
            // 
            this.txt_Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Author.ForeColor = System.Drawing.Color.White;
            this.txt_Author.Location = new System.Drawing.Point(65, 96);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(75, 13);
            this.txt_Author.TabIndex = 12;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.ForeColor = System.Drawing.Color.White;
            this.txt_Name.Location = new System.Drawing.Point(65, 64);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(75, 13);
            this.txt_Name.TabIndex = 11;
            // 
            // label_Stock
            // 
            this.label_Stock.AutoSize = true;
            this.label_Stock.ForeColor = System.Drawing.Color.White;
            this.label_Stock.Location = new System.Drawing.Point(26, 300);
            this.label_Stock.Name = "label_Stock";
            this.label_Stock.Size = new System.Drawing.Size(29, 13);
            this.label_Stock.TabIndex = 10;
            this.label_Stock.Text = "Adet";
            // 
            // label_ISBN
            // 
            this.label_ISBN.AutoSize = true;
            this.label_ISBN.ForeColor = System.Drawing.Color.White;
            this.label_ISBN.Location = new System.Drawing.Point(23, 265);
            this.label_ISBN.Name = "label_ISBN";
            this.label_ISBN.Size = new System.Drawing.Size(32, 13);
            this.label_ISBN.TabIndex = 9;
            this.label_ISBN.Text = "ISBN";
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.ForeColor = System.Drawing.Color.White;
            this.label_Type.Location = new System.Drawing.Point(23, 229);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(23, 13);
            this.label_Type.TabIndex = 8;
            this.label_Type.Text = "Tür";
            // 
            // label_Detail
            // 
            this.label_Detail.AutoSize = true;
            this.label_Detail.ForeColor = System.Drawing.Color.White;
            this.label_Detail.Location = new System.Drawing.Point(22, 336);
            this.label_Detail.Name = "label_Detail";
            this.label_Detail.Size = new System.Drawing.Size(35, 13);
            this.label_Detail.TabIndex = 7;
            this.label_Detail.Text = "Detay";
            // 
            // label_publishDate
            // 
            this.label_publishDate.AutoSize = true;
            this.label_publishDate.ForeColor = System.Drawing.Color.White;
            this.label_publishDate.Location = new System.Drawing.Point(21, 190);
            this.label_publishDate.Name = "label_publishDate";
            this.label_publishDate.Size = new System.Drawing.Size(62, 13);
            this.label_publishDate.TabIndex = 6;
            this.label_publishDate.Text = "Yayın Tarihi";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.ForeColor = System.Drawing.Color.White;
            this.label_Price.Location = new System.Drawing.Point(21, 154);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(29, 13);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "Fiyat";
            // 
            // label_Page
            // 
            this.label_Page.AutoSize = true;
            this.label_Page.ForeColor = System.Drawing.Color.White;
            this.label_Page.Location = new System.Drawing.Point(23, 121);
            this.label_Page.Name = "label_Page";
            this.label_Page.Size = new System.Drawing.Size(34, 13);
            this.label_Page.TabIndex = 4;
            this.label_Page.Text = "Sayfa";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Author.ForeColor = System.Drawing.Color.White;
            this.label_Author.Location = new System.Drawing.Point(21, 92);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(36, 13);
            this.label_Author.TabIndex = 3;
            this.label_Author.Text = "Yazarı";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.label_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(22, 60);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(22, 13);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Adı";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(90, 1);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lbl_Add
            // 
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Add.ForeColor = System.Drawing.Color.White;
            this.lbl_Add.Location = new System.Drawing.Point(85, 11);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(41, 23);
            this.lbl_Add.TabIndex = 0;
            this.lbl_Add.Text = "Ekle";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnDelete);
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.textDelete);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.labelDelete);
            this.panel12.Location = new System.Drawing.Point(339, 64);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 122);
            this.panel12.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(61, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(74, 33);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(44, 1);
            this.panel14.TabIndex = 4;
            // 
            // textDelete
            // 
            this.textDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.textDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDelete.ForeColor = System.Drawing.Color.White;
            this.textDelete.Location = new System.Drawing.Point(61, 60);
            this.textDelete.Name = "textDelete";
            this.textDelete.Size = new System.Drawing.Size(100, 13);
            this.textDelete.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.ForeColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(15, 75);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(146, 1);
            this.panel13.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDelete.ForeColor = System.Drawing.Color.White;
            this.labelDelete.Location = new System.Drawing.Point(79, 9);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(36, 25);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Sil";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dataBookList
            // 
            this.dataBookList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dataBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookList.Location = new System.Drawing.Point(3, 60);
            this.dataBookList.Name = "dataBookList";
            this.dataBookList.Size = new System.Drawing.Size(330, 452);
            this.dataBookList.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btn_sat);
            this.panel15.Controls.Add(this.label3);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.txtKitapSat);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Location = new System.Drawing.Point(339, 192);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 320);
            this.panel15.TabIndex = 5;
            // 
            // btn_sat
            // 
            this.btn_sat.FlatAppearance.BorderSize = 0;
            this.btn_sat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sat.ForeColor = System.Drawing.Color.White;
            this.btn_sat.Location = new System.Drawing.Point(61, 98);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(75, 33);
            this.btn_sat.TabIndex = 5;
            this.btn_sat.Text = "Sat";
            this.btn_sat.UseVisualStyleBackColor = true;
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İsim";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Location = new System.Drawing.Point(15, 83);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(146, 1);
            this.panel17.TabIndex = 3;
            // 
            // txtKitapSat
            // 
            this.txtKitapSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txtKitapSat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKitapSat.ForeColor = System.Drawing.Color.White;
            this.txtKitapSat.Location = new System.Drawing.Point(48, 66);
            this.txtKitapSat.Name = "txtKitapSat";
            this.txtKitapSat.Size = new System.Drawing.Size(113, 13);
            this.txtKitapSat.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Location = new System.Drawing.Point(48, 36);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(113, 1);
            this.panel16.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Sat";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.dataBookList);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(760, 515);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookList)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Detail;
        private System.Windows.Forms.Label label_publishDate;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Page;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label label_ISBN;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_publishDate;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Page;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label_Stock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textDelete;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dataBookList;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_sat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtKitapSat;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txt_Detay;
    }
}
