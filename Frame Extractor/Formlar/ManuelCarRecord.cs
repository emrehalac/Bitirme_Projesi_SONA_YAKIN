using Frame_Extractor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_Extractor.Formlar
{
    public partial class ManuelCarRecord : Form
    {
        private FinalProjectEntities dbFromDBRecordForm;

        public ManuelCarRecord(FinalProjectEntities db)
        {
            InitializeComponent();
            this.dbFromDBRecordForm = db;
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            
            ParkingRecords parkingRecords = new ParkingRecords();
            parkingRecords.Plaka = txtPlaka.Text;
            parkingRecords.AracSahibi = txtAracSahibi.Text;
            parkingRecords.AracModeli = txtAracModeli.Text;
            DateTime dateTime = DateTime.Now;
            parkingRecords.GirisSaati = dateTime;
            dbFromDBRecordForm.ParkingRecords.Add(parkingRecords);
            try
            {
                dbFromDBRecordForm.SaveChanges();
                
            }
            
            catch(DbUpdateException err2)
            {
                throw;
            }
            catch (Exception err1)
            {

                throw;
            }
            
            MessageBox.Show("Araç başarıyla kaydedildi.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            DBRecordForm dBRecordForm = new DBRecordForm();
            dBRecordForm.Show();
        }

        private void sideBar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstForm firstForm = new FirstForm();
            firstForm.ShowDialog();
            this.Hide();
        }
    }
}
