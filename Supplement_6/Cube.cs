using Supplement_5;

namespace Supplement_5
{
     public class Cube : Shape3D
    {
        private double side;

        public Cube(double side)
        {
            this.side = side;
            Validate();
        }

        private void Validate()
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side length must be greater than 0.");
            }
        }

        public override double GetVolume()
        {
            return side * side * side;
        }

        public override double GetSurfaceArea()
        {
            return 6 * side * side;
        }

        public override string Dump()
        {
            return $"Cube: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
        }
    }
}
