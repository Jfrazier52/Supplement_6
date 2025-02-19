namespace Supplement_6
{
    /// <summary>
    /// Represents an abstract 3D shape.
    /// </summary>
    public abstract class Shape3D
    {
        /// <summary>
        /// Calculates the volume of the shape.
        /// </summary>
        /// <returns>The volume as a double.</returns>
        public abstract double GetVolume();

        /// <summary>
        /// Calculates the surface area of the shape.
        /// </summary>
        /// <returns>The surface area as a double.</returns>
        public abstract double GetSurfaceArea();
 
        /// <summary>
        /// Provides a string identifying the shape name, its surface area, and volume.
        /// </summary>
        /// <returns>A formatted string containing shape details.</returns>
        public abstract string Dump();
    }
}

}
