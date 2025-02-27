public class FiveLetterWord
{
    private string word = "";
    public string Word
    {
        get => word;
        private set
        {
            // Ensure the value is five characters long
            if (value.Length != 5)
                throw new ArgumentException("Word must be five letters long!");

            // Ensure the value is only letters
            foreach (char c in value) 
                if (!char.IsLetter(c))
                    throw new ArgumentException("Word must be composed only of letters!");

            word = value;
        }
    }

    /// <summary>
    /// Create an instance of FiveLetterWord
    /// </summary>
    /// <param name="word">The string to be stored as the five-letter word.</param>
    public FiveLetterWord(string word)
    {
        Word = word;
    }

    /// <summary>
    /// Produce all three-letter permutations of the word.
    /// </summary>
    /// <returns>A string array containing the permutations.</returns>
    public string[] GetThreeLetterPermutations()
    {
        string[] permutations = new string[60]; // 60 = (5 permute 3) = 5 * 4 * 3

        int index = 0; // Used to index the array permutations

        for (int i = 0; i < 5; i++) // Index for first character of a three-letter combination
            for (int j = 0; j < 5; j++) // Index for second character
                for (int k = 0; k < 5; k++) // Index for third character
                    if (i != j && j != k && i != k) // Ensure that the indexes are all unique since we're selecting without replacement
                        permutations[index++] = new string( // Set permutations[index] to the new string, and incremend index
                            [ word[i], word[j], word[k] ]); // Create a char[] to convert into a string
        
        return permutations;
    }
}
