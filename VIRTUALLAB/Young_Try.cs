   using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace VIRTUALLAB
{
    public partial class Young_Try : MetroForm
    {
        public Young_Try()
        {
            InitializeComponent();
           

        } private void ym_DoubleClick(object sender, EventArgs e) { ym.Text = "?"; }private void ymy_DoubleClick(object sender, EventArgs e) { ymy.Text = "?"; }

        private void xm_DoubleClick(object sender, EventArgs e) { xm.Text = "?"; }private void xmx_DoubleClick(object sender, EventArgs e) { xmx.Text = "?"; }

        private void dm_DoubleClick(object sender, EventArgs e) { dm.Text = "?"; }private void dmd_DoubleClick(object sender, EventArgs e) { dmd.Text = "?"; }

        private void Lm_DoubleClick(object sender, EventArgs e) { Lm.Text = "?"; }private void LmL_DoubleClick(object sender, EventArgs e) { LmL.Text = "?"; }
        public void lop()
        {
            Graphics RT = pictureBox1.CreateGraphics();

            int y1 = int.Parse(y.Text);

            if (y1 > 634 && y1 < 700)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 30, X2 += 30, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Red, CV);
                }
            }
            else if (y1 > 589 && y1 < 635)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 25, X2 += 25, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Orange, CV);
                }
            }
            else if (y1 > 559 && y1 < 590)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 20, X2 += 20, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Yellow, CV);
                }
            }
            else if (y1 > 519 && y1 < 560)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 15, X2 += 15, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Green, CV);
                }

            }
            else if (y1 > 489 && y1 < 520)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 10, X2 += 10, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Aqua, CV);
                }
            }
            else if (y1 > 449 && y1 < 490)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 10, X2 += 10, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Blue, CV);
                }
            }
            else if (y1 > 399 && y1 < 450)
            {
                int X1 = 50; int Y1 = 150;
                int X2 = 100; int Y2 = 300; int Y3 = 450;
                for (; X2 < 250; X1 += 9, X2 += 9, Y1 -= 10, Y3 += 10)
                {
                    Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2); Point XY3 = new Point(X1, Y3);
                    Point[] CV = { XY1, XY2, XY3 };
                    RT.DrawCurve(Pens.Purple, CV);
                }
            }
        
        
        
        
         if (y1 > 634 && y1 < 700)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Red, XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Red, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Red, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Red, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Red, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Red, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Red, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Red, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Red, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


                    }


                }
                else if (y1 > 589 && y1 < 635)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Orange, XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Orange, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Orange , XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Orange, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Orange, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Orange, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Orange, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Orange, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Orange, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


                    }



                }

                else if (y1 > 559 && y1 < 590)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Yellow , XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Yellow, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Yellow, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Yellow, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Yellow, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Yellow, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Yellow, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Yellow, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Yellow, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


                    }


                }
                else if (y1 > 519 && y1 < 560)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Green , XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Green, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Green, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Green, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Green, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Green, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Green, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Green, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Green, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);

                    }


                }
                else if (y1 > 489 && y1 < 520)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Aqua , XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Aqua, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Aqua, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Aqua, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Aqua, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Aqua, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Aqua, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Aqua, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Aqua, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


                    }


                }
                else if (y1 > 449 && y1 < 520)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Blue , XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);

                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Blue, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Blue, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Red, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Blue, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Blue, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Blue, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Blue, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Blue, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


                    }


                }
                else if (y1 > 399 && y1 < 460)
                {
                    int xs1 = int.Parse(xs.Text);
                    //label31.Text = "تداخل بناء"; label31.ForeColor();
                    xs1 *= -1;
                    int X1 = 350; int Y1 = 200; int X2 = 799; int Y2 = 10;
                    int X3 = 360; int Y3 = 225; int X4 = 799; int Y4 = 60;
                    for (; Y1 < 550; Y1 += 50, Y2 += 100, Y3 += 50, Y4 += 100)
                    {
                        Point XY1 = new Point(X1, Y1); Point XY2 = new Point(X2, Y2);
                        Point XY3 = new Point(X3, Y3); Point XY4 = new Point(X4, Y4);
                        RT.DrawLine(Pens.Purple , XY1, XY2); RT.DrawLine(Pens.Black, XY3, XY4);
                    
                    }
                    int X5 = 850; int Y5 = 0; int X6 = 900; int Y6 = 50; int Y7 = 100; int Y8 = 150; int Y9 = 200; int Y10 = 250; int Y11 = 300; int Y12 = 350; int Y13 = 400; int Y14 = 450; int Y15 = 500; int Y16 = 550; int Y17 = 600; int Y18 = 650; int Y19 = 650;

                    for (; Y5 < 50; Y5 += xs1, Y6 += xs1, Y7 += xs1, Y8 += xs1, Y9 += xs1, Y10 += xs1, Y11 += xs1, Y12 += xs1, Y13 += xs1, Y14 += xs1, Y15 += xs1, Y16 += xs1, Y17 += xs1, Y18 += xs1, Y19 += xs1)
                    {
                        Point XY1 = new Point(X5, Y5); Point XY2 = new Point(X6, Y5); Point XY4 = new Point(X5, Y6); Point XY3 = new Point(X6, Y6); RT.DrawLine(Pens.Purple, XY1, XY2); RT.DrawLine(Pens.Black, XY4, XY3);

                        Point XY5 = new Point(X5, Y7); Point XY6 = new Point(X6, Y7); Point XY7 = new Point(X5, Y8); Point XY8 = new Point(X6, Y8); RT.DrawLine(Pens.Black, XY8, XY7); RT.DrawLine(Pens.Purple, XY5, XY6);
                        Point XY9 = new Point(X5, Y9); Point XY10 = new Point(X6, Y9); Point XY11 = new Point(X5, Y10); Point XY12 = new Point(X6, Y10); RT.DrawLine(Pens.Black, XY11, XY12); RT.DrawLine(Pens.Purple, XY10, XY9);
                        Point XY13 = new Point(X5, Y11); Point XY14 = new Point(X6, Y11); Point XY15 = new Point(X5, Y12); Point XY16 = new Point(X6, Y12); RT.DrawLine(Pens.Purple, XY13, XY14); RT.DrawLine(Pens.Black, XY15, XY16);
                        Point XY17 = new Point(X5, Y13); Point XY18 = new Point(X6, Y13); Point XY19 = new Point(X5, Y14); Point XY20 = new Point(X6, Y14); RT.DrawLine(Pens.Purple, XY17, XY18); RT.DrawLine(Pens.Black, XY19, XY20);
                        Point XY21 = new Point(X5, Y15); Point XY22 = new Point(X6, Y15); Point XY23 = new Point(X5, Y16); Point XY24 = new Point(X6, Y16); RT.DrawLine(Pens.Purple, XY21, XY22); RT.DrawLine(Pens.Black, XY23, XY24);
                        Point XY25 = new Point(X5, Y17); Point XY26 = new Point(X6, Y17); RT.DrawLine(Pens.Purple, XY25, XY26); Point XY27 = new Point(X5, Y18); Point XY28 = new Point(X6, Y18); RT.DrawLine(Pens.Purple, XY25, XY26);
                        Point XY29 = new Point(X5, Y19); Point XY30 = new Point(X6, Y19); RT.DrawLine(Pens.Black, XY29, XY30);


           }

        }
        
        
        
        
        
        
        
        
        
        }
            //Equation
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ym.Text) || string.IsNullOrWhiteSpace(ymy.Text) || string.IsNullOrWhiteSpace(xm.Text) || string.IsNullOrWhiteSpace(xmx.Text) || string.IsNullOrWhiteSpace(dm.Text) || string.IsNullOrWhiteSpace(dmd.Text) || string.IsNullOrWhiteSpace(Lm.Text) || string.IsNullOrWhiteSpace(LmL.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
         
            int tt = 10;
            

            if (ym.Text=="?" || ymy.Text=="?" )
            {
                double xm1 = Convert.ToDouble(xm.Text); double xm2 = Convert.ToDouble(xmx.Text); double xm3 = Math.Pow(tt, xm2); double xm4 = xm1 * xm3;
                double dm1 = Convert.ToDouble(dm.Text); double dm2 = Convert.ToDouble(dmd.Text); double dm3 = Math.Pow(tt, dm2); double dm4 = dm1 * dm3;
                double Lm1 = Convert.ToDouble(Lm.Text); double Lm2 = Convert.ToDouble(LmL.Text); double Lm3 = Math.Pow(tt, Lm2); double Lm4 = Lm1 * Lm3;
                double ym4 = xm4 * dm4 / Lm4;
                law1.Text = @"y = xd \ L";
                law2.Text = @"y = "+"("+xm4+")"+" X "+"("+dm4+")"+"/"+"("+Lm4+")" ;
                law3.Text = ""+ym4 +"";

                
            }
            else if (xm.Text=="?"  || xmx.Text=="?" )
            {
                double ym1 = Convert.ToDouble(ym.Text); double ym2 = Convert.ToDouble(ymy.Text); double ym3 = Math.Pow(tt, ym2); double ym4 = ym1 * ym3;
                double dm1 = Convert.ToDouble(dm.Text); double dm2 = Convert.ToDouble(dmd.Text); double dm3 = Math.Pow(tt, dm2); double dm4 = dm1 * dm3;
                double Lm1 = Convert.ToDouble(Lm.Text); double Lm2 = Convert.ToDouble(LmL.Text); double Lm3 = Math.Pow(tt, Lm2); double Lm4 = Lm1 * Lm3;
                double xm4 = dm4 / Lm4 * ym4;
                law1.Text = @"x = d \ Ly";
                law2.Text = @"x = " + "(" + dm4 + ")" + "/" + "(" + Lm4 + ")" + "X" + "(" + ym4 + ")";
                law3.Text = "" + xm4 + ""; 


            }
              else if (dm.Text=="?"  || dmd.Text=="?" )
            {
                double ym1 = Convert.ToDouble(ym.Text); double ym2 = Convert.ToDouble(ymy.Text); double ym3 = Math.Pow(tt, ym2); double ym4 = ym1 * ym3;
                double xm1 = Convert.ToDouble(xm.Text); double xm2 = Convert.ToDouble(xmx.Text); double xm3 = Math.Pow(tt, xm2); double xm4 = xm1 * xm3;
                double Lm1 = Convert.ToDouble(Lm.Text); double Lm2 = Convert.ToDouble(LmL.Text); double Lm3 = Math.Pow(tt, Lm2); double Lm4 = Lm1 * Lm3;
                double dm4 = xm4 / Lm4 * ym4;
                law1.Text = @"d = x \ Ly";
                law2.Text = @"d = " + "(" + xm4 + ")" + "/" + "(" + Lm4 + ")" + "X" + "(" + ym4 + ")";
                law3.Text = "" + dm4 + ""; 


            }
            else if (Lm.Text == "?" || LmL.Text == "?")
            {
                double ym1 = Convert.ToDouble(ym.Text); double ym2 = Convert.ToDouble(ymy.Text); double ym3 = Math.Pow(tt, ym2); double ym4 = ym1 * ym3;
                double xm1 = Convert.ToDouble(xm.Text); double xm2 = Convert.ToDouble(xmx.Text); double xm3 = Math.Pow(tt, xm2); double xm4 = xm1 * xm3;
                double dm1 = Convert.ToDouble(dm.Text); double dm2 = Convert.ToDouble(dmd.Text); double dm3 = Math.Pow(tt, dm2); double dm4 = dm1 * dm3;
                double Lm4 = xm4 * dm4 / ym4;
                law1.Text = @"L = xd \ y";
                law2.Text = @"L = " + "(" + xm4 + ")" + " X " + "(" + dm4 + ")" + "/" + "(" + ym4 + ")";
                law3.Text = "" + Lm4 + "";
            } if (ymy.Text != "?")
            { int x1 = int.Parse(ymy.Text); if (x1 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; } }
            else if (LmL.Text != "?")
            {
                int LL2 = int.Parse(LmL.Text); if (LL2 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; }}
            else if (xmx.Text !="?")
            { int xx1 = int.Parse(xmx.Text); if (xx1 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; }}
            else if (dmd.Text != "?")
            { int dda1 = int.Parse(dmd.Text); if (dda1 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; } }
         
            }
      
        //?


        private void button_DRAW_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(y.Text) || string.IsNullOrWhiteSpace(x.Text) || string.IsNullOrWhiteSpace(xs.Text) || string.IsNullOrWhiteSpace(d.Text) || string.IsNullOrWhiteSpace(ds.Text) || string.IsNullOrWhiteSpace(Ls.Text) || string.IsNullOrWhiteSpace(L.Text)) { MessageBox.Show("يجب تعبئة جبيع البيانات "); return; }

            int yt = int.Parse(y.Text); if (yt > 700 || yt < 400) { MessageBox.Show("استعمل ارقام مابين 700-400"); return; }

            int LL1 = int.Parse(Ls.Text); if (LL1 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; }
            int xx = int.Parse(xs.Text); if (xx > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; }
            int dda = int.Parse(ds.Text); if (dda > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; }

            Graphics RT = pictureBox1.CreateGraphics();
            //gdi

            string ff = "y";
            Font fo = new Font("Arial", 36);
            SolidBrush fb = new SolidBrush(Color.Black);
            Point f1 = new Point(30, 250);
            RT.DrawString(ff, fo, fb, f1);

            string fx = "d";
            Font fxx = new Font("Arial", 36);
            SolidBrush fxxx = new SolidBrush(Color.Black);
            Point fx1 = new Point(260, 280);
            RT.DrawString(fx, fxx, fxxx, fx1);

            Point ll = new Point(300, 800); Point lll = new Point(799, 800); RT.DrawLine(Pens.Black, ll, lll);
            string fl = "L";
            Font fxl = new Font("Arial", 36);
            SolidBrush fxxl = new SolidBrush(Color.Black);
            Point fll = new Point(650, 700);
            RT.DrawString(fl, fxl, fxxl, fll);

            Point xlx = new Point(900, 0); Point xxx = new Point(980, 0); RT.DrawLine(Pens.Black, xlx, xxx); Point x2x = new Point(900, 100); Point xxx2 = new Point(980, 100); RT.DrawLine(Pens.Black, x2x, xxx2); Point x3x = new Point(1300, 100); Point xxx3 = new Point(1300, 0); RT.DrawLine(Pens.Black, x3x, xxx3);


            string xfl = "x";
            Font xxl = new Font("Arial", 36);
            SolidBrush xxxl = new SolidBrush(Color.Black);
            Point xll = new Point(980, 50);
            RT.DrawString(xfl, xxl, xxxl, xll);

            //Twofold
            RT.DrawRectangle(Pens.Black, 250, 0, 50, 200); RT.DrawRectangle(Pens.Black, 250, 400, 50, pictureBox1.Height);

            //Y
            int y1 = int.Parse(y.Text);


            //d
            int tt = 10;
            double d1 = Convert.ToDouble(d.Text); double ds1 = Convert.ToDouble(ds.Text); double d4 = Math.Pow(tt, ds1); if (ds1 > 0) { MessageBox.Show("استعمل ارقام اصغر من الصفر"); return; };
            d1 *= d4;
            double d2 = 20 - d1;
            float d3 = (float)d2 * 20;
            RT.DrawRectangle(Pens.Red, 250, d3 - 150, 50, d3 - 300);

            //L
            //secren
            SolidBrush Fill = new SolidBrush(Color.Gray);
            RT.DrawRectangle(Pens.Black, 800, 0, 50, pictureBox1.Height); RT.FillRectangle(Fill, 800, 0, 50, pictureBox1.Height);

            lop();
        }

                //X1

               

        private void button_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void y_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1  jk = new Form1 ();
            jk.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //  just number
        private void y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void xs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void L_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Ls_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ym_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ymy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void xm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void xmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Lm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void LmL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Young_Try_Load(object sender, EventArgs e)
        {
            
        }

        private void ymy_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
