using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.IO;

namespace TextRecognitionTesseract
{
    public partial class TextRecognition : Form
    {
        public TextRecognition()
        {
            InitializeComponent();
        }

        private void chooseImage_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFile.FileName);
                loadImage.ImageLocation = openFile.FileName;
                var chooseImage = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
                var page = chooseImage.Process(img);
                textRecognitionResult.Text = page.GetText();
            }
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            if (textRecognitionResult.Text != "")
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFile.FileName;
                    BinaryWriter file = new BinaryWriter(File.Create(filename));
                    file.Write(textRecognitionResult.Text);
                    file.Dispose();
                }
            }
        }
    }
}
