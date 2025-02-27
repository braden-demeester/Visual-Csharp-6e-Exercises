
public class FiveLetterWordTest
{
    private static FiveLetterWord? fiveLetterWord;
    static void Main(string[] args)
    {
        bool continueLoop = true; // Whether to keep looping, i.e. the logic has not yet completed without exception
        while (continueLoop)
        {
            try
            {
                Console.Write("Five-letter word: "); // Prompt the user
                fiveLetterWord = new FiveLetterWord(
                    Console.ReadLine() ?? ""); // Read user input; use an empty string if ReadLine returns null

                // Print the resulting array, joined with ", "
                Console.WriteLine(string.Join(", ", fiveLetterWord.GetThreeLetterPermutations()));


                continueLoop = false;
            }
            catch(ArgumentException ae) // May be thrown when instantiating 'fiveLetterWord'
            {
                Console.WriteLine(ae.Message); // Print the exception's Message to inform user
            }
            catch(Exception ex) // Catch any other potential exceptions
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
