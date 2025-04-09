namespace TemperatureConversionTest
{
    partial class TemperatureConversionForm
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
            this.fahrenheitInputTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitInputLabel = new System.Windows.Forms.Label();
            this.convertTemperatureButton = new System.Windows.Forms.Button();
            this.celsiusOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fahrenheitInputTextBox
            // 
            this.fahrenheitInputTextBox.Location = new System.Drawing.Point(190, 12);
            this.fahrenheitInputTextBox.Name = "fahrenheitInputTextBox";
            this.fahrenheitInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitInputTextBox.TabIndex = 0;
            // 
            // fahrenheitInputLabel
            // 
            this.fahrenheitInputLabel.AutoSize = true;
            this.fahrenheitInputLabel.Location = new System.Drawing.Point(9, 16);
            this.fahrenheitInputLabel.Name = "fahrenheitInputLabel";
            this.fahrenheitInputLabel.Size = new System.Drawing.Size(172, 13);
            this.fahrenheitInputLabel.TabIndex = 1;
            this.fahrenheitInputLabel.Text = "Temperature in degrees Fahrenheit";
            // 
            // convertTemperatureButton
            // 
            this.convertTemperatureButton.Location = new System.Drawing.Point(34, 42);
            this.convertTemperatureButton.Name = "convertTemperatureButton";
            this.convertTemperatureButton.Size = new System.Drawing.Size(75, 23);
            this.convertTemperatureButton.TabIndex = 2;
            this.convertTemperatureButton.Text = "Convert!";
            this.convertTemperatureButton.UseVisualStyleBackColor = true;
            this.convertTemperatureButton.Click += new System.EventHandler(this.convertTemperatureButton_Click);
            // 
            // celsiusOutputLabel
            // 
            this.celsiusOutputLabel.AutoSize = true;
            this.celsiusOutputLabel.Location = new System.Drawing.Point(12, 80);
            this.celsiusOutputLabel.Name = "celsiusOutputLabel";
            this.celsiusOutputLabel.Size = new System.Drawing.Size(169, 13);
            this.celsiusOutputLabel.TabIndex = 3;
            this.celsiusOutputLabel.Text = "Equivalent temperature in Celsius: ";
            // 
            // TemperatureConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 116);
            this.Controls.Add(this.celsiusOutputLabel);
            this.Controls.Add(this.convertTemperatureButton);
            this.Controls.Add(this.fahrenheitInputLabel);
            this.Controls.Add(this.fahrenheitInputTextBox);
            this.Name = "TemperatureConversionForm";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fahrenheitInputTextBox;
        private System.Windows.Forms.Label fahrenheitInputLabel;
        private System.Windows.Forms.Button convertTemperatureButton;
        private System.Windows.Forms.Label celsiusOutputLabel;
    }
}

