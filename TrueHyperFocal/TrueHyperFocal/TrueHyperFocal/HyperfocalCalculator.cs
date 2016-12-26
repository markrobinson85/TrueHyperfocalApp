using System;

namespace TrueHyperFocal
{
    public class HyperfocalCalculator
    {
        public HyperfocalCalculator()
        {
        }

        public decimal Calculate(decimal focalLength, decimal distance, decimal fStop)
        {
            if (focalLength == 0)
                return 0;

            decimal result = 1 / (((1 / focalLength) - (1 / (focalLength + ((fStop * fStop) / 750)))) * distance);

            return Math.Round(result, 2);
        }
    }
}