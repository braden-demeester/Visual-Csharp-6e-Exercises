using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSorting
{
    public partial class StringSortingForm : Form
    {
        public StringSortingForm()
        {
            InitializeComponent();
        }

        private void SortContents(ListBox listBox)
        {
            if (!listBox.Sorted)
            {

                List<string> itemsList = new List<string>();
                foreach (var item in listBox.Items)
                {
                    itemsList.Add(item.ToString());
                }
                string[] itemsArray = itemsList.ToArray();
                Array.Sort(itemsArray);

                listBox.Items.Clear();
                foreach (string str in itemsArray)
                {
                    listBox.Items.Add(str);
                }
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string inputString = inputTextBox.Text.Trim();
                if (inputString.Length > 0)
                {
                    sortedStringsListBox.Items.Add(inputString);
                    SortContents(sortedStringsListBox);
                    inputTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Input Text Box is empty! Nothing added to the List Box.", 
                        "Warning!",
                        0, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
