using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Transparent_Picture_Background
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
            this.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            openFileDialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtSource.Text = openFileDialog.SelectedPath;
            else
                MessageBox.Show("The address entered is not correct.");
        }

        public void DrawTransparent(List<string> picPath)
        {
            // Create a Bitmap object from an image file.

            foreach (var pic in picPath)
            {
                Image convertedImage = new Bitmap(MakeImageTransparent(new Bitmap(pic)));
                string newpicPath = pic.Substring(0, pic.IndexOf('.'));
                convertedImage.Save(newpicPath + ".png", ImageFormat.Png);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            List<string> folderPath = new List<string>();
            string[] result = GetAllFilesInFolder();

            if (result.Length != 0)
            {
                foreach (var t in result)
                    folderPath.Add(t);

                DrawTransparent(folderPath);
            }
        }

        public string[] GetAllFilesInFolder()
        {
            string[] files = new string[] { };
            if (!string.IsNullOrEmpty(txtSource.Text))
            {
                files = Directory.GetFiles(txtSource.Text, "*.jpg", SearchOption.AllDirectories);
                if (files.Length != 0)
                    MessageBox.Show("No files found.");
            }
            else
                MessageBox.Show("Address not found.");
            return files;
        }

        public static Bitmap MakeImageTransparent(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            var replacementColour = Color.FromArgb(255, 255, 255);

            for (int i = bmp.Size.Width - 1; i >= 0; i--)
            {
                for (int j = bmp.Size.Height - 1; j >= 0; j--)
                {
                    var col = bmp.GetPixel(i, j);

                    if (255 - col.R == 0 &&
                        255 - col.G == 0 &&
                        255 - col.B == 0)
                    {
                        bmp.SetPixel(i, j, replacementColour);
                    }
                }
            }

            bmp.MakeTransparent(replacementColour);
            return bmp;
        }
    }
}
