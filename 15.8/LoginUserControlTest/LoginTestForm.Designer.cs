namespace LoginUserControlTest
{
    partial class LoginTestForm
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
            this.loginPropertyLabel = new System.Windows.Forms.Label();
            this.passwordPropertyLabel = new System.Windows.Forms.Label();
            this.testLoginUserControl = new LoginUserControlTest.LoginPasswordUserControl();
            this.SuspendLayout();
            // 
            // loginPropertyLabel
            // 
            this.loginPropertyLabel.AutoSize = true;
            this.loginPropertyLabel.Location = new System.Drawing.Point(29, 109);
            this.loginPropertyLabel.Name = "loginPropertyLabel";
            this.loginPropertyLabel.Size = new System.Drawing.Size(153, 13);
            this.loginPropertyLabel.TabIndex = 1;
            this.loginPropertyLabel.Text = "Result of LPUC Login property:";
            // 
            // passwordPropertyLabel
            // 
            this.passwordPropertyLabel.AutoSize = true;
            this.passwordPropertyLabel.Location = new System.Drawing.Point(9, 133);
            this.passwordPropertyLabel.Name = "passwordPropertyLabel";
            this.passwordPropertyLabel.Size = new System.Drawing.Size(173, 13);
            this.passwordPropertyLabel.TabIndex = 2;
            this.passwordPropertyLabel.Text = "Result of LPUC Password property:";
            // 
            // testLoginUserControl
            // 
            this.testLoginUserControl.Location = new System.Drawing.Point(12, 12);
            this.testLoginUserControl.Name = "testLoginUserControl";
            this.testLoginUserControl.Size = new System.Drawing.Size(299, 66);
            this.testLoginUserControl.TabIndex = 0;
            this.testLoginUserControl.TextChanged += new System.EventHandler(this.testLoginUserControl_TextChanged);
            // 
            // LoginTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 161);
            this.Controls.Add(this.passwordPropertyLabel);
            this.Controls.Add(this.loginPropertyLabel);
            this.Controls.Add(this.testLoginUserControl);
            this.Name = "LoginTestForm";
            this.Text = "Login Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginPasswordUserControl testLoginUserControl;
        private System.Windows.Forms.Label loginPropertyLabel;
        private System.Windows.Forms.Label passwordPropertyLabel;
    }
}

