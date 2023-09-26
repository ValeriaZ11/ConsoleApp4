using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TrapezoidTests
    {
        /// <summary>
        /// Хорошие тесты
        /// </summary>
        /// <param name="topBase"></param>
        /// <param name="bottomBase"></param>
        /// <param name="height"></param>
        /// <param name="expectedSquare"></param>

        [TestMethod()]
        [DataRow(5, 8, 4, 26)]
        [DataRow(15, 27, 14, 294)]

        public void CalculateSquareTest(double topBase, double bottomBase, double height, double expectedSquare)
        {
            // Arrange
            Trapezoid trapezoid = new Trapezoid(topBase, bottomBase, height);

            // Act
            double actualSquare = trapezoid.CalculateSquare();

            // Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        /// <summary>
        /// Плохие тесты
        /// </summary>
        /// <param name="baseLength"></param>
        /// <param name="baseWidth"></param>
        /// <param name="height"></param>
        /// <param name="expectedVolume"></param>
        [TestMethod()]
        [DataRow(20, -23, 14, 0)]
        [ExpectedException(typeof(ArgumentException))]

        public void CalculateVolumeTest_negative(double topBase, double bottomBase, double height, double expectedSquare)
        {
            // Arrange
            Trapezoid trapezoid = new Trapezoid(topBase, bottomBase, height);

            // Act
            double actualSquare = trapezoid.CalculateSquare();

            // Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }

    }
}