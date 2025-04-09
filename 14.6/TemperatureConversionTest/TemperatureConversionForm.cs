using System;
using System.Windows.Forms;

namespace TemperatureConversionTest
{
    public partial class TemperatureConversionForm : Form
    {
        
        public TemperatureConversionForm()
        {
            InitializeComponent();
        }

        private void convertTemperatureButton_Click(object sender, EventArgs e)
        {
            try
            {
                Temperature temperature = new Temperature(
                    double.Parse(fahrenheitInputTextBox.Text));

                celsiusOutputLabel.Text = $"Equivalent temperature in Celsius: {temperature.Celsius:F2} °C";

            }
            catch(FormatException)
            {
                MessageBox.Show("Temperature in Fahrenheit must be a numeric value!",
                    "Format Exception");
            }
            catch(ArgumentOutOfRangeException aore)
            {
                MessageBox.Show(aore.Message,
                    "Argument out of Range Exception");
            }

        }
    }
}
