using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1_Ermit_
{
    public partial class Ermit : Form
    {
        public Ermit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Point1_Click(object sender, EventArgs e)
        {
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            double Point1x = Convert.ToDouble(p1x.Text);
            double Point1y = Convert.ToDouble(p1y.Text);

            double Point2x = Convert.ToDouble(p2x.Text);
            double Point2y = Convert.ToDouble(p2y.Text);

            double Vector1x = Convert.ToDouble(v1x.Text);
            double Vector1y = Convert.ToDouble(v1y.Text);

            double Vector2x = Convert.ToDouble(v2x.Text);
            double Vector2y = Convert.ToDouble(v2y.Text);

            double x, y;
            double lastX = 0, lastY = 0;

            Graphics g = panel1.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen redPen = new Pen(Color.Red, 2);

            for (double t = 0; t <= 1; t += 0.001)
            {
                x = Point1x * (2 * t * t * t - 3 * t * t + 1) + Point2x * (-2 * t * t * t + 3 * t * t) + Vector1x * (t * t * t - 2 * t * t + t) + Vector2x * (t * t * t - t * t);

                y = Point1y * (2 * t * t * t - 3 * t * t + 1) + Point2y * (-2 * t * t * t + 3 * t * t) + Vector1y * (t * t * t - 2 * t * t + t) + Vector2y * (t * t * t - t * t);

                if (t == 0)
                {
                    lastX = x;
                    lastY = y;
                }
                else
                {
                    g.DrawLine(bluePen, (float)lastX, (float)lastY, (float)x, (float)y);
                    lastX = x;
                    lastY = y;
                }
            }

            g.DrawLine(redPen, (float)Point1x, (float)Point1y, (float)(Point1x + Vector1x), (float)(Point1y + Vector1y));
            g.DrawLine(redPen, (float)Point2x, (float)Point2y, (float)(Point2x - Vector2x), (float)(Point2y - Vector2y));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(SystemColors.ActiveCaption);
        }
    }
}
