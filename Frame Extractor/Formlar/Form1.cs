using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;

using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace Frame_Extractor
{
    public partial class Form1 : Form
    {
        string OutputPath, InputPath;
        double TotalFrames, Period;
        bool CancelSignal;

        MediaFile Mp4Media;
        private string SelectedImagePath;

        public Form1()
        {
            InitializeComponent();
            CancelSignal = false;
        }

        private void SelectVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select an MP4 file",
                Filter = "Video files (*.mp4)|*.mp4",
                Title = "Open MP4 File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                InputPath = openFileDialog1.FileName;
                OutputPath = Directory.GetParent(InputPath) + "\\Extracted - " + Path.GetFileNameWithoutExtension(InputPath);
                VideoPathBox.Text = InputPath;
                OutputPathBox.Text = OutputPath;

                Mp4Media = new MediaFile { Filename = InputPath };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(Mp4Media);
                }

                TotalFrames = Mp4Media.Metadata.Duration.TotalSeconds * Mp4Media.Metadata.VideoData.Fps;
                ExtractionProgress.Maximum = (int)TotalFrames;
                ExtractionProgress.Value = 0;

                //TitleLabel.Text = "Title : " + Path.GetFileNameWithoutExtension(InputPath);
                //FrameRateLabel.Text = "Frame Rate : " + Mp4Media.Metadata.VideoData.Fps.ToString() + " FPS";
                //DurationLabel.Text = "Duration : " + Mp4Media.Metadata.Duration.ToString();
                //ExpectedFramesLabel.Text = "Expected Frames : " + ExtractionProgress.Maximum.ToString();

                ModeSelector.SelectedIndex = 0;
                Box.Enabled = true;
            }
        }

        private void SelectOutputFolderButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select output directory to save the frames.";
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    OutputPath = folderBrowserDialog.SelectedPath;
                    OutputPathBox.Text = OutputPath;
                }
            }
        }

        private async void ExtractButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(OutputPath);

            VideoPathBox.Enabled = false;
            SelectVideoButton.Enabled = false;
            CancelButton.Enabled = true;
            ExtractButton.Enabled = false;
            OutputPathBox.Enabled = false;
            ModeSelector.Enabled = false;

            await StartExtraction();

            ProgressLabel.Text = "";
            PercentLabel.Text = "";
            VideoPathBox.Enabled = true;
            SelectVideoButton.Enabled = true;
            CancelButton.Enabled = false;
            ExtractButton.Enabled = true;
            OutputPathBox.Enabled = true;
            ModeSelector.Enabled = true;

            if (CancelSignal)
            {
                CancelSignal = false;
                MessageBox.Show("Operasyon Durduruldu.", "Durduruldu.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult r = MessageBox.Show(ExtractionProgress.Maximum.ToString() + " Frames were extracted. Open Output folder?", "Operation Completed Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                    System.Diagnostics.Process.Start(OutputPath);
            }
        }

        private  async Task StartExtraction()
        {
            await Task.Run(delegate
            {
                using (var engine = new Engine())
                {
                    double seeker = 0;

                    for (int i = 0; i < ExtractionProgress.Maximum; i++, seeker += Period)
                    {
                        var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(seeker) };
                        var outputFile = new MediaFile { Filename = string.Format("{0}\\Frame-{1}.jpeg", OutputPath, i) };
                        engine.GetThumbnail(Mp4Media, outputFile, options);

                        ExtractionProgress.Invoke(new Action(delegate
                        {
                            ExtractionProgress.Value++;
                            ProgressLabel.Text = "Frames Done : " + i.ToString() + "/" + ExtractionProgress.Maximum.ToString();
                            PercentLabel.Text = ((i * 100) / ExtractionProgress.Maximum).ToString() + "%";
                        }));

                        if (CancelSignal) break;
                    }
                }
            });
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Emin misiniz?", "Operasyon İptal Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
                CancelSignal = true;
        }

        private void Box_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select an Image file",
                Filter = "Image files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif",
                Title = "Open Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Display the selected image in PictureBoxImage
                try
                {
                    Image selectedImage = Image.FromFile(imagePath);
                    pictureBoxImage.Image = selectedImage;
                    SelectedImagePath = imagePath;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    Period = 1D / Mp4Media.Metadata.VideoData.Fps;
                    ExtractionProgress.Maximum = (int)TotalFrames;
                    //ExpectedFramesLabel.Text = "Expected Frames : " + ExtractionProgress.Maximum.ToString();
                    break;

                case 1:
                    Period = 1;
                    ExtractionProgress.Maximum = (int)Mp4Media.Metadata.Duration.TotalSeconds;
                    //ExpectedFramesLabel.Text = "Expected Frames : " + ((int)Mp4Media.Metadata.Duration.TotalSeconds).ToString();
                    break;
            }
        }

        private void PlateRecognizeButton_Click(object sender, EventArgs e)
        {
            FirstForm firstForm = new FirstForm();
            firstForm.Show();
        }

        

        private void ImageProcessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedImagePath))
            {
                MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(SelectedImagePath);
            // Call the API and display the output in a new form
              CallApiAndDisplayOutput(SelectedImagePath);
        }



        private async Task CallApiAndDisplayOutput(string SelectedImagePath)
        {
            MessageBox.Show("fonksiyona girdi");
            try
            {
                Console.WriteLine($"Fonksiyona girdi ve path: {SelectedImagePath}");

                // Hedef API'nin URL'sini belirtin
                string apiUrl = "http://127.0.0.1:8001/upload/";

                // Dosya adını alma
                string fileName = Path.GetFileName(SelectedImagePath);

                using (WebClient client = new WebClient())
                {
                    var result = client.UploadFile("http://127.0.0.1:8001/upload/", SelectedImagePath);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(result));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message} {ex.StackTrace}");
            }

        }

    }
}

