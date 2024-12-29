using System;
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
    public new Color BackColor { get; set; } = Color.White; // Override BackColor property
    public new Color ForeColor { get; set; } = Color.Black; // Override ForeColor property for text color
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
        float r2 = radius / 2f;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
        path.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
        path.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
        path.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);
        path.CloseFigure();
        return path;
    }

    // Override OnPaint to apply custom drawing
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Determine the current background color based on button state
        Color currentBackColor = this.Enabled ?
            (isMousePressed ? pressedBackColor : isMouseOver ? hoverBackColor : BackColor)
            : disabledBackColor;

        Color currentBorderColor = this.Enabled ? BorderColor : disabledBorderColor;
        Color currentForeColor = this.Enabled ? ForeColor : disabledTextColor;

        RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

        using (GraphicsPath path = GetRoundPath(rect, CornerRadius))
        {
            // Apply the rounded region to the button
            this.Region = new Region(path);

            // Fill the background with the current background color
            using (Brush backgroundBrush = new SolidBrush(currentBackColor))
            {
                e.Graphics.FillPath(backgroundBrush, path); // Fill the button background
            }

            // Draw custom border
            using (Pen pen = new Pen(currentBorderColor, BorderThickness))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
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
