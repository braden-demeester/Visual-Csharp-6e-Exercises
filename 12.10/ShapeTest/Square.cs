using System;

// Square class
public class Square : TwoDimensionalShape // extends TwoDimensionalShape
{
    // Instance variable and property for the square's side length
    private double sideLength;
    public double SideLength
    {
        get => sideLength;
        set
        {
            // Ensure the value is nonnegative
            if(value < 0.0)
                throw new ArgumentOutOfRangeException(nameof(value), value,
                    $"{nameof(SideLength)} must be >= 0.");

            sideLength = value;
        }
    }

    // Override the abstract read-only Area property from TwoDimensionalShape
    public override double Area
    {
        // Calculate the square's area
        get => SideLength * SideLength;
    }

    /// <summary>
    /// Creates an instance of Square.
    /// </summary>
    /// <param name="sideLength">The side length of the Square</param>
    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    /// <summary>
    /// String representation specifies type of 2D shape, and the side length.
    /// </summary>
    /// <returns></returns>
    public override string ToString() =>
        $"{base.ToString()}: Square, side length {SideLength}";
}
