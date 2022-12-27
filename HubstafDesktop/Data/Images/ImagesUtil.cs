using GI.Screenshot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MessageBox;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Diagnostics;
using Simple.ImageResizer;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace HubstafDesktop.Data.Images
{
    public static class ImagesUtil
    {
        public static Byte[] takeScreenshoot()
        {
           

            // Get the bounds of the primary screen
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            // Create a bitmap to hold the screenshot
            Bitmap screenshot = new Bitmap(screenBounds.Width, screenBounds.Height);

            // Create a Graphics object from the bitmap
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                // Copy the screen contents to the bitmap
                g.CopyFromScreen(screenBounds.Location, Point.Empty, screenshot.Size);
            }

            // Convert the bitmap to a byte array
            using (MemoryStream stream = new MemoryStream())
            {
                screenshot.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }

            //var screenshoot = Screenshot.CaptureAllScreens();
            //return ConvertBitmapSourceToByteArray(screenshoot);
        }

        public static byte[] ConvertBitmapSourceToByteArray(BitmapSource image)
        {
            byte[] data;
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }


        public static MemoryStream convertByteArrayToImgStream(Byte[] imgData)
        {
            MemoryStream imgStream = new MemoryStream(imgData);
            return imgStream;
        }



        public static void ShowSsResult(byte[] imageData)
        {
            //byte[] imageData = TakeScreenshot();
            var screenshotForm = new SsForm(imageData);
            screenshotForm.Show();
        }
    }

}
