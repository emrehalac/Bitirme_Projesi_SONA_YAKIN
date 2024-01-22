namespace Frame_Extractor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VideoPathBox = new System.Windows.Forms.TextBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.OutputPathBox = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.GroupBox();
            this.SelectOutputFolderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ModeSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtractionProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.PlateRecognizeButton = new System.Windows.Forms.Button();
            this.ImageProcessButton = new System.Windows.Forms.Button();
            this.SelectVideoButton = new System.Windows.Forms.Button();
            this.sideBar1 = new Frame_Extractor.Formlar.SideBar();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VideoPathBox
            // 
            this.VideoPathBox.Location = new System.Drawing.Point(430, 585);
            this.VideoPathBox.Margin = new System.Windows.Forms.Padding(4);
            this.VideoPathBox.Name = "VideoPathBox";
            this.VideoPathBox.ReadOnly = true;
            this.VideoPathBox.Size = new System.Drawing.Size(217, 23);
            this.VideoPathBox.TabIndex = 0;
            this.VideoPathBox.Text = "Lütfen Video Seçiniz...";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractButton.Location = new System.Drawing.Point(171, 101);
            this.ExtractButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(139, 31);
            this.ExtractButton.TabIndex = 7;
            this.ExtractButton.Text = "Dönüştür!";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // OutputPathBox
            // 
            this.OutputPathBox.Location = new System.Drawing.Point(7, 44);
            this.OutputPathBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputPathBox.Name = "OutputPathBox";
            this.OutputPathBox.ReadOnly = true;
            this.OutputPathBox.Size = new System.Drawing.Size(303, 23);
            this.OutputPathBox.TabIndex = 6;
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.Color.Transparent;
            this.Box.Controls.Add(this.SelectOutputFolderButton);
            this.Box.Controls.Add(this.CancelButton);
            this.Box.Controls.Add(this.label1);
            this.Box.Controls.Add(this.ModeSelector);
            this.Box.Controls.Add(this.label5);
            this.Box.Controls.Add(this.OutputPathBox);
            this.Box.Controls.Add(this.ExtractButton);
            this.Box.Enabled = false;
            this.Box.Location = new System.Drawing.Point(404, 625);
            this.Box.Margin = new System.Windows.Forms.Padding(4);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(4);
            this.Box.Size = new System.Drawing.Size(462, 143);
            this.Box.TabIndex = 8;
            this.Box.TabStop = false;
            this.Box.Text = "Video Dönüştürme Detayları";
            this.Box.Enter += new System.EventHandler(this.Box_Enter);
            // 
            // SelectOutputFolderButton
            // 
            this.SelectOutputFolderButton.Location = new System.Drawing.Point(330, 36);
            this.SelectOutputFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectOutputFolderButton.Name = "SelectOutputFolderButton";
            this.SelectOutputFolderButton.Size = new System.Drawing.Size(115, 31);
            this.SelectOutputFolderButton.TabIndex = 12;
            this.SelectOutputFolderButton.Text = "Dosya Seç";
            this.SelectOutputFolderButton.UseVisualStyleBackColor = true;
            this.SelectOutputFolderButton.Click += new System.EventHandler(this.SelectOutputFolderButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(330, 101);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 31);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "İptal";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "İşlem:";
            // 
            // ModeSelector
            // 
            this.ModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelector.FormattingEnabled = true;
            this.ModeSelector.Items.AddRange(new object[] {
            "Tüm Kareleri Yakala",
            "Saniyede 1 Kare Yakala"});
            this.ModeSelector.Location = new System.Drawing.Point(8, 105);
            this.ModeSelector.Margin = new System.Windows.Forms.Padding(4);
            this.ModeSelector.Name = "ModeSelector";
            this.ModeSelector.Size = new System.Drawing.Size(141, 24);
            this.ModeSelector.TabIndex = 9;
            this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Aktarılacak Hedef  Dosya : ";
            // 
            // ExtractionProgress
            // 
            this.ExtractionProgress.Location = new System.Drawing.Point(411, 786);
            this.ExtractionProgress.Margin = new System.Windows.Forms.Padding(4);
            this.ExtractionProgress.Name = "ExtractionProgress";
            this.ExtractionProgress.Size = new System.Drawing.Size(455, 11);
            this.ExtractionProgress.TabIndex = 9;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(11, 320);
            this.ProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(0, 16);
            this.ProgressLabel.TabIndex = 9;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(512, 216);
            this.PercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(0, 16);
            this.PercentLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lütfen Tanımlama İçin Video ya da Resim Yükleyiniz...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "ya da";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxImage.Location = new System.Drawing.Point(55, 118);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(515, 393);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 15;
            this.pictureBoxImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(631, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.BackColor = System.Drawing.Color.Indigo;
            this.SelectImageButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectImageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectImageButton.Location = new System.Drawing.Point(650, 50);
            this.SelectImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(142, 28);
            this.SelectImageButton.TabIndex = 13;
            this.SelectImageButton.Text = "Fotoğraf Yükleyin";
            this.SelectImageButton.UseVisualStyleBackColor = false;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // PlateRecognizeButton
            // 
            this.PlateRecognizeButton.BackColor = System.Drawing.Color.Indigo;
            this.PlateRecognizeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlateRecognizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlateRecognizeButton.Location = new System.Drawing.Point(383, 536);
            this.PlateRecognizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlateRecognizeButton.Name = "PlateRecognizeButton";
            this.PlateRecognizeButton.Size = new System.Drawing.Size(203, 33);
            this.PlateRecognizeButton.TabIndex = 18;
            this.PlateRecognizeButton.Text = "Plaka Tanı ve Aracı Kaydet";
            this.PlateRecognizeButton.UseVisualStyleBackColor = false;
            this.PlateRecognizeButton.Click += new System.EventHandler(this.PlateRecognizeButton_Click);
            // 
            // ImageProcessButton
            // 
            this.ImageProcessButton.BackColor = System.Drawing.Color.Indigo;
            this.ImageProcessButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ImageProcessButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImageProcessButton.Location = new System.Drawing.Point(650, 536);
            this.ImageProcessButton.Margin = new System.Windows.Forms.Padding(4);
            this.ImageProcessButton.Name = "ImageProcessButton";
            this.ImageProcessButton.Size = new System.Drawing.Size(199, 33);
            this.ImageProcessButton.TabIndex = 17;
            this.ImageProcessButton.Text = "Görüntüyü İyileştir";
            this.ImageProcessButton.UseVisualStyleBackColor = false;
            this.ImageProcessButton.Click += new System.EventHandler(this.ImageProcessButton_Click);
            // 
            // SelectVideoButton
            // 
            this.SelectVideoButton.BackColor = System.Drawing.Color.Indigo;
            this.SelectVideoButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectVideoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectVideoButton.Location = new System.Drawing.Point(383, 50);
            this.SelectVideoButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectVideoButton.Name = "SelectVideoButton";
            this.SelectVideoButton.Size = new System.Drawing.Size(136, 28);
            this.SelectVideoButton.TabIndex = 1;
            this.SelectVideoButton.Text = "Video Seç";
            this.SelectVideoButton.UseVisualStyleBackColor = false;
            this.SelectVideoButton.Click += new System.EventHandler(this.SelectVideoButton_Click);
            // 
            // sideBar1
            // 
            this.sideBar1.Controls.Add(this.SelectVideoButton);
            this.sideBar1.Controls.Add(this.SelectImageButton);
            this.sideBar1.Controls.Add(this.label2);
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideBar1.gradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(36)))), ((int)(((byte)(130)))));
            this.sideBar1.gradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(1210, 94);
            this.sideBar1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1210, 810);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.ImageProcessButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlateRecognizeButton);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ExtractionProgress);
            this.Controls.Add(this.VideoPathBox);
            this.Controls.Add(this.sideBar1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Your Parks Safer ile Araçlarınız Artık Güvende!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideBar1.ResumeLayout(false);
            this.sideBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VideoPathBox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.TextBox OutputPathBox;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.ProgressBar ExtractionProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ModeSelector;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectOutputFolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button PlateRecognizeButton;
        private System.Windows.Forms.Button ImageProcessButton;
        private System.Windows.Forms.Button SelectVideoButton;
        private Formlar.SideBar sideBar1;
    }
}

