using System;
using System.Collections.Generic;

namespace NEWSUP6
{
    public class ShapeContainer
    {
        private readonly List<Shape3D> shapes = new List<Shape3D>();

        /// <summary>
        /// Adds a new Shape3D to the container.
        /// </summary>
        /// <param name="shape">The shape to add.</param>
        public void Create(Shape3D shape)
        {
            shapes.Add(shape);
        }

        public Shape3D Get(int index)
        {
            if (index < 0 || index >= shapes.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            return shapes[index];
        }


        public bool Delete(int index)
        {
            if (index < 0 || index >= shapes.Count)
            {
                return false;
            }
            shapes.RemoveAt(index);
            return true;
        }
    }
}
