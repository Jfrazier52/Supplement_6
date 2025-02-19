using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using namespace Supplement_6
{};

[TestClass]
public class ShapeContainerTests
{
    [TestMethod]
    public void Create_ShouldStoreShape ()
    {
        var container = new ShapeContainer();
        var shape = new Cube(5);
      
        container.Create(shape);
        var retrievedShape = container.Get(0);

        Assert.AreEqual(shape, retrievedShape); 
    }
}
