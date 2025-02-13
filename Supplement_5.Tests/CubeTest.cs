using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Supplement_5; // Namespace of your shape classes

namespace Supplement_5.Tests
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void Cube_CalculatesVolumeCorrectly()
        {
            double side = 3;
            Cube cube = new Cube(side);
            double expectedVolume = 27; // 3^3

            double volume = cube.GetVolume();

            
            Assert.AreEqual(expectedVolume, volume, 0.001);
        }

        [TestMethod]
        public void Cube_CalculatesSurfaceAreaCorrectly()
        {
            double side = 3;
            Cube cube = new Cube(side);
            double expectedSurfaceArea = 54; // 6 * (3^2)

            double surfaceArea = cube.GetSurfaceArea();

            Assert.AreEqual(expectedSurfaceArea, surfaceArea, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cube_InvalidSide_ThrowsException()
        {
            Cube cube = new Cube(0); // side is 0, should throw exception
        }
    }
}