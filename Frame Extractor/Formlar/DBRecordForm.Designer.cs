namespace Frame_Extractor
{
    partial class DBRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBRecordForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewParks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sideBar1 = new Frame_Extractor.Formlar.SideBar();
            this.btnKayıtListele = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlakaSorgu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAracKayitlaFormuAc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParks)).BeginInit();
            this.panel1.SuspendLayout();
            this.sideBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewParks
            // 
            this.dataGridViewParks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewParks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewParks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewParks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParks.Location = new System.Drawing.Point(207, 202);
            this.dataGridViewParks.Name = "dataGridViewParks";
            this.dataGridViewParks.RowHeadersWidth = 51;
            this.dataGridViewParks.RowTemplate.Height = 24;
            this.dataGridViewParks.Size = new System.Drawing.Size(823, 332);
            this.dataGridViewParks.TabIndex = 2;
            this.dataGridViewParks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(482, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Halaç Otoparkı Kayıt Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 29);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Otoparklarınızın Güvenli Hali: Make Your Parks Safer ! \r\n";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sideBar1
            // 
            this.sideBar1.Controls.Add(this.btnKayıtListele);
            this.sideBar1.Controls.Add(this.button5);
            this.sideBar1.Controls.Add(this.btnHome);
            this.sideBar1.Controls.Add(this.btnPlakaSorgu);
            this.sideBar1.Controls.Add(this.button2);
            this.sideBar1.Controls.Add(this.label2);
            this.sideBar1.Controls.Add(this.txtAracKayitlaFormuAc);
            this.sideBar1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(130)))));
            this.sideBar1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.sideBar1.Location = new System.Drawing.Point(1, 23);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(193, 624);
            this.sideBar1.TabIndex = 11;
            // 
            // btnKayıtListele
            // 
            this.btnKayıtListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnKayıtListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKayıtListele.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtListele.ForeColor = System.Drawing.Color.Transparent;
            this.btnKayıtListele.Location = new System.Drawing.Point(0, 142);
            this.btnKayıtListele.Name = "btnKayıtListele";
            this.btnKayıtListele.Size = new System.Drawing.Size(200, 55);
            this.btnKayıtListele.TabIndex = 9;
            this.btnKayıtListele.Text = "Kayıt Getir";
            this.btnKayıtListele.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtListele.UseVisualStyleBackColor = false;
            this.btnKayıtListele.Click += new System.EventHandler(this.btnKayıtListele_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(0, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 62);
            this.button5.TabIndex = 8;
            this.button5.Text = "Oturumumu Kapat";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.IndianRed;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Location = new System.Drawing.Point(0, 370);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 61);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlakaSorgu
            // 
            this.btnPlakaSorgu.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlakaSorgu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlakaSorgu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlakaSorgu.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlakaSorgu.Location = new System.Drawing.Point(0, 311);
            this.btnPlakaSorgu.Name = "btnPlakaSorgu";
            this.btnPlakaSorgu.Size = new System.Drawing.Size(200, 63);
            this.btnPlakaSorgu.TabIndex = 5;
            this.btnPlakaSorgu.Text = "Plaka Sorgula\r\n";
            this.btnPlakaSorgu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlakaSorgu.UseVisualStyleBackColor = false;
            this.btnPlakaSorgu.Click += new System.EventHandler(this.btnPlakaSorgu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(0, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Misafir İzni";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Otopark İşlemleri";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAracKayitlaFormuAc
            // 
            this.txtAracKayitlaFormuAc.BackColor = System.Drawing.Color.IndianRed;
            this.txtAracKayitlaFormuAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAracKayitlaFormuAc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracKayitlaFormuAc.ForeColor = System.Drawing.Color.Transparent;
            this.txtAracKayitlaFormuAc.Location = new System.Drawing.Point(0, 196);
            this.txtAracKayitlaFormuAc.Name = "txtAracKayitlaFormuAc";
            this.txtAracKayitlaFormuAc.Size = new System.Drawing.Size(200, 68);
            this.txtAracKayitlaFormuAc.TabIndex = 3;
            this.txtAracKayitlaFormuAc.Text = "Manuel Araç Kayıtla";
            this.txtAracKayitlaFormuAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAracKayitlaFormuAc.UseVisualStyleBackColor = false;
            this.txtAracKayitlaFormuAc.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1042, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewParks);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "DBRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MYPS- Araç Kayıt Ekranı";
            this.Load += new System.EventHandler(this.DBRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sideBar1.ResumeLayout(false);
            this.sideBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewParks;
        private System.Windows.Forms.Button txtAracKayitlaFormuAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Formlar.SideBar sideBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlakaSorgu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnKayıtListele;
    }
}