using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TelephoneNumberWordGenerator
{
    public class TelephoneNumberToWords
    {
        // Dictionary to map a digit to the corresponding letters
        private static Dictionary<char, char[]> DigitToLettersMap { get; } = new Dictionary<char, char[]>
        {
            { '2', new char[] { 'A', 'B', 'C'      } },
            { '3', new char[] { 'D', 'E', 'F'      } },
            { '4', new char[] { 'G', 'H', 'I'      } },
            { '5', new char[] { 'J', 'K', 'L'      } },
            { '6', new char[] { 'M', 'N', 'O'      } },
            { '7', new char[] { 'P', 'R', 'S'      } },
            { '8', new char[] { 'T', 'U', 'V'      } },
            { '9', new char[] { 'W', 'X', 'Y', 'Z' } }
        };

        /// <summary>
        /// Gets a list of letter sequences formed from the provided phone number.
        /// </summary>
        /// <param name="telephoneNumber">The phone number.</param>
        /// <returns>An array of the corresponding letter sequences.</returns>
        public static string[] GetWordsFromTelephoneNumber(string telephoneNumber)
        {
            // Remove the hyphen from the number, if one is present
            string number = telephoneNumber.Replace("-", "");

            // If the number is not in a valid format, exit the method
            if (!Regex.IsMatch(number, @"\A[2-9]{7}\z")) return null;

            // Store the letter sequences
            List<string> words = new List<string>();

            for (int i = 0; i < number.Length; i++)
            {
                // Get the letters that correspond to the current digit
                char[] chars = DigitToLettersMap[number[i]];

                // If this is the first digit (and thus the list 'words' is empty)
                if (i == 0)
                    // Add each letter, as a string, to 'words'
                    foreach (char c in chars) words.Add("" + c);
                // If this isn't the first digit (and thus 'words' is not empty)
                else
                {
                    // Loop through the list of words so far.
                    // Since we will be inserting things after the current index,
                    // we need to loop backwards
                    for (int j = words.Count - 1; j >= 0; j--)
                    {
                        // Store the current (incomplete) word
                        string currentWord = words[j];
                        
                        // Loop through the letters corresponding to the current digit
                        for (int k = 0; k < chars.Length; k++)
                        {
                            // Form a new word by adding the letter to the current word
                            string newWord = currentWord + chars[k];

                            // If this is the first corresponding letter, simply add the word at the current word's index
                            if (k == 0) words[j] = newWord;
                            // If we're at the end of the list of words, add the new word on the end
                            else if (j == words.Count - 1) words.Add(newWord);
                            // Otherwise, insert the word after the index of 'currentWord'
                            else words.Insert(j + k, newWord);
                        }
                    }
                }

            }

            // Return the list of letter sequences as a string array.
            return words.ToArray();
        }

        /// <summary>
        /// Writes the list of letter sequences corresponding to the provided phone number to text file.
        /// </summary>
        /// <param name="telephoneNumber">The phone number to use to form the letter sequences.</param>
        /// <param name="outputPath">The file path to write the words to; "output.txt" by default.</param>
        /// <returns>The number of letter sequences generated, equal to the number of lines written.</returns>
        public static int WriteTelephoneNumberWordsToFile(string telephoneNumber, 
            string outputPath = "output.txt")
        {

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                // Get the list of words
                string[] words = GetWordsFromTelephoneNumber(telephoneNumber);

                // Loop through and write each word to the provided file
                foreach (string word in words)
                {
                    writer.WriteLine(word);
                }

                // Return the number of words generated.
                return words.Length;
            }
        }

    }
}
