using System;
using static System.Math;
using NUnit.Framework;

namespace Manipulation
{
    public class TriangleTask
    {
        public static double GetABAngle(double a, double b, double c)
        {
            var cosinus = (a * a + b * b - c * c) / (2 * a * b);
            return (a + b >= c && a + c >= b && b + c >= a)
                    ? Acos(cosinus)
                    : double.NaN;
        }
    }

    [TestFixture]
    public class TriangleTask_Tests
    {
        [TestCase(3, 4, 5, PI / 2)]
        [TestCase(1, 1, 1, PI / 3)]
        [TestCase(0, 0, 0, double.NaN)]
        [TestCase(-1, 3, 4, double.NaN)]
        [TestCase(1, 1, 1000, double.NaN)]
        public void TestGetABAngle(double a, double b, double c, double expectedAngle)
        {
            Assert.AreEqual(expectedAngle, TriangleTask.GetABAngle(a, b, c), 1e+10);
        }
    }
}

