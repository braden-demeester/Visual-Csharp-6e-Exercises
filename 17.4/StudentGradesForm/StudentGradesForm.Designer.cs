namespace StudentGradesForm
{
    partial class StudentGradesForm
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
            this.studentGradesListTextBox = new System.Windows.Forms.TextBox();
            this.studentGradesListLabel = new System.Windows.Forms.Label();
            this.gradesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSelectedLabel = new System.Windows.Forms.Label();
            this.addRecordLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentGradesListTextBox
            // 
            this.studentGradesListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGradesListTextBox.Location = new System.Drawing.Point(13, 114);
            this.studentGradesListTextBox.Multiline = true;
            this.studentGradesListTextBox.Name = "studentGradesListTextBox";
            this.studentGradesListTextBox.ReadOnly = true;
            this.studentGradesListTextBox.Size = new System.Drawing.Size(775, 161);
            this.studentGradesListTextBox.TabIndex = 2;
            // 
            // studentGradesListLabel
            // 
            this.studentGradesListLabel.AutoSize = true;
            this.studentGradesListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGradesListLabel.Location = new System.Drawing.Point(12, 86);
            this.studentGradesListLabel.Name = "studentGradesListLabel";
            this.studentGradesListLabel.Size = new System.Drawing.Size(269, 25);
            this.studentGradesListLabel.TabIndex = 0;
            this.studentGradesListLabel.Text = "Student Grade Information:";
            // 
            // gradesFileDialog
            // 
            this.gradesFileDialog.FileName = "StudentGrades.ser";
            this.gradesFileDialog.Filter = "Binary files|*.ser|All files|*.*";
            // 
            // fileSelectedLabel
            // 
            this.fileSelectedLabel.AutoSize = true;
            this.fileSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectedLabel.Location = new System.Drawing.Point(13, 13);
            this.fileSelectedLabel.Name = "fileSelectedLabel";
            this.fileSelectedLabel.Size = new System.Drawing.Size(102, 20);
            this.fileSelectedLabel.TabIndex = 0;
            this.fileSelectedLabel.Text = "File selected:";
            // 
            // addRecordLabel
            // 
            this.addRecordLabel.AutoSize = true;
            this.addRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordLabel.Location = new System.Drawing.Point(17, 296);
            this.addRecordLabel.Name = "addRecordLabel";
            this.addRecordLabel.Size = new System.Drawing.Size(105, 20);
            this.addRecordLabel.TabIndex = 0;
            this.addRecordLabel.Text = "New Student:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(83, 325);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(45, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(55, 328);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 354);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(83, 351);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 380);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(83, 377);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(303, 328);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(54, 13);
            this.classNameLabel.TabIndex = 0;
            this.classNameLabel.Text = "Class title:";
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(363, 325);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(198, 20);
            this.classNameTextBox.TabIndex = 8;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(318, 354);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 0;
            this.gradeLabel.Text = "Grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(363, 351);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(45, 20);
            this.gradeTextBox.TabIndex = 9;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(21, 415);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(85, 23);
            this.addRecordButton.TabIndex = 10;
            this.addRecordButton.Text = "&Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(112, 415);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(140, 23);
            this.saveFileButton.TabIndex = 11;
            this.saveFileButton.Text = "&Save Changes to File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(17, 37);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(161, 293);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.clearFieldsButton.TabIndex = 3;
            this.clearFieldsButton.Text = "&Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addRecordLabel);
            this.Controls.Add(this.fileSelectedLabel);
            this.Controls.Add(this.studentGradesListLabel);
            this.Controls.Add(this.studentGradesListTextBox);
            this.Name = "StudentGradesForm";
            this.Text = "StudentGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentGradesListTextBox;
        private System.Windows.Forms.Label studentGradesListLabel;
        private System.Windows.Forms.OpenFileDialog gradesFileDialog;
        private System.Windows.Forms.Label fileSelectedLabel;
        private System.Windows.Forms.Label addRecordLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button clearFieldsButton;
    }
}