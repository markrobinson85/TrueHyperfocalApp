using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrueHyperFocal;

namespace TrueHyperFocal.Tests
{
    [TestClass]
    public class Hyperfocal
    {
        decimal focalLength = 0;
        decimal distance = 0;
        decimal fStop = 0;

        [TestMethod]
        public void Hyperfocal_Zero_TestMethod()
        {
            // because dividing by zero is bad.
            var calc = new HyperfocalCalculator();

            var result = calc.Calculate(focalLength, distance, fStop);

            Assert.AreEqual(result.GetType(), typeof(decimal));
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Hyperfocal_Calculate_TestMethod()
        {
            focalLength = (decimal)50;
            distance = (decimal)304.8;
            fStop = (decimal)11.2;
            // Result should equal 49.20.

            var calc = new HyperfocalCalculator();

            var result = calc.Calculate(focalLength, distance, fStop);

            Assert.AreEqual(result, (decimal)49.20);
        }

        [TestMethod]
        public void Hyperfocal_EmptyStrings_TestMethod()
        {
            string focalLengthString = "";
            string distanceString = "";
            string fStopString = "";

            var calc = new HyperfocalCalculator();

            var result = calc.CalculateFromStrings(focalLengthString, distanceString, fStopString);

            Assert.AreEqual(result.GetType(), typeof(decimal));
            Assert.AreEqual(result, 0);

        }

        [TestMethod]
        public void Hyperfocal_CalculateFromStrings_TestMethod()
        {
            string focalLengthString = "50";
            string distanceString = "304.8";
            string fStopString = "11.2";

            var calc = new HyperfocalCalculator();

            var result = calc.CalculateFromStrings(focalLengthString, distanceString, fStopString);

            Assert.AreEqual(result.GetType(), typeof(decimal));
            Assert.AreEqual(result, (decimal)49.20);
        }
    }
}