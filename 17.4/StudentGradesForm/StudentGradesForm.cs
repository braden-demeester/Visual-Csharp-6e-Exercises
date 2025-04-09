using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace StudentGradesForm
{
    public partial class StudentGradesForm : Form
    {
        private List<StudentGradeRecordSerializable> currentRecords =
            new List<StudentGradeRecordSerializable>();
        private List<StudentGradeRecordSerializable> newRecords =
            new List<StudentGradeRecordSerializable>();

        public StudentGradesForm()
        {
            InitializeComponent();
        }

        private BinaryFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Clears the fields for user-inputted student grade record data.
        /// </summary>
        private void ClearFields()
        {
            idTextBox.Text = "";
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            classNameTextBox.Text = "";
            gradeTextBox.Text = "";
        }


        /// <summary>
        /// Handles "Click" events on [browseButton].
        /// Opens a file dialog, then writes the student grade data
        /// from the user-selected file to [studentGradeTextBox].
        /// </summary>
        /// <param name="sender">The control that sent the event.</param>
        /// <param name="e">The information for the event.</param>
        private void browseButton_Click(object sender, EventArgs e)
        {
            // If the file dialog result is ok
            if (gradesFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Open a StreamReader to read from the selected file
                using (FileStream stream = new FileStream(gradesFileDialog.FileName,
                    FileMode.Open, FileAccess.Read))
                {
                    // Store the lines
                    List<string> lines = new List<string>();
                    currentRecords.Clear();

                    // Loop through each line in the file
                    StudentGradeRecordSerializable record = null;
                    try
                    {
                        record = (StudentGradeRecordSerializable) formatter.Deserialize(stream);
                    }
                    catch(SerializationException)
                    {
                        stream?.Close();
                        MessageBox.Show("No records in file", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    while (record != null)
                    {
                        try
                        {
                            // Convert the record object into a string
                            string line = record.ToString();

                            // Add the line to the list of lines
                            lines.Add(line);
                            currentRecords.Add(record);

                            // Read the next line
                            record = (StudentGradeRecordSerializable) formatter.Deserialize(stream);
                        }
                        catch(Exception ex) when (ex is SerializationException || ex is ArgumentException)
                        {
                            stream?.Close();
                            break;
                        }
                    }

                    // Add the lines to [studentGradeTextBox]
                    studentGradesListTextBox.Text = string.Join(Environment.NewLine, lines.ToArray());

                    // Update [fileSelectedLabel] to show the path of the selected file
                    fileSelectedLabel.Text = $"File selected: {gradesFileDialog.FileName}";
                }
            }
        }

        private void clearFieldsButton_Click(object sender, EventArgs e) => ClearFields();

        private void addRecordButton_Click(object sender, EventArgs e)
        {

            if (!(int.TryParse(idTextBox.Text, out int id) && id > 0))
            {
                MessageBox.Show("ID must be a positive integer", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                StudentGradeRecordSerializable student = new StudentGradeRecordSerializable(
                    id, firstNameTextBox.Text, lastNameTextBox.Text,
                    classNameTextBox.Text, gradeTextBox.Text);

                if (string.IsNullOrEmpty(studentGradesListTextBox.Text))
                {
                    studentGradesListTextBox.Text = student.ToString();
                }
                else
                {
                    studentGradesListTextBox.Text = string.Join(Environment.NewLine,
                        new string[]
                        {
                            studentGradesListTextBox.Text,
                            student.ToString()
                        });
                }

                newRecords.Add(student);

                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gradesFileDialog.FileName) || !File.Exists(gradesFileDialog.FileName))
            {
                MessageBox.Show("File is not valid", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FileStream stream = new FileStream(gradesFileDialog.FileName,
                FileMode.Open, FileAccess.Write))
            {
                foreach(StudentGradeRecordSerializable record in currentRecords.Union(newRecords))
                {
                    try
                    {
                        formatter.Serialize(stream, record);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Failed to Serialize a record", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                currentRecords.AddRange(newRecords);
                newRecords.Clear();

                MessageBox.Show("Changes saved", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void exitButton_Click(object sender, EventArgs e) => Close();

    }
}
