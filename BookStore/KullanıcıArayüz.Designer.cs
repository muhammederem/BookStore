namespace BookStore
{
    partial class KullanıcıArayüz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıArayüz));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnKullanıcı = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ımportUC1 = new BookStore.ImportUC();
            this.mainPage1 = new BookStore.MainPage();
            this.kullanıcıUserC1 = new BookStore.KullanıcıUserC();
            this.girisUC1 = new BookStore.GirisUC();
            this.dergiUserC1 = new BookStore.DergiUserC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btn_Down);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Down.ForeColor = System.Drawing.Color.White;
            this.btn_Down.Location = new System.Drawing.Point(773, 0);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(44, 29);
            this.btn_Down.TabIndex = 1;
            this.btn_Down.Text = "-";
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(815, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(45, 29);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.panelLeft);
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnSell);
            this.panel2.Controls.Add(this.btnKullanıcı);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.btn_Main);
            this.panel2.Location = new System.Drawing.Point(1, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 515);
            this.panel2.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.panelLeft.Location = new System.Drawing.Point(89, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 107);
            this.panelLeft.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 412);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(99, 103);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSell.BackgroundImage")));
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(0, 309);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(99, 103);
            this.btnSell.TabIndex = 3;
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullanıcı.BackgroundImage")));
            this.btnKullanıcı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKullanıcı.FlatAppearance.BorderSize = 0;
            this.btnKullanıcı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanıcı.ForeColor = System.Drawing.Color.White;
            this.btnKullanıcı.Location = new System.Drawing.Point(0, 206);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(99, 103);
            this.btnKullanıcı.TabIndex = 2;
            this.btnKullanıcı.UseVisualStyleBackColor = true;
            this.btnKullanıcı.Click += new System.EventHandler(this.btnKullanıcı_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBook.BackgroundImage")));
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(0, 103);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(99, 103);
            this.btnBook.TabIndex = 1;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btn_Main
            // 
            this.btn_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btn_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Main.BackgroundImage")));
            this.btn_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Main.FlatAppearance.BorderSize = 0;
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.ForeColor = System.Drawing.Color.White;
            this.btn_Main.Location = new System.Drawing.Point(0, 0);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(99, 103);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ımportUC1);
            this.panel3.Controls.Add(this.mainPage1);
            this.panel3.Controls.Add(this.kullanıcıUserC1);
            this.panel3.Controls.Add(this.girisUC1);
            this.panel3.Controls.Add(this.dergiUserC1);
            this.panel3.Location = new System.Drawing.Point(100, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 515);
            this.panel3.TabIndex = 2;
            // 
            // ımportUC1
            // 
            this.ımportUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ımportUC1.Location = new System.Drawing.Point(0, 0);
            this.ımportUC1.Name = "ımportUC1";
            this.ımportUC1.Size = new System.Drawing.Size(760, 515);
            this.ımportUC1.TabIndex = 5;
            // 
            // mainPage1
            // 
            this.mainPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.mainPage1.Location = new System.Drawing.Point(0, 0);
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(760, 515);
            this.mainPage1.TabIndex = 4;
            // 
            // kullanıcıUserC1
            // 
            this.kullanıcıUserC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.kullanıcıUserC1.Location = new System.Drawing.Point(0, 0);
            this.kullanıcıUserC1.Name = "kullanıcıUserC1";
            this.kullanıcıUserC1.Size = new System.Drawing.Size(760, 515);
            this.kullanıcıUserC1.TabIndex = 3;
            // 
            // girisUC1
            // 
            this.girisUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.girisUC1.Location = new System.Drawing.Point(0, 20);
            this.girisUC1.Name = "girisUC1";
            this.girisUC1.Size = new System.Drawing.Size(760, 474);
            this.girisUC1.TabIndex = 1;
            // 
            // dergiUserC1
            // 
            this.dergiUserC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dergiUserC1.Location = new System.Drawing.Point(-1, 0);
            this.dergiUserC1.Name = "dergiUserC1";
            this.dergiUserC1.Size = new System.Drawing.Size(760, 515);
            this.dergiUserC1.TabIndex = 0;
            // 
            // KullanıcıArayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(861, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullanıcıArayüz";
            this.Text = "KullanıcıArayüz";
            this.Load += new System.EventHandler(this.KullanıcıArayüz_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnKullanıcı;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private MainPage mainPage1;
        private KullanıcıUserC kullanıcıUserC1;
        private GirisUC girisUC1;
        private DergiUserC dergiUserC1;
        private ImportUC ımportUC1;
    }
}