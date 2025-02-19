using System.Collections.Generic;

namespace Supplement_6
{
    public class ShapeContainer
    {
        private List<Shape3D> shapes = new List<Shape3D>();

        public void Create(Shape3D shape)
        {
            shapes.Add(shape);
        }

        public Shape3D Get(int index)
        {
            return shapes[index];
        }
    }
}
