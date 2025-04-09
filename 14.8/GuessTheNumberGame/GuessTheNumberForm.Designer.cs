namespace GuessTheNumberGame
{
    partial class GuessTheNumberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.introductionLabel = new System.Windows.Forms.Label();
            this.guessInputLabel = new System.Windows.Forms.Label();
            this.guessInputTextBox = new System.Windows.Forms.TextBox();
            this.comparisonLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introductionLabel
            // 
            this.introductionLabel.AutoSize = true;
            this.introductionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionLabel.Location = new System.Drawing.Point(13, 13);
            this.introductionLabel.Name = "introductionLabel";
            this.introductionLabel.Size = new System.Drawing.Size(567, 48);
            this.introductionLabel.TabIndex = 0;
            this.introductionLabel.Text = "I have a number between 1 and 1000--can you guess my number?\r\nPlease enter your f" +
    "irst guess.";
            // 
            // guessInputLabel
            // 
            this.guessInputLabel.AutoSize = true;
            this.guessInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInputLabel.Location = new System.Drawing.Point(31, 78);
            this.guessInputLabel.Name = "guessInputLabel";
            this.guessInputLabel.Size = new System.Drawing.Size(57, 17);
            this.guessInputLabel.TabIndex = 1;
            this.guessInputLabel.Text = "Guess: ";
            // 
            // guessInputTextBox
            // 
            this.guessInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessInputTextBox.Location = new System.Drawing.Point(94, 75);
            this.guessInputTextBox.Name = "guessInputTextBox";
            this.guessInputTextBox.Size = new System.Drawing.Size(100, 23);
            this.guessInputTextBox.TabIndex = 2;
            this.guessInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessInputTextBox_KeyDown);
            // 
            // comparisonLabel
            // 
            this.comparisonLabel.AutoSize = true;
            this.comparisonLabel.Location = new System.Drawing.Point(46, 111);
            this.comparisonLabel.Name = "comparisonLabel";
            this.comparisonLabel.Size = new System.Drawing.Size(0, 13);
            this.comparisonLabel.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(505, 101);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Play Again";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(218, 75);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(121, 23);
            this.guessButton.TabIndex = 5;
            this.guessButton.Text = "Submit Guess!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // GuessTheNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 141);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.comparisonLabel);
            this.Controls.Add(this.guessInputTextBox);
            this.Controls.Add(this.guessInputLabel);
            this.Controls.Add(this.introductionLabel);
            this.Name = "GuessTheNumberForm";
            this.Text = "Guess the Number!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introductionLabel;
        private System.Windows.Forms.Label guessInputLabel;
        private System.Windows.Forms.TextBox guessInputTextBox;
        private System.Windows.Forms.Label comparisonLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button guessButton;
    }
}