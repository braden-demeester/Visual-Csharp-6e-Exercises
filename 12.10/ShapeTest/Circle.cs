using System;

// Circle class
public class Circle : TwoDimensionalShape // extends TwoDimensionalShape
{
    // Instance variable and property for the circle's radius
    private double radius;
    public double Radius
    {
        get => radius;
        set
        {
            // Ensure the value is nonnegative
            if (value < 0.0)
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(Radius)} must be >= 0.");

            radius = value;
        }
    }

    // Override the abstract read-only Area property from TwoDimensionalShape
    public override double Area
    {
        // Calculate the circle's area
        get => Math.PI * Radius * Radius;
    }

    /// <summary>
    /// Creates an instance of Circle.
    /// </summary>
    /// <param name="radius">The radius of the Circle</param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// String representation specifies type of 2D shape, and the radius.
    /// </summary>
    /// <returns></returns>
    public override string ToString() =>
        $"{base.ToString()}: Circle, radius {Radius}";
}
