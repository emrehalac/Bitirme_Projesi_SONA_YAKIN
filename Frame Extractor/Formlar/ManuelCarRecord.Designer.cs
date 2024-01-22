namespace Frame_Extractor.Formlar
{
    partial class ManuelCarRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManuelCarRecord));
            this.sideBar1 = new Frame_Extractor.Formlar.SideBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAracModeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAracSahibi = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAracKaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sideBar1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.Controls.Add(this.groupBox1);
            this.sideBar1.Controls.Add(this.pictureBox1);
            this.sideBar1.Controls.Add(this.button1);
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBar1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(130)))));
            this.sideBar1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(570, 453);
            this.sideBar1.TabIndex = 1;
            this.sideBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAracModeli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAracSahibi);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAracKaydet);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(88, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manuel Olarak Araç Kayıtlamak İçin Formu Doldurun!";
            // 
            // txtAracModeli
            // 
            this.txtAracModeli.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAracModeli.Location = new System.Drawing.Point(179, 124);
            this.txtAracModeli.Name = "txtAracModeli";
            this.txtAracModeli.Size = new System.Drawing.Size(146, 25);
            this.txtAracModeli.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Araç Modelini Giriniz : ";
            // 
            // txtAracSahibi
            // 
            this.txtAracSahibi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAracSahibi.Location = new System.Drawing.Point(179, 79);
            this.txtAracSahibi.Name = "txtAracSahibi";
            this.txtAracSahibi.Size = new System.Drawing.Size(146, 25);
            this.txtAracSahibi.TabIndex = 5;
            // 
            // txtPlaka
            // 
            this.txtPlaka.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPlaka.ForeColor = System.Drawing.Color.Black;
            this.txtPlaka.Location = new System.Drawing.Point(179, 37);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(146, 25);
            this.txtPlaka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araç Sahibini Giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Plakasını Giriniz:";
            // 
            // btnAracKaydet
            // 
            this.btnAracKaydet.BackColor = System.Drawing.Color.Indigo;
            this.btnAracKaydet.Location = new System.Drawing.Point(147, 181);
            this.btnAracKaydet.Name = "btnAracKaydet";
            this.btnAracKaydet.Size = new System.Drawing.Size(162, 30);
            this.btnAracKaydet.TabIndex = 0;
            this.btnAracKaydet.Text = "Aracı Kaydet";
            this.btnAracKaydet.UseVisualStyleBackColor = false;
            this.btnAracKaydet.Click += new System.EventHandler(this.btnAracKaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManuelCarRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.sideBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManuelCarRecord";
            this.Text = "MYPS ile Manuel Olarak da Araç Kayıtlayabilirsiniz!";
            this.sideBar1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SideBar sideBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAracSahibi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAracModeli;
        private System.Windows.Forms.Label label3;
    }
}