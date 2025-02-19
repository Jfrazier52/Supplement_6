using System;

namespace Supplement_5
{
    public class Cylinder : Shape3D
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
            Validate();
        }

        private void Validate()
        {
            if (radius <= 0 || height <= 0)
            {
                throw new ArgumentException("Radius and Height must be greater than 0.");
            }
        }

        public override double GetVolume()
        {
            return Math.PI * radius * radius * height;
        } 

        public override double GetSurfaceArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        public override string Dump()
        {
            return $"Cylinder: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
        }
    }
}
