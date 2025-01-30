
namespace RectangleTest
{
    internal class Rectangle
    {
        // Instance variable length, defaults to 1
        private float length = 1f;
        public float Length // Property associated with length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0f && value < 20f)
                    length = value; // Only update length if provided value is greater than 0 and less than 20
                else // If the value is invalid, inform user
                    Console.WriteLine("Error: Length must be greater than 0 and less than 20. Value not updated.");
            }
        }

        // Instance variable width, defaults to 1
        private float width = 1f;
        public float Width // Property associated with width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0f && value < 20f)
                    width = value; // Only update width if provided value is greater than 0 and less than 20
                else // If the value is invalid, inform user
                    Console.WriteLine("Error: Width must be greater than 0 and less than 20. Value not updated.");
            }
        }

        // Read-only (getter-only) property for the rectangle's perimeter
        public float Perimeter
        {
            get // Calculates and returns the perimeter
            {
                return 2 * Length + 2 * Width;
            }
        }

        // Read-only (getter-only) property for the rectangle's area
        public float Area
        {
            get // Calculates and returns the area
            {
                return Length * Width;
            }
        }


        // Constructor
        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }
    }
}
