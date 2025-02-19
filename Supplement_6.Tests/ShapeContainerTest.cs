using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class ShapeContainerTests
    {
        // Create a dummy shape for testing purposes.
        private class DummyShape : Shape3D
        {
            public override double GetVolume() => 0;
            public override double GetSurfaceArea() => 0;
            public override string Dump() => "DummyShape";
        }

        [TestMethod]
        public void Create_AddsShapeToContainer()
        {
            var container = new ShapeContainer();
            var shape = new DummyShape();
            
            container.Create(shape);
            var retrieved = container.Get(0);
            
            
            Assert.IsNotNull(retrieved);
            Assert.AreEqual("DummyShape", retrieved.Dump());
        }

        [TestMethod]
        public void Delete_RemovesShapeSuccessfully()
        {
    
            var container = new ShapeContainer();
            var shape = new DummyShape();
            container.Create(shape);

        
            bool result = container.Delete(0);

        
            Assert.IsTrue(result);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => container.Get(0));
        }
    }
}
