using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Supplement_5;

namespace Supplement_5.Tests
{
    [TestClass]
    public class CylinderTests
    {
        [TestMethod]
        public void Cylinder_CalculatesVolumeCorrectly()
        {
           
            double radius = 3;
            double height = 5;
            Cylinder cylinder = new Cylinder(radius, height);
            double expectedVolume = Math.PI * radius * radius * height;

            double volume = cylinder.GetVolume();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedVolume, volume, 0.001);
        }

        [TestMethod]
        public void Cylinder_CalculatesSurfaceAreaCorrectly()
        {
            double radius = 3;
            double height = 5;
            Cylinder cylinder = new Cylinder(radius, height);
            double expectedSurfaceArea = 2 * Math.PI * radius * (radius + height);

            double surfaceArea = cylinder.GetSurfaceArea();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedSurfaceArea, surfaceArea, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cylinder_InvalidDimensions_ThrowsException()
        {
            Cylinder cylinder = new Cylinder(0, 5); // invalid radius
        }
    }

    internal class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        internal double GetSurfaceArea()
        {
            throw new NotImplementedException();
        }

        internal double GetVolume()
        {
            throw new NotImplementedException();
        }
    }
}
