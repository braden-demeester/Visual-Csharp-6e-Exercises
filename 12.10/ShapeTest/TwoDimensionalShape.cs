// Base class for all 2D shapes
public abstract class TwoDimensionalShape : Shape // extends Shape
{
    /// <summary>
    /// Abstract read-only property for area.
    /// Must be defined in each derived class
    /// </summary>
    public abstract double Area { get; }
    
    public TwoDimensionalShape() { }

    /// <summary>
    /// Generic string representation for a 2D shape.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"Two-dimensional {base.ToString()}";
}
