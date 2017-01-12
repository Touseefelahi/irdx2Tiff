using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irdx2Tiff
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        string info
        {
            set
            {
                MessageBox.Show(value);
            }
        }
        string lastPath;
        private async void buttonOpen_Click(object sender, EventArgs e)
        {
            var convertedImage = new Image<Gray,UInt16>(640, 480);
            var res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var path2Image = openFileDialog.FileNames;
                var totalImages = path2Image.Length;
                progressBar.Value = 0;
                progressBar.Maximum = totalImages;
                progressBar.Step = 1;
                try
                {
                    foreach (string path2ImageFile in path2Image)
                    {
                        lastPath = path2ImageFile;
                        convertedImage = convertImage(path2ImageFile);

                        progressBar.PerformStep();

                        imageBoxConverted.Image = convertedImage;

                        await Task.Delay(100);
                        saveImage(convertedImage);
                    }
                }
                catch (Exception exep)
                {
                    //Display Error
                    info = exep.ToString();
                }
            }
            else
            {
                info = "Error in Opening File, please select correct Irdx image file\n";
            }

            openFileDialog.Dispose();
        }

        void saveImage(Image<Gray,ushort> imageToBeSaved)
        {
            var imageFile = lastPath.Substring(0,lastPath.Length - 4);
            CvInvoke.Imwrite(imageFile + "tif", imageToBeSaved,100);
           
        }
         Image<Gray,ushort> convertImage(string irdxFilePath)
        {
            using (var file = new FileStream(irdxFilePath, FileMode.Open))
            {
                var checkLength = file.Length;
                var generatedImage = new Image<Gray, ushort>(640, 480);
                char[] bytesToCheck = { 'I', 'N', '1', '=', '0' };

                for (int row = 0; row < 20000; row++)
                {
                    if(file.ReadByte() ==(byte) bytesToCheck[0])
                    {
                        if (file.ReadByte() == (byte)bytesToCheck[1])
                        {
                            if (file.ReadByte() == (byte)bytesToCheck[2])
                            {
                                if (file.ReadByte() == (byte)bytesToCheck[3])
                                {
                                    if (file.ReadByte() == (byte)bytesToCheck[4])
                                    {
                                        for(int aaa=0;aaa<247;aaa++)
                                        {
                                            file.ReadByte();
                                        }
                                        break;
                                    }
                                       
                                }
                            }
                        } 
                    }
                }

                var sb = new StringBuilder();
               
                for (int row = 0; row < 480; row++)
                {
                    for (int col = 0; col < 640; col++)
                    {
                        var msb = (byte)file.ReadByte();
                       
                        var lsb = (byte)file.ReadByte();
                       
                        var pix16 = (ushort)(msb * 256 + lsb);
                        generatedImage.Data[row, col, 0] = pix16;
                        if (row==479&&col==639)
                            sb.Append(Convert.ToString(pix16));
                        else
                        sb.Append(Convert.ToString(pix16)+",");
                    }
                    sb.Append("\n");
                }

                var textFile = lastPath.Substring(0, lastPath.Length - 4);

                File.WriteAllText(textFile + "txt", sb.ToString());
                richTextBox1.Text = sb.ToString();
                return generatedImage;
            }
        }

        private void regenrateImage(object sender, EventArgs e)
        {
            var convertedImage = new Image<Gray, UInt16>(640, 480);
            convertedImage = convertImage(lastPath);
            imageBoxConverted.Image = convertedImage;;
        }
        
    }
}
