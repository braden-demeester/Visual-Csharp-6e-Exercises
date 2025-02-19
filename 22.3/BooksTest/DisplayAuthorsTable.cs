using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksTest
{
    public partial class DisplayAuthorsTable : Form
    {
        public DisplayAuthorsTable()
        {
            InitializeComponent();
            try
            {
                string dataDirectory = AppDomain.CurrentDomain
                    .BaseDirectory; // Folder with executable
                if (dataDirectory.EndsWith("\\bin\\Debug\\") ||
                    dataDirectory.EndsWith("\\bin\\Release\\"))
                {
                    // If in bin\Debug or bin\Release, we want to chop off the end
                    // and make sure we have the full (absolute) path
                    dataDirectory = System.IO.Directory // .\BooksTest\bin\[Debug|Release]\
                        .GetParent(dataDirectory)       // .\BooksTest\bin\[Debug|Release]
                        .Parent                         // .\BooksTest\bin
                        .Parent                         // .\BooksTest
                        .FullName;                      // Gets absolute path
                }
                // Set the data directory to where the DB file is.
                // This ensures the connection string can find the .mdf file.
                AppDomain.CurrentDomain.SetData(
                    "DataDirectory", dataDirectory);
            }
            catch (AppDomainUnloadedException)
            // Catch potential exception from BaseDirectory getter
            // or SetData method
            {
                MessageBox.Show("Could not load app domain. May fail to save changes to database.",
                    "App Domain Unloaded Exception");
            }
            catch (Exception ex)
            // Catch other potential exceptions from Directory.GetParent method
            {
                MessageBox.Show(ex.Message);
            }

        }

        private BooksEntities dbContext =
            new BooksEntities();

        private void DisplayAuthorsTable_Load(object sender, EventArgs e)
        {
            var query =
                from author in dbContext.Authors
                orderby author.LastName, author.FirstName,
                    author.AuthorID // If two authors have the same first and last name, order by AuthorID
                select author;
            query.Load();

            authorsBindingSource.DataSource = dbContext.Authors.Local;
        }

        private void authorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                authorsBindingSource.EndEdit();
                dbContext.SaveChanges();
                booksDatabaseDataSet.AcceptChanges();
                authorsTableAdapter.Update(booksDatabaseDataSet);
            }
            catch (DbEntityValidationException)
            // Thrown if FirstName or LastName is/are null
            {
                MessageBox.Show("FirstName and LastName must contain values",
                    "Entity Validation Exception");
            }
            catch (Exception ex)
            // Catch any other possible exceptions from SaveChanges
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lastNameSearchButton_Click(object sender, EventArgs e)
        {
            // Select authors with the last name given in the text box
            var query =
                from author in dbContext.Authors
                where author.LastName == lastNameSearchTextBox.Text
                orderby author.FirstName, // Order alphabetically by first name
                    author.AuthorID // If two authors have the same first and last name, order them by AuthorID
                select author;

            authorsBindingSource.DataSource = query.ToList();
            authorsBindingSource.MoveFirst();
        }

        private void allAuthorsButton_Click(object sender, EventArgs e)
        {
            // Query again to ensure accurate data
            // Select all authors in the Authors table.
            var query =
                from author in dbContext.Authors
                orderby author.LastName, author.FirstName,
                    author.AuthorID // If two authors have the same first and last name, order by AuthorID
                select author;
            query.Load();

            // Re-set the data source
            authorsBindingSource.DataSource = dbContext.Authors.Local;
            authorsBindingSource.MoveFirst();
        }

    }
}
