using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WEI_SSMS_COMMON
{
    public static class ImageHepler
    {

        public static BitmapImage InitLizeImage(string path)
        {
            try 
            {
                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.BeginInit();
                //myBitmapImage.UriSource = new Uri(@"F:\TestImage\1.jpg");
                myBitmapImage.UriSource = new Uri(path);
                myBitmapImage.DecodePixelWidth = 200;
                myBitmapImage.EndInit();
                return myBitmapImage;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
    }
}
