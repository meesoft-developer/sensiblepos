using System;
using System.Drawing;
using System.IO;

namespace SensiblePOS.Utilities
{
    public static class ImageTools
    {
        public static Image GetImage(byte[] byteArrayIn)
        {
            Image result = null;
            if (byteArrayIn == null || byteArrayIn.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                result = Image.FromStream(ms);
            }
            return result;
        }

        public static byte[] GetByteArray(Image imageIn)
        {
            if (imageIn == null)
            {
                return new byte[] { };
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var bytes = ms.ToArray();
                    return bytes;
                }
            }
            catch (Exception ex)
            {
                return new byte[] { };
            }
        }
    }
}
