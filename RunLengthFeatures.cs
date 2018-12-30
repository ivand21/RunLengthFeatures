using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLFImageClassification
{
    public class RunLengthFeatures
    {
        private IDictionary<int, int[]> primitives;
        private int primitivesCount;

        public RunLengthFeatures(IDictionary<int, int[]> primitives)
        {
            this.primitives = primitives;
            primitivesCount = CountPrimitives();
        }

        public double ShortPrimitiveEmphasis()
        {
            double sum = 0.0;
            foreach (var p in primitives)
            {
                int length = p.Key;
                double lengthPower = length * length;
                foreach (var v in p.Value)
                {
                    sum += v / lengthPower;
                }
            }
            return sum / primitivesCount;
        }

        public double LongPrimitiveEmphasis()
        {
            double sum = 0.0;
            foreach (var p in primitives)
            {
                int length = p.Key;
                double lengthPower = Math.Pow(length, 2);
                foreach (var v in p.Value)
                {
                    sum += v * lengthPower;
                }
            }
            return sum / primitivesCount;
        }

        public double GrayLevelUniformity()
        {
            double sum = 0.0;
            double grayscaleSum = 0.0;
            for (int i = 0; i < ImageProcessor.GRAYSCALE_RANGE_COUNT; i++)
            {
                foreach (var p in primitives)
                {
                    grayscaleSum += p.Value[i];
                }
                sum += Math.Pow(grayscaleSum, 2);
            }
            return sum / primitivesCount;
        }

        public double PrimitiveLengthUniformity()
        {
            double sum = 0.0;
            foreach (var p in primitives)
            {
                double lengthSum = p.Value.Sum();
                sum += Math.Pow(lengthSum, 2);
            }
            return sum / primitivesCount;
        }

        public double PrimitivePercentage()
        {
            double sum = 0.0;
            foreach (var p in primitives)
            {
                int length = p.Key;
                foreach (var v in p.Value)
                {
                    sum += v * length;
                }
            }
            return primitivesCount / sum;
        }

        private int CountPrimitives()
        {
            int sum = 0;
            foreach (var p in primitives)
            {
                sum += p.Value.Sum();
            }
            return sum;
        }

    }
}
