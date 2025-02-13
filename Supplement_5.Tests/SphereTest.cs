using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Supplement_5;

namespace Supplement_5.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Sphere_CalculatesVolumeCorrectly()
        {
            // Arrange
            double radius = 3;
            Sphere sphere = new Sphere(radius);
            double expectedVolume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            // Act
            double volume = sphere.GetVolume();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedVolume, volume, 0.001);
        }

        [TestMethod]
        public void Sphere_CalculatesSurfaceAreaCorrectly()
        {
            // Arrange
            double radius = 3;
            Sphere sphere = new Sphere(radius);
            double expectedSurfaceArea = 4 * Math.PI * radius * radius;

            // Act
            double surfaceArea = sphere.GetSurfaceArea();

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedSurfaceArea, surfaceArea, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sphere_InvalidRadius_ThrowsException()
        {
            // Arrange & Act
            Sphere sphere = new Sphere(0); // invalid radius
        }
    }
}
