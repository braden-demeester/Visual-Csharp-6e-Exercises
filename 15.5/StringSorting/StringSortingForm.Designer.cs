namespace StringSorting
{
    partial class StringSortingForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.sortedStringsListBox = new System.Windows.Forms.ListBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 29);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(291, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // sortedStringsListBox
            // 
            this.sortedStringsListBox.FormattingEnabled = true;
            this.sortedStringsListBox.Location = new System.Drawing.Point(331, 13);
            this.sortedStringsListBox.Name = "sortedStringsListBox";
            this.sortedStringsListBox.Size = new System.Drawing.Size(322, 147);
            this.sortedStringsListBox.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(226, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input your strings below! Press Enter to submit.";
            // 
            // StringSortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 171);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.sortedStringsListBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "StringSortingForm";
            this.Text = "String Sorter!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ListBox sortedStringsListBox;
        private System.Windows.Forms.Label inputLabel;
    }
}