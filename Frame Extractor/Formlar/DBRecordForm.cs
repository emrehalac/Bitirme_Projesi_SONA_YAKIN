using Frame_Extractor.Formlar;
using Frame_Extractor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Frame_Extractor
{
    public partial class DBRecordForm : Form
    {
        FinalProjectEntities db;
        
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        public DBRecordForm()
        {
            InitializeComponent();
        }

        private void dataGridViewParks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DBRecordForm_Load(object sender, EventArgs e)
        {

            db = new FinalProjectEntities();
            dataGridViewParks.DataSource = LoadRecords();
        }
        private List<ParkingRecords> LoadRecords()
        {
            return db.ParkingRecords.ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManuelCarRecord manuelCarRecord = new ManuelCarRecord(db);
            manuelCarRecord.ShowDialog();
            this.Hide();
        }

        private void btnKayıtListele_Click(object sender, EventArgs e)
        {
            dataGridViewParks.DataSource = db.ParkingRecords.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumunuzu kapatmak istediğinizden emin misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlakaSorgu_Click(object sender, EventArgs e)
        {
            // PLAKA SORGULAMA BUTONU : 

            PlakaSorgula plakaSorgula = new PlakaSorgula(db);
            plakaSorgula.ShowDialog();

            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.ShowDialog();
            
        }
    }
}
