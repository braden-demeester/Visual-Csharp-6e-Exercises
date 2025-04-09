using System;

namespace TemperatureConversionTest
{
    public class Temperature
    {
        private double fahrenheit = 0.0;
        public double Fahrenheit
        {
            get => fahrenheit;
            set
            {
                if (value < -459.67)
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        "Temperature in Fahrenheit must be >= 459.67.");

                fahrenheit = value;
            }
        }
        public double Celsius
        {
            get
            {
                return 5.0 / 9.0 * (Fahrenheit - 32);
            }
        }

        public Temperature(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }
    }
}
