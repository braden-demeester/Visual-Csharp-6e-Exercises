using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUserControlTest
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public string Login { get => loginTextBox.Text; }

        public string Password { get => passwordTextBox.Text; }

        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        // Invoked when the Text of either TextBox in the control is changed
        public event EventHandler TextChanged;
        private void TextChangedHandler(object sender, EventArgs e)
        {
            // If there is a handler for this event, invoke it.
            if (TextChanged != null)
                TextChanged(this, e);
        }

    }
}
