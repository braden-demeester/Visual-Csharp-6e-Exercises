using System;

// Cube class
public class Cube : ThreeDimensionalShape // extends ThreeDimensionalShape
{
    // Instance variable and property for edge length
    private double edgeLength;
    public double EdgeLength
    {
        get => edgeLength;
        set
        {
            // Ensure the value is nonnegative
            if (value < 0.0)
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(EdgeLength)} must be >= 0.");

            edgeLength = value;
        }
    }

    // Override the abstract read-only Area property from ThreeDimensionalShape
    public override double Area
    {
        // Calculate the cube's surface area
        get => 6.0 * EdgeLength * EdgeLength;
    }

    // Override the abstract read-only Volume property from ThreeDimensionalShape
    public override double Volume
    {
        // Calculate the cube's volume
        get => EdgeLength * EdgeLength * EdgeLength;
    }

    /// <summary>
    /// Creates an instance of Cube.
    /// </summary>
    /// <param name="edgeLength">The edge length of the Cube</param>
    public Cube(double edgeLength)
    {
        EdgeLength = edgeLength;
    }

    /// <summary>
    /// String representation specifies type of 3D shape, and the edge length.
    /// </summary>
    /// <returns></returns>
    public override string ToString() =>
        $"{base.ToString()}: Cube, edge length {EdgeLength}";

}
