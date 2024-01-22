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

namespace Frame_Extractor.Formlar
{
    public partial class PlakaSorgula : Form
    {
        private FinalProjectEntities dbFromDBRecordForm;
        public PlakaSorgula(FinalProjectEntities db)
        {
            InitializeComponent();
            this.dbFromDBRecordForm = db;
        }

        private void btnPlakaSorgula_Click(object sender, EventArgs e)
        {
            ParkingRecords parkingRecords = new ParkingRecords();

            string plaka = txtPlakaSorgu.Text;

            try
            {
                // Plaka numarasına göre sorgulama
                var arac = dbFromDBRecordForm.ParkingRecords.FirstOrDefault(p => p.Plaka == plaka);
                if (arac != null)
                {

                    string message = $"Aradığınız {plaka} plakalı arac'a ait bilgiler aşağıdadır:" +
                    $"\nAraç Plakası: {arac.Plaka}" +
                    $"\nAraç Modeli: {arac.AracModeli}" +
                    $"\nAraç Sahibi: {arac.AracSahibi}" +
                    $"\nAraç Giris Saati,: {arac.GirisSaati}";
                    MessageBox.Show(message, "Araç Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Aradığınız plakaya sahip araca ait kayıt bulunamadı.", "Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    

                

            }
            catch (Exception ex)
            {
                // Hata yönetimi burada gerçekleştirilebilir
                Console.WriteLine("Hata: " + "Bu araç otoparkımıza kayıtlı olarak bulunamadı.");
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DBRecordForm dbRecordForm = new DBRecordForm();
            dbRecordForm.ShowDialog();
            this.Hide();
        }
    }
}
