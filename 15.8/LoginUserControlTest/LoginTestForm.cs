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
    public partial class LoginTestForm : Form
    {
        // Constants for the default message / prefix of the property-result labels
        private readonly string defaultLoginPropertyLabelText =
            "Result of LPUC Login property: ";
        private readonly string defaultPasswordPropertyLabelText =
            "Result of LPUC Password property: ";

        public LoginTestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles TextChanged events from testLoginUserControl.
        /// Updates loginPropertyLabel and passwordPropertyLabel with the values of
        ///     the Login and Password properties of testLoginUserControl
        /// </summary>
        /// <param name="sender">The object from which the event originated</param>
        /// <param name="e">The EventArgs for the event</param>
        private void testLoginUserControl_TextChanged(object sender, EventArgs e)
        {
            loginPropertyLabel.Text = defaultLoginPropertyLabelText
                + testLoginUserControl.Login;

            passwordPropertyLabel.Text = defaultPasswordPropertyLabelText
                + testLoginUserControl.Password;
        }
    }
}
