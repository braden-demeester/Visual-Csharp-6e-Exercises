using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TelephoneNumberWordGenerator
{
    public partial class TelephoneNumberInputForm : Form
    {
        public TelephoneNumberInputForm()
        {
            InitializeComponent();
        }

        // Store whether the Text in [phoneNumberInputTextBox] is a valid phone number
        private bool inputValid = false;


        /// <summary>
        /// Handles "TextChanged" events on [phoneNumberInputTextBox].
        /// Checks if the Text in the text box is a valid phone number,
        /// and informs the user via a label.
        /// </summary>
        /// <param name="sender">The control that sent the event.</param>
        /// <param name="e">The information for the event.</param>
        private void phoneNumberInputTextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the provided phone number is of the form 333-4444 or 3334444, where no digit is 0 or 1;
            // store this in 'inputValid'
            inputValid = Regex.IsMatch(phoneNumberInputTextBox.Text,
                @"\A[2-9]{3}\-?[2-9]{4}\z");

            // Set the Text of a label near the text box to "Valid" if the number is valid,
            // and "Invalid" otherwise
            phoneNumberInputValidityLabel.Text = 
                 inputValid ? "Valid" : "Invalid";
        }

        /// <summary>
        /// Handles events whose purpose is to submit the phone number in [phoneNumberInputTextBox].
        /// Namely, "Click" events on [submitPhoneNumberButton],
        /// and "KeyDown" events (where the key is Enter) on [phoneNumberInputTextBox].
        /// Writes the words formed from the input phone number to a text file.
        /// </summary>
        /// <param name="sender">The control that sent the event.</param>
        /// <param name="e">The information for the event.</param>
        private void SubmitPhoneNumberEventHandler(object sender, EventArgs e)
        {
            // If this is a key event, exit the method unless the key pressed is Enter
            if (e is KeyEventArgs ke && ke.KeyCode != Keys.Enter) return;

            // If the input is a valid phone number
            if(inputValid)
            {
                // Write the words formed from the phone number to a text file
                int lineCount = TelephoneNumberToWords.WriteTelephoneNumberWordsToFile(
                    phoneNumberInputTextBox.Text);

                // Inform the user how many lines were written to the file
                MessageBox.Show($"{lineCount} lines written.", "Success");
            }
            // If the input is not valid
            else
            {
                // Inform the user of the issue
                MessageBox.Show("Provided phone number is not valid!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
