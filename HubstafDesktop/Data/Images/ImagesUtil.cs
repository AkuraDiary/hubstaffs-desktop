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
using System.IO.Compression;

namespace HubstafDesktop.Data.Images
{
    public static class ImagesUtil
    {

        #region fuck you 125% scale
        //public static Byte[] takeScreenshoot()
        //{


        //    // Create a list to hold the screenshots of all screens
        //    List<Bitmap> screens = new List<Bitmap>();

        //    // Get the bounds of all screens
        //    Rectangle[] screenBounds = Screen.AllScreens.Select(s => s.Bounds).ToArray();

        //    // Take a screenshot of each screen
        //    foreach (Rectangle bounds in screenBounds)
        //    {
        //        // Create a bitmap to hold the screenshot
        //        Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);

        //        // Create a Graphics object from the bitmap
        //        using (Graphics g = Graphics.FromImage(screenshot))
        //        {
        //            // Copy the screen contents to the bitmap
        //            g.CopyFromScreen(bounds.Location, Point.Empty, screenshot.Size);
        //        }

        //        // Add the screenshot to the list
        //        screens.Add(screenshot);
        //    }

        //    // Combine the screenshots into a single image
        //    Bitmap combined = CombineBitmaps(screens);

        //    // Convert the combined image to a byte array
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        combined.Save(stream, ImageFormat.Png);
        //        return stream.ToArray();
        //    }
        //    //ScreenshotOptions ssOption = new ScreenshotOptions()
        //    //var screenshoot = Screenshot.CaptureRegion(ssOption.SelectionRectangleBorderBrush);
        //    //return ConvertBitmapSourceToByteArray(screenshoot);
        //}

        private static Bitmap CombineBitmaps(List<Bitmap> images)
        {
            // Calculate the size of the combined image
            int width = images.Max(i => i.Width);
            int height = images.Sum(i => i.Height);

            // Create a bitmap to hold the combined image
            Bitmap combined = new Bitmap(width, height);

            // Create a Graphics object from the bitmap
            using (Graphics g = Graphics.FromImage(combined))
            {
                // Set the background color to transparent
                g.Clear(Color.Transparent);

                // Draw each image on the combined image
                int y = 0;
                foreach (Bitmap image in images)
                {
                    g.DrawImage(image, 0, y);
                    y += image.Height;
                }
            }

            return combined;
        }
        #endregion

        public static Byte[] takeScreenshoot()
        {
            var screenshoot = Screenshot.CaptureAllScreens();
            return ConvertBitmapSourceToByteArray(screenshoot);
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

        public static Byte[] deCompressImage(Byte[] imageData)
        {
            // Create a memory stream for the input data
            using (MemoryStream inputStream = new MemoryStream(imageData))
            {
                // Use the GZipStream to decompress the data
                using (GZipStream decompressor = new GZipStream(inputStream, CompressionMode.Decompress))
                {
                    // Create a memory stream for the output data
                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        // Copy the data from the decompressor to the output stream
                        decompressor.CopyTo(outputStream);

                        // The decompressed data is now in the output stream
                        byte[] output = outputStream.ToArray();
                        return output;
                    }
                }
            }
        }
        public static Byte[] compressImage(Byte[] imageData)
        {
            // Create a memory stream for the output data
            using (MemoryStream outputStream = new MemoryStream())
            {
                // Use the GZipStream to compress the data
                using (GZipStream compressor = new GZipStream(outputStream, CompressionMode.Compress))
                {
                    // Create a memory stream for the input data
                    using (MemoryStream inputStream = new MemoryStream(imageData))
                    {
                        // Copy the data from the input stream to the compressor
                        inputStream.CopyTo(compressor);
                    }
                }

                // The compressed data is now in the output stream
                return outputStream.ToArray();

                //MemoryStream imgStream = new MemoryStream(imageData);
                //MemoryStream outputStream = new MemoryStream();

                //GZipStream compressor = new GZipStream(outputStream, CompressionMode.Compress);

                //imgStream.CopyTo(compressor);

                //return outputStream.ToArray();

            }
        }

    }
}
