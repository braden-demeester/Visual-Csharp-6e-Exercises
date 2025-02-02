public class MilesPerGallonCalculator
{
    private static double milesDriven, gallonsUsed;

    public static void Main(string[] args)
    {
        bool continueLoop = true;
        while (continueLoop)
        {
            try
            {
                Console.Write("Miles Driven: ");
                milesDriven = double.Parse(Console.ReadLine() ?? "");

                Console.Write("Gallons Used: ");
                gallonsUsed = double.Parse(Console.ReadLine() ?? "");

                Console.WriteLine($"\nMiles Per Gallon: {milesDriven / gallonsUsed:F3}");

                continueLoop = false;
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"{fe.Message} Must be a double!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}