using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Imaging;
using AForge.Video.DirectShow;
using System.IO;
using Tesseract;
using AForge.Imaging.Filters;
using static System.Net.Mime.MediaTypeNames;

namespace CameraToText
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice device;
        
        Rectangle Rect;
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;
        private void Main_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filter)
            {
                comPortDevices.Items.Add(filterInfo.Name);
            }
            comPortDevices.SelectedIndex = 1;
            device = new VideoCaptureDevice();
            pictureCam.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
            device = new VideoCaptureDevice(filter[comPortDevices.SelectedIndex].MonikerString);
            device.NewFrame += Video_newFrame;
            device.Start();
            


        }
        private void MenuItemStop_Click(object sender, EventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void Video_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureCam.Image = bit;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                statusBar.Text = "Get file.";
                string subPath = @"./Images";
                bool exists = System.IO.Directory.Exists(subPath);
                if (!exists)
                    System.IO.Directory.CreateDirectory(subPath);

                Guid guid = Guid.NewGuid();
                string filename = subPath + "/" + guid.ToString() + ".jpg";
                if (Rect != null)
                {
                    Bitmap bitmap = new Bitmap(pictureCam.Image, pictureCam.Width, pictureCam.Height);
                    Bitmap cropIng = new Bitmap(Rect.Width, Rect.Height);
                    Graphics g = Graphics.FromImage(cropIng);
                    g.DrawImage(bitmap, 0, 0, Rect, GraphicsUnit.Pixel);
                    // Convert white to black                
                    Bitmap gryImage = InvertGDI(cropIng);
                    gryImage.Save(filename);
                    //TesseractEngine
                    if (System.IO.File.Exists(filename))
                    {
                        statusBar.Text = "OCR in progress...";
                        rtbOcrResult.Clear();
                        using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                        {
                            using (var img = Pix.LoadFromFile(filename))
                            {
                                using (var page = engine.Process(img))
                                {
                                    var text = page.GetText();
                                    rtbOcrResult.Text = text;
                                }
                            }
                        }
                        pictureCrop.Image = System.Drawing.Image.FromFile(filename);
                        pictureCrop.SizeMode = PictureBoxSizeMode.Zoom;
                        statusBar.Text = "OCR completed";
                    }                   
                }

                
                //Delete file
                /*if (System.IO.File.Exists(filename))
                {
                    try
                    {
                        System.IO.File.Delete(filename);

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        statusBar.Text = "Delete file failed";
                    }
                }*/
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                statusBar.Text = "OCR failed";
            }
        }

        private static Bitmap InvertGDI(System.Drawing.Image imgSource)
        {
            Bitmap bmpDest = null;

            using (Bitmap bmpSource = new Bitmap(imgSource))
            {
                bmpDest = new Bitmap(bmpSource.Width, bmpSource.Height);

                for (int x = 0; x < bmpSource.Width; x++)
                {
                    for (int y = 0; y < bmpSource.Height; y++)
                    {

                        Color clrPixel = bmpSource.GetPixel(x, y);

                        clrPixel = Color.FromArgb(255 - clrPixel.R, 255 -
                           clrPixel.G, 255 - clrPixel.B);

                        bmpDest.SetPixel(x, y, clrPixel);
                    }
                }
            }

            return bmpDest;

        }

        
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureCam_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LocationXY = e.Location;
        }

        private void pictureCam_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void pictureCam_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }

        private void pictureCam_Paint(object sender, PaintEventArgs e)
        {
            if(Rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
            }
        }

        private Rectangle GetRect()
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            Rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            Rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            Rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return Rect;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Dialog
            OpenFileDialog openFile = new OpenFileDialog();
            // Image file only
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            // Open Dialog
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Load image
                pictureCam.Image = new Bitmap(openFile.FileName);
                pictureCam.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
