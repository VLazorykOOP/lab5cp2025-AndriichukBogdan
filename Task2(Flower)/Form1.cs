using System;
using System.Collections.Generic;
using System.Drawing;


namespace Task2_Flower_
{
    public partial class Flower : Form
    {
        public Flower()
        {
            InitializeComponent();
        }

        void Kulbaba(Graphics g ,double x1, double y1, double x2, double y2,int Num)
        {
            double dx, dy,xx, yy;
            double[] x = new double[6] ;
            double[] y = new double[6];
            int i;
            Pen redPen = new Pen(Color.Red, 2);

            g.DrawLine(redPen, (int)x1, (int)y1, (int)x2, (int)y2);
            if (Num > 0)
            {
                dx = x2 - x1;
                dy = y2 - y1;
                x[0] = x1 + 0.6 * dx;
                y[0] = y1 + 0.6 * dy;
                for (i = 0; i < 6; i++)
                    
                {
                    xx = (x[0] - x2) * Math.Cos(i * Math.PI / 3.0) - (y[0] - y2) * Math.Sin(i * Math.PI / 3.0) + x2;
                    yy = (x[0] - x2) * Math.Sin(i * Math.PI / 3.0) + (y[0] - y2) * Math.Cos(i * Math.PI / 3.0) + y2;
                    Kulbaba(g, x2, y2, xx, yy, Num - 1);
                }
            }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            double x2 = Convert.ToDouble(X2.Text);
            double y2 = Convert.ToDouble(Y2.Text);
            double xx = Convert.ToDouble(X1.Text);
            double yy = Convert.ToDouble(Y1.Text);
            int Num = Convert.ToInt32(K.Text);

            Graphics g = panel1.CreateGraphics();
            Kulbaba(g, x2, y2, xx, yy, Num - 1);

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(SystemColors.ActiveCaption);
        }
    }
}
