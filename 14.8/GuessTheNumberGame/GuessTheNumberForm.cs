using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessTheNumberGame
{
    public partial class GuessTheNumberForm : Form
    {
        // Instance of Random; will be used to generate target numbers
        private Random randomInstance;
        
        // Stores the target number that will need to be guessed
        private int target;

        // Stores the previous guess's distance to the target,
        // to determine whether a new guess is closer or further
        private int? lastGuessTargetDistance = null;

        // Constant string storing the first line of text in [introductionLabel]
        private readonly string introductionBaseText =
            "I have a number between 1 and 1000--can you guess my number?";

        // Constructor
        public GuessTheNumberForm()
        {
            // Initialize the form
            InitializeComponent();

            // Create an instance of the Random class to be used to choose the target numbers
            randomInstance = new Random();

            // Initialize the game
            Reset();
        }

        /// <summary>
        /// Called when the app is first loaded and when the user clicks [resetButton].
        /// Sets the game to an initial state.
        /// </summary>
        private void Reset()
        {
            // Reset background color to white
            BackColor = Color.White;
            
            // No comparisons yet, so empty [comparisonLabel]
            comparisonLabel.Text = "";
            
            // Enable the input text box and remove any text from it
            guessInputTextBox.Enabled = true;
            guessInputTextBox.Text = "";

            // Pick a new random integer for the target; 
            // use 1001 for maxValue so that 1000 is a possible result
            target = randomInstance.Next(1, 1001);

            // Set lastGuessTargetDistance to null so it's clear the next guess is the first one
            lastGuessTargetDistance = null;

            // Add "Please enter your first guess." on a separate line in [introductionLabel]
            introductionLabel.Text = introductionBaseText + Environment.NewLine +
                "Please enter your first guess.";
        }

        /// <summary>
        /// Handles the logic for submitting a guess.
        /// </summary>
        private void SubmitGuess()
        {
            if (!guessInputTextBox.Enabled) return; // If the guess box is disabled, no need to handle submissions

            // Try block since we might have exceptions
            try
            {
                // Convert the guess to an integer (may throw FormatException)
                int guess = int.Parse(guessInputTextBox.Text);

                // If this guess is below the target number
                if(guess < target)
                {
                    // Inform the user the guess is too low
                    comparisonLabel.Text = "Too Low";
                }
                // If this guess is above the target number
                else if(guess > target)
                {
                    // Inform the user the guess is too high
                    comparisonLabel.Text = "Too High";
                }
                // Otherwise (i.e. if the guess is correct)
                else
                {
                    // No comparison needed, so empty [comparisonLabel]
                    comparisonLabel.Text = "";

                    // Set the background color to a light green
                    BackColor = Color.LightGreen;

                    // Disable the input text box
                    guessInputTextBox.Enabled = false;

                    // Use a message box to inform the user that they won
                    MessageBox.Show("Correct!", "You Win!");
                    
                    // We don't need the rest of the logic after winning, so we'll exit the function
                    return;
                }

                // Calculate the distance between this guess and the target
                int guessTargetDistance = Math.Abs(guess - target);

                // If lastGuessTargetDistance is null, we know this is the first guess
                if (lastGuessTargetDistance == null)
                {
                    // Remove "Please enter your first guess" from [introductionLabel]
                    introductionLabel.Text = introductionBaseText;
                }
                // Otherwise (if this isn't the first guess)
                else
                {
                    // Compare this distance to the last one: is this guess better than the previous?
                    BackColor = guessTargetDistance < lastGuessTargetDistance ? // If this guess is closer than the last
                        Color.PaleTurquoise : // Set the background color to a light blue
                        Color.LightPink; // Otherwise, set it to a light red
                }

                // Store the current distance to be compared against later
                lastGuessTargetDistance = guessTargetDistance;

            }
            catch(FormatException) // Catch exceptions from int.Parse above
            {
                // Inform the user of the issue via message box
                MessageBox.Show("Your guess must be an integer!",
                    "Format Exception");
            }

            
        }


        /// <summary>
        /// Handles KeyDown events in [guessInputTextBox].
        /// When Enter is pressed, the guess is submitted.
        /// </summary>
        /// <param name="sender">The component in the form that sent the event.</param>
        /// <param name="e">The details of the KeyDown event.</param>
        private void guessInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SubmitGuess();
        }


        /// <summary>
        /// Handles Click events in [guessButton].
        /// When the button is clicked, the guess entered in [guessInputTextBox] is submitted.
        /// </summary>
        /// <param name="sender">The component in the form that sent the event.</param>
        /// <param name="e">The details of the Click event.</param>
        private void guessButton_Click(object sender, EventArgs e) => SubmitGuess();


        /// <summary>
        /// Handles Click events in [resetButton].
        /// When the button is clicked, the game is reset to be played again.
        /// </summary>
        /// <param name="sender">The component in the form that sent the event.</param>
        /// <param name="e">The details of the Click event.</param>
        private void resetButton_Click(object sender, EventArgs e) => Reset();
    }
}
