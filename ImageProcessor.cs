using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLFImageClassification
{
    public class ImageProcessor
    {
        public Bitmap Image { get; set; }
        public const int GRAYSCALE_RANGE_SIZE = 32;
        public const int GRAYSCALE_RANGE_COUNT = 256 / GRAYSCALE_RANGE_SIZE;

        public ImageProcessor(Bitmap bmp)
        {
            Image = bmp;
        }

        public IEnumerable<int> GetDistinctPrimitiveLengths(Dictionary<int, int[]> primitives)
        {
            return primitives.Keys.ToList();
        }

        public IDictionary<int, int[]> FindPrimitives()
        {
            var primitives = new Dictionary<int, int[]>();
            FindVertically(primitives);
            FindHorizontally(primitives);

            return primitives;
        }

        private void FindVertically(Dictionary<int, int[]> primitives)
        {
            int grayscale = -1, previousGrayscale = -1;
            int primitiveLength = 0;

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    grayscale = GetPixelGrayscale(x, y);
                    if (y == 0 || grayscale != previousGrayscale)
                    {
                        if (primitiveLength > 0)
                        {
                            SavePrimitive(primitives, primitiveLength, previousGrayscale);
                        }
                        previousGrayscale = grayscale;
                        primitiveLength = 0;
                    }
                    primitiveLength++;
                }
            }

            // last pixel
            SavePrimitive(primitives, primitiveLength, grayscale);
        }

        private void FindHorizontally(Dictionary<int, int[]> primitives)
        {
            int grayscale = -1, previousGrayscale = -1;
            int primitiveLength = 0;

            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    grayscale = GetPixelGrayscale(x, y);
                    if (x == 0 || grayscale != previousGrayscale)
                    {
                        if (primitiveLength > 0)
                        {
                            SavePrimitive(primitives, primitiveLength, previousGrayscale);
                        }
                        previousGrayscale = grayscale;
                        primitiveLength = 0;
                    }
                    primitiveLength++;
                }
            }

            // last pixel
            SavePrimitive(primitives, primitiveLength, grayscale);
        }

        private int GetPixelGrayscale(int x, int y)
        {
            Color pixel = Image.GetPixel(x, y);
            int avg = (pixel.R + pixel.G + pixel.B) / 3;
            return avg / GRAYSCALE_RANGE_SIZE;
        }

        private void SavePrimitive(Dictionary<int,int[]> primitives, int length, int grayscale)
        {
            if (primitives.ContainsKey(length))
            {
                primitives[length][grayscale]++;
            }
            else
            {
                int[] grayscales = new int[GRAYSCALE_RANGE_COUNT];
                grayscales[grayscale]++;
                primitives.Add(length, grayscales);
            }
        }
    }
}
