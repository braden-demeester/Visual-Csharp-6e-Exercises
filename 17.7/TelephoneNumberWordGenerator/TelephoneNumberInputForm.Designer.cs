namespace TelephoneNumberWordGenerator
{
    partial class TelephoneNumberInputForm
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
            this.phoneNumberInputLabel = new System.Windows.Forms.Label();
            this.phoneNumberInputTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberFormatInformationLabel = new System.Windows.Forms.Label();
            this.phoneNumberInputValidityLabel = new System.Windows.Forms.Label();
            this.submitPhoneNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumberInputLabel
            // 
            this.phoneNumberInputLabel.AutoSize = true;
            this.phoneNumberInputLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInputLabel.Location = new System.Drawing.Point(12, 15);
            this.phoneNumberInputLabel.Name = "phoneNumberInputLabel";
            this.phoneNumberInputLabel.Size = new System.Drawing.Size(141, 23);
            this.phoneNumberInputLabel.TabIndex = 0;
            this.phoneNumberInputLabel.Text = "Phone Number:";
            // 
            // phoneNumberInputTextBox
            // 
            this.phoneNumberInputTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInputTextBox.Location = new System.Drawing.Point(159, 12);
            this.phoneNumberInputTextBox.MaxLength = 8;
            this.phoneNumberInputTextBox.Name = "phoneNumberInputTextBox";
            this.phoneNumberInputTextBox.Size = new System.Drawing.Size(181, 32);
            this.phoneNumberInputTextBox.TabIndex = 1;
            this.phoneNumberInputTextBox.TextChanged += new System.EventHandler(this.phoneNumberInputTextBox_TextChanged);
            this.phoneNumberInputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubmitPhoneNumberEventHandler);
            // 
            // phoneNumberFormatInformationLabel
            // 
            this.phoneNumberFormatInformationLabel.AutoSize = true;
            this.phoneNumberFormatInformationLabel.Location = new System.Drawing.Point(23, 54);
            this.phoneNumberFormatInformationLabel.Name = "phoneNumberFormatInformationLabel";
            this.phoneNumberFormatInformationLabel.Size = new System.Drawing.Size(187, 26);
            this.phoneNumberFormatInformationLabel.TabIndex = 2;
            this.phoneNumberFormatInformationLabel.Text = "Valid Formats: 333-4444 and 3334444\r\nNo 1s or 0s allowed.\r\n";
            // 
            // phoneNumberInputValidityLabel
            // 
            this.phoneNumberInputValidityLabel.AutoSize = true;
            this.phoneNumberInputValidityLabel.Location = new System.Drawing.Point(345, 22);
            this.phoneNumberInputValidityLabel.Name = "phoneNumberInputValidityLabel";
            this.phoneNumberInputValidityLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneNumberInputValidityLabel.TabIndex = 3;
            this.phoneNumberInputValidityLabel.Text = "Invalid";
            // 
            // submitPhoneNumberButton
            // 
            this.submitPhoneNumberButton.Location = new System.Drawing.Point(308, 54);
            this.submitPhoneNumberButton.Name = "submitPhoneNumberButton";
            this.submitPhoneNumberButton.Size = new System.Drawing.Size(75, 23);
            this.submitPhoneNumberButton.TabIndex = 4;
            this.submitPhoneNumberButton.Text = "Submit";
            this.submitPhoneNumberButton.UseVisualStyleBackColor = true;
            this.submitPhoneNumberButton.Click += new System.EventHandler(this.SubmitPhoneNumberEventHandler);
            // 
            // TelephoneNumberInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 89);
            this.Controls.Add(this.submitPhoneNumberButton);
            this.Controls.Add(this.phoneNumberInputValidityLabel);
            this.Controls.Add(this.phoneNumberFormatInformationLabel);
            this.Controls.Add(this.phoneNumberInputTextBox);
            this.Controls.Add(this.phoneNumberInputLabel);
            this.Name = "TelephoneNumberInputForm";
            this.Text = "Telephone Number Input Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneNumberInputLabel;
        private System.Windows.Forms.TextBox phoneNumberInputTextBox;
        private System.Windows.Forms.Label phoneNumberFormatInformationLabel;
        private System.Windows.Forms.Label phoneNumberInputValidityLabel;
        private System.Windows.Forms.Button submitPhoneNumberButton;
    }
}

