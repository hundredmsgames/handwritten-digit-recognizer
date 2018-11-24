using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwrittenDigitRecognizer.CNN.Helpers
{
    static class PreProcessing
    {
        static public Bitmap MedianSmoothing(Bitmap image,int kernelSize)
        {
            Bitmap proccessedImage = new Bitmap(image.Width, image.Height);

            int[] kernelValues = new int[kernelSize * kernelSize];
            for (int i = 0; i < proccessedImage.Height; i++)
            {
                for (int j = 0; j < proccessedImage.Width; j++)
                {
                    if (i + kernelSize > proccessedImage.Height || j + kernelSize > proccessedImage.Width)
                        continue;
                    for (int x = 0; x < kernelSize; x++)
                    {
                        for (int y = 0; y < kernelSize; y++)
                        {
                            kernelValues[kernelSize * x + y] = image.GetPixel(i + x, j + y).R;
                        }
                    }
                    int median = kernelValues.OrderBy(x => x).ElementAt((kernelSize / 2)+1);
                    proccessedImage.SetPixel(i + 1, j + 1, Color.FromArgb(median, median, median));
                }
            }






            return proccessedImage;
        }
    }
}
