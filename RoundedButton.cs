using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 15; // Adjust the radius as needed

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.Clear(Parent.BackColor);

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(new Rectangle(0, 0, BorderRadius, BorderRadius), 180, 90);
            path.AddArc(new Rectangle(Width - BorderRadius, 0, BorderRadius, BorderRadius), -90, 90);
            path.AddArc(new Rectangle(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius), 0, 90);
            path.AddArc(new Rectangle(0, Height - BorderRadius, BorderRadius, BorderRadius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.White, 1))
            {
                pevent.Graphics.DrawPath(pen, path);
            }

            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, Color.FromArgb(98, 102, 244), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
