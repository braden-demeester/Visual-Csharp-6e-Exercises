namespace EnhancedPainter
{
    partial class PainterForm
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.colorGreenRadioButton = new System.Windows.Forms.RadioButton();
            this.colorBlueRadioButton = new System.Windows.Forms.RadioButton();
            this.colorRedRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeLargeRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeMediumRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeSmallRadioButton = new System.Windows.Forms.RadioButton();
            this.painterPanel = new System.Windows.Forms.Panel();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorBlackRadioButton);
            this.colorGroupBox.Controls.Add(this.colorGreenRadioButton);
            this.colorGroupBox.Controls.Add(this.colorBlueRadioButton);
            this.colorGroupBox.Controls.Add(this.colorRedRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(13, 13);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(76, 121);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // colorBlackRadioButton
            // 
            this.colorBlackRadioButton.AutoSize = true;
            this.colorBlackRadioButton.Checked = true;
            this.colorBlackRadioButton.Location = new System.Drawing.Point(7, 92);
            this.colorBlackRadioButton.Name = "colorBlackRadioButton";
            this.colorBlackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.colorBlackRadioButton.TabIndex = 3;
            this.colorBlackRadioButton.TabStop = true;
            this.colorBlackRadioButton.Text = "Black";
            this.colorBlackRadioButton.UseVisualStyleBackColor = true;
            this.colorBlackRadioButton.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // colorGreenRadioButton
            // 
            this.colorGreenRadioButton.AutoSize = true;
            this.colorGreenRadioButton.Location = new System.Drawing.Point(7, 68);
            this.colorGreenRadioButton.Name = "colorGreenRadioButton";
            this.colorGreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.colorGreenRadioButton.TabIndex = 2;
            this.colorGreenRadioButton.Text = "Green";
            this.colorGreenRadioButton.UseVisualStyleBackColor = true;
            this.colorGreenRadioButton.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // colorBlueRadioButton
            // 
            this.colorBlueRadioButton.AutoSize = true;
            this.colorBlueRadioButton.Location = new System.Drawing.Point(7, 44);
            this.colorBlueRadioButton.Name = "colorBlueRadioButton";
            this.colorBlueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.colorBlueRadioButton.TabIndex = 1;
            this.colorBlueRadioButton.Text = "Blue";
            this.colorBlueRadioButton.UseVisualStyleBackColor = true;
            this.colorBlueRadioButton.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // colorRedRadioButton
            // 
            this.colorRedRadioButton.AutoSize = true;
            this.colorRedRadioButton.Location = new System.Drawing.Point(7, 20);
            this.colorRedRadioButton.Name = "colorRedRadioButton";
            this.colorRedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.colorRedRadioButton.TabIndex = 0;
            this.colorRedRadioButton.Text = "Red";
            this.colorRedRadioButton.UseVisualStyleBackColor = true;
            this.colorRedRadioButton.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.sizeLargeRadioButton);
            this.sizeGroupBox.Controls.Add(this.sizeMediumRadioButton);
            this.sizeGroupBox.Controls.Add(this.sizeSmallRadioButton);
            this.sizeGroupBox.Location = new System.Drawing.Point(13, 150);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(76, 92);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // sizeLargeRadioButton
            // 
            this.sizeLargeRadioButton.AutoSize = true;
            this.sizeLargeRadioButton.Location = new System.Drawing.Point(7, 68);
            this.sizeLargeRadioButton.Name = "sizeLargeRadioButton";
            this.sizeLargeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.sizeLargeRadioButton.TabIndex = 2;
            this.sizeLargeRadioButton.TabStop = true;
            this.sizeLargeRadioButton.Text = "Large";
            this.sizeLargeRadioButton.UseVisualStyleBackColor = true;
            this.sizeLargeRadioButton.CheckedChanged += new System.EventHandler(this.size_CheckedChanged);
            // 
            // sizeMediumRadioButton
            // 
            this.sizeMediumRadioButton.AutoSize = true;
            this.sizeMediumRadioButton.Checked = true;
            this.sizeMediumRadioButton.Location = new System.Drawing.Point(7, 44);
            this.sizeMediumRadioButton.Name = "sizeMediumRadioButton";
            this.sizeMediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.sizeMediumRadioButton.TabIndex = 1;
            this.sizeMediumRadioButton.TabStop = true;
            this.sizeMediumRadioButton.Text = "Medium";
            this.sizeMediumRadioButton.UseVisualStyleBackColor = true;
            this.sizeMediumRadioButton.CheckedChanged += new System.EventHandler(this.size_CheckedChanged);
            // 
            // sizeSmallRadioButton
            // 
            this.sizeSmallRadioButton.AutoSize = true;
            this.sizeSmallRadioButton.Location = new System.Drawing.Point(7, 20);
            this.sizeSmallRadioButton.Name = "sizeSmallRadioButton";
            this.sizeSmallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.sizeSmallRadioButton.TabIndex = 0;
            this.sizeSmallRadioButton.TabStop = true;
            this.sizeSmallRadioButton.Text = "Small";
            this.sizeSmallRadioButton.UseVisualStyleBackColor = true;
            this.sizeSmallRadioButton.CheckedChanged += new System.EventHandler(this.size_CheckedChanged);
            // 
            // painterPanel
            // 
            this.painterPanel.BackColor = System.Drawing.Color.White;
            this.painterPanel.Location = new System.Drawing.Point(109, 13);
            this.painterPanel.Name = "painterPanel";
            this.painterPanel.Size = new System.Drawing.Size(328, 236);
            this.painterPanel.TabIndex = 2;
            this.painterPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.painterPanel_MouseDown);
            this.painterPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.painterPanel_MouseMove);
            this.painterPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.painterPanel_MouseUp);
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.painterPanel);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "PainterForm";
            this.Text = "Enhanced Painter";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton colorBlackRadioButton;
        private System.Windows.Forms.RadioButton colorGreenRadioButton;
        private System.Windows.Forms.RadioButton colorBlueRadioButton;
        private System.Windows.Forms.RadioButton colorRedRadioButton;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton sizeLargeRadioButton;
        private System.Windows.Forms.RadioButton sizeMediumRadioButton;
        private System.Windows.Forms.RadioButton sizeSmallRadioButton;
        private System.Windows.Forms.Panel painterPanel;
    }
}

