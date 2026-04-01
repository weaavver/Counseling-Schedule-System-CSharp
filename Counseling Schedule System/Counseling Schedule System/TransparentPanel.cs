using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentPanel : Panel
{
    private int opacity = 0;

    public int Opacity
    {
        get => opacity;
        set
        {
            opacity = Math.Max(0, Math.Min(255, value));
            Invalidate();
        }
    }

    public TransparentPanel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        using (SolidBrush brush = new SolidBrush(Color.FromArgb(opacity, BackColor)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        base.OnPaint(e);
    }
}