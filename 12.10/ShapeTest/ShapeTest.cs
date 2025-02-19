using System;
public class ShapeTest
{
    static void Main(string[] args)
    {
        bool continueLoop = true; 
        // continueLoop is true if the logic in the try block has not completed without exception.
        // In this case we want to continue the while loop.

        while(continueLoop)
        {
            try
            {
                // Get user inputs for the variables
                // Each double.Parse will throw a FormatException if the line read is not parsable as a double
                Console.Write("Circle radius: ");
                double circleRadius = double.Parse(Console.ReadLine());

                Console.Write("Square side length: ");
                double squareSideLength = double.Parse(Console.ReadLine());

                Console.Write("Sphere radius: ");
                double sphereRadius = double.Parse(Console.ReadLine());

                Console.Write("Cube edge length: ");
                double cubeEdgeLength = double.Parse(Console.ReadLine());


                // Create an array of Shapes with the user-inputted values
                // The constructors will throw an ArgumentOutOfRangeException if the value given is negative
                Shape[] shapes =
                {
                    new Circle(circleRadius),
                    new Square(squareSideLength),
                    new Sphere(sphereRadius),
                    new Cube(cubeEdgeLength)
                };

                // Loop through the array of shapes
                foreach (Shape shape in shapes)
                {
                    // Print each shape's string representation
                    Console.WriteLine(shape.ToString());

                    // Check if shape is a derived class from TwoDimensionalShape
                    if (shape is TwoDimensionalShape)
                    {
                        // If so, we want to print its area (Area property)
                        Console.WriteLine($"{shape.GetType()} area: {(shape as TwoDimensionalShape).Area:F3}");
                    }
                    // Otherwise, ensure the shape is a ThreeDimensionalShape
                    else if (shape is ThreeDimensionalShape)
                    {
                        // If so, we want to print its surface area (Area property)
                        // and its volume (Volume property)
                        Console.WriteLine(
                            $"{shape.GetType()} surface area: {(shape as ThreeDimensionalShape).Area:F3}");
                        Console.WriteLine(
                            $"{shape.GetType()} volume: {(shape as ThreeDimensionalShape).Volume:F3}");
                    }
                    // Print an empty line to space things out for readability
                    Console.WriteLine("");

                }

                continueLoop = false;
            }
            catch(FormatException fe) // Catch exceptions from double.Parse
            {
                Console.WriteLine($"{fe.Message} Must be a number!");
            }
            catch(ArgumentOutOfRangeException aoore) // Catch exceptions from shape constructors
            {
                Console.WriteLine(aoore.Message);
            }
            catch (Exception ex) // Catch any other exceptions
            {
                Console.WriteLine(ex);
            }
        }
    }
}
