using Supplement_5;

namespace Supplement_5
{
    public class Sphere : Shape3D
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
            Validate();
        }

        private void Validate()
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater than 0.");
            }
        }

        public override double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override double GetSurfaceArea()
        {
            return 4 * Math.PI * radius * radius;
        }

        public override string Dump()
        {
            return $"Sphere: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
        }
    }
}

