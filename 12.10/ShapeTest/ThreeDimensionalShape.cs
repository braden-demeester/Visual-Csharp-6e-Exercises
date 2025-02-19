
// Base class for all 3D shapes
public abstract class ThreeDimensionalShape : Shape // extends Shape
{
    /// <summary>
    /// Abstract read-only property for surface area.
    /// Must be defined in each derived class
    /// </summary>
    public abstract double Area { get; }

    /// <summary>
    /// Abstract read-only property for volume.
    /// Must be defined in each derived class
    /// </summary>
    public abstract double Volume { get; }

    public ThreeDimensionalShape() { }

    /// <summary>
    /// Generic string representation for a 3D shape.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"Three-dimensional {base.ToString()}";
}
