using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.XtraEditors; // If SimpleButton comes from DevExpress.

public class RoundedButton : SimpleButton
{
    // Customizable properties
    public int CornerRadius { get; set; } = 20; // Default corner radius
    public Color BorderColor { get; set; } = Color.CadetBlue; // Default border color
    public float BorderThickness { get; set; } = 1.75f; // Default border thickness
    public new Color BackColor { get; set; } = Color.CadetBlue;
    public new Color ForeColor { get; set; } = Color.White; // Default text color
    public new Font Font { get; set; } = new Font("Arial", 10f); // Default font setting

    // State-based properties for hover, pressed, and disabled appearances
    private Color hoverBackColor = Color.FromArgb(40, 150, 220); // Default hover background color
    private Color pressedBackColor = Color.FromArgb(30, 120, 200); // Default pressed background color
    private Color disabledBackColor = Color.LightGray; // Default disabled background color
    private Color disabledBorderColor = Color.Gray; // Default disabled border color
    private Color disabledTextColor = Color.DarkGray; // Default disabled text color

    private bool isMouseOver = false;
    private bool isMousePressed = false;

    public RoundedButton()
    {
        this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat; // Set Flat style
        this.LookAndFeel.UseDefaultLookAndFeel = false; // Avoid default styling
        this.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder; // Remove border

        // Event Handlers for mouse actions
        this.MouseEnter += (sender, e) => { isMouseOver = true; this.Invalidate(); };
        this.MouseLeave += (sender, e) => { isMouseOver = false; isMousePressed = false; this.Invalidate(); };
        this.MouseDown += (sender, e) => { if (e.Button == MouseButtons.Left) isMousePressed = true; this.Invalidate(); };
        this.MouseUp += (sender, e) => { isMousePressed = false; this.Invalidate(); };
    }

    // Method to create a rounded rectangle path
    private GraphicsPath GetRoundPath(RectangleF rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }

    // Override OnPaint to apply custom drawing
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.Clear(this.Parent.BackColor);
        
        this.Region = null; // Clear the region to avoid clipping issues

        RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

        using (GraphicsPath path = GetRoundPath(rect, CornerRadius))
        {

            // Apply the rounded region to the button
            this.Region = new Region(path);

            // Determine the current background color based on button state
            Color currentBackColor = this.Enabled ?
                (isMousePressed ? pressedBackColor : isMouseOver ? hoverBackColor : base.BackColor)
                : disabledBackColor;

            Color currentBorderColor = this.Enabled ? BorderColor : disabledBorderColor;
            Color currentForeColor = this.Enabled ? ForeColor : disabledTextColor;

            // Clear the background with the parent container's color
            e.Graphics.Clear(this.Parent?.BackColor ?? SystemColors.Control);

            // Fill the background with the current background color
            using (Brush backgroundBrush = new SolidBrush(currentBackColor))
            {
                e.Graphics.FillPath(backgroundBrush, path); // Fill the button background
            }

            // Draw custom border
            using (Pen pen = new Pen(currentBorderColor, BorderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, path);
            }

            // Draw text with the current ForeColor property and custom Font
            using (Brush textBrush = new SolidBrush(currentForeColor))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(this.Text, this.Font, textBrush, rect, format); // Draw the button text
            }
        }
    }
}
