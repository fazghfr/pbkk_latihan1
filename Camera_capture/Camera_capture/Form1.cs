using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics.Tracing;

namespace Camera_capture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in captureDevice)
            {
                cbCam.Items.Add(item.Name);
            }
            cbCam.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pbLive.Image = null;
                pbLive.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[cbCam.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap scaledFrame = new Bitmap(frame, pbLive.Width, pbLive.Height);
            pbLive.Image = scaledFrame;

            frame.Dispose();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pbLive.Image = null;
                pbLive.Invalidate();
            }
            Application.Exit(null);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Bitmap frame = (Bitmap)pbLive.Image.Clone();
            Bitmap scaledFrame = new Bitmap(frame, pbCaptured.Width, pbCaptured.Height);
            pbCaptured.Image = scaledFrame;

            frame.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save file as";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg *.png";
            ImageFormat format = ImageFormat.Png;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                pbCaptured.Image.Save(saveFileDialog.FileName, format); 
            }
        }
    }
}
