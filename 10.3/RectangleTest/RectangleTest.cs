using System;

namespace RectangleTest
{
    internal class RectangleTest
    {
        // Variables; will be initialized in Main
        private static float length, width;
        private static Rectangle? rectangle;

        // Entry point
        static void Main(string[] args)
        {
            while(!float.TryParse(Prompt("Length: "), out length)) // Prompt user input for length until provided value is a float
            {
                Console.WriteLine("Length must be a float!"); // Inform user when they do not provide a float
            }
            while (!float.TryParse(Prompt("Width: "), out width)) // Prompt user input for width until provided value is a float
            {
                Console.WriteLine("Width must be a float!"); // Inform user when they do not provide a float
            }

            // Create an instance of the Rectangle class using the user-provided length & width
            rectangle = new Rectangle(length, width);

            // Print perimeter and area
            Console.WriteLine($"Perimeter: {rectangle.Perimeter} unit{(rectangle.Perimeter != 1.0f ? "s" : "")}");
            Console.WriteLine($"Area: {rectangle.Area} square unit{(rectangle.Area != 1.0f ? "s" : "")}");

        }

        // Prints provided string and returns user input
        private static string Prompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine() ?? ""; // If ReadLine returns null, return an empty string
        }
    }
}
