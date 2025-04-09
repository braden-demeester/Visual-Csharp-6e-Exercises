using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public partial class PainterForm : Form
    {
        // Enum for the different brush sizes
        public enum PaintBrushSize
        {
            Small = 2,
            Medium = 4,
            Large = 8
        };

        // Auto-implemented property: whether to paint when mouse is moved
        public bool ShouldPaint { get; set; } = false;

        // Auto-implemented property: the color to paint with
        public Color Color { get; set; } = Color.Black;

        // Auto-implemented property: the size of the brush
        public PaintBrushSize BrushSize { get; set; } = PaintBrushSize.Medium;

        // Store the last mouse position
        private int? lastMouseX = null, lastMouseY = null;


        // Default constructor
        public PainterForm()
        {
            InitializeComponent();
        }

        // Called on "CheckedChanged" events for all radio buttons in the "Color" group box
        private void color_CheckedChanged(object sender, EventArgs e)
        {
            // Set the Color property based on which radio button sent the event
            if (sender == colorRedRadioButton)
                Color = Color.Red;
            else if (sender == colorBlueRadioButton)
                Color = Color.Blue;
            else if (sender == colorGreenRadioButton)
                Color = Color.Green;
            else if (sender == colorBlackRadioButton)
                Color = Color.Black;
        }

        // Called on "CheckChanged" events for all radio buttons in the "Size" group box
        private void size_CheckedChanged(object sender, EventArgs e)
        {
            // Set the BrushSize property based on which radio button sent the event
            if (sender == sizeSmallRadioButton)
                BrushSize = PaintBrushSize.Small;
            else if (sender == sizeMediumRadioButton)
                BrushSize = PaintBrushSize.Medium;
            else if (sender == sizeLargeRadioButton)
                BrushSize = PaintBrushSize.Large;
        }

        // Called when the user presses a mouse button down (begins a click)
        private void painterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Since the mouse is down, we want to paint whenever the mouse is moved
            ShouldPaint = true;
        }

        // Called when the user releases a mouse button (ends a click)
        private void painterPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Since the mouse is not down, we do not want to paint
            ShouldPaint = false;
        }

        // Called whenever the user moves the mouse
        private void painterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Only paint if ShouldPaint is true (i.e. a mouse button is held down)
            if(ShouldPaint)
            {
                using (Graphics g = painterPanel.CreateGraphics()) // Get the graphics for the painterPanel
                {
                    // Simply drawing an ellipse at the current mouse position often leaves holes, so we'll draw lines.


                    // Store the diameter of the circles to be drawn
                    // Equivalent to the width of the lines
                    int diameter = (int)BrushSize;

                    // If mouse position is currently null (i.e. this is the first MouseMove event),
                    // just use the current position for both coordinates
                    int lmX = lastMouseX ?? e.X, lmY = lastMouseY ?? e.Y;

                    // Draw circles at the endpoints to avoid weird sharp edges and holes
                    SolidBrush brush = new SolidBrush(Color);
                    // FillEllipse takes the top-left corner,
                    // so subtract half the diameter to center the circle properly
                    g.FillEllipse(brush, lmX - diameter / 2, lmY - diameter / 2, diameter, diameter);
                    g.FillEllipse(brush, e.X - diameter / 2, e.Y - diameter / 2, diameter, diameter);

                    // Connect the dots
                    g.DrawLine(new Pen(Color, diameter), lmX, lmY, e.X, e.Y);
                }
            }

            // Update the variables for the last mouse position
            lastMouseX = e.X;
            lastMouseY = e.Y;
        }

    }
}
