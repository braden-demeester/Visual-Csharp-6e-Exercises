using System;

// Sphere class
public class Sphere : ThreeDimensionalShape // extends ThreeDimensionalShape
{
    // Instance variable and property for the sphere's radius
    private double radius;
    public double Radius
    {
        get => radius;
        set
        {
            // Ensure the value is nonnegative
            if(value < 0.0)
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Radius)} must be >= 0.");

            radius = value;
        }
    }

    // Override the abstract read-only Area property from ThreeDimensionalShape
    public override double Area
    {
        // Calculate the sphere's surface area
        get => 4.0 * Math.PI * Radius * Radius;
    }

    // Override the abstract read-only Volume property from ThreeDimensionalShape
    public override double Volume
    {
        // Calculate the sphere's volume
        get => 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
    }

    /// <summary>
    /// Creates an instance of Sphere.
    /// </summary>
    /// <param name="radius">The radius of the Sphere</param>
    public Sphere(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// String representation specifies type of 3D shape, and the radius.
    /// </summary>
    /// <returns></returns>
    public override string ToString() =>
        $"{base.ToString()}: Sphere, radius {Radius}";

}
