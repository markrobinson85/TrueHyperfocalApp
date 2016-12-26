﻿using System;
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


    }
}