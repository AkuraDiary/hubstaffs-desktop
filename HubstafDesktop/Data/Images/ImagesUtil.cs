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

namespace HubstafDesktop.Data.Images
{
    public static class ImagesUtil
    {
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
    }

}
