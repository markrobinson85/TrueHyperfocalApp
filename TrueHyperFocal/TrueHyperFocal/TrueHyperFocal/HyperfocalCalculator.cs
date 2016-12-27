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

        public decimal CalculateFromStrings(string focalLengthString, string distanceString, string fStopString)
        {
            decimal focalLength;
            decimal distance;
            decimal fStop;

            if ((string.IsNullOrEmpty(focalLengthString)) ||
                (string.IsNullOrEmpty(distanceString)) ||
                (string.IsNullOrEmpty(fStopString)))
                return 0;

            if ((!Decimal.TryParse(focalLengthString, out focalLength)) ||
                (!Decimal.TryParse(distanceString, out distance)) ||
                (!Decimal.TryParse(fStopString, out fStop)))
                return 0;

            if (focalLength == 0)
                return 0;

            decimal result = 1 / (((1 / focalLength) - (1 / (focalLength + ((fStop * fStop) / 750)))) * distance);

            return Math.Round(result, 2);

        }
    }
}