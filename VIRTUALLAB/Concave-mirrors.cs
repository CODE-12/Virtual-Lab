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
    public partial class Concave_mirrors : MetroForm
    {
        public Concave_mirrors()
        {
            InitializeComponent();
        }

        private void Concave_mirrors_Load(object sender, EventArgs e)
        {
           
        }
          public int sa=15;
        public int df = 210;
        public int FX;
        public float X;


        public void check()
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }
            int mood = int.Parse(mod.Text);

            float x1 = 0;
            float y1 = 0;
            float x2 = x1;
            float y2 = pictureBox1.Height;
            for (x1 = 0; x1 < pictureBox1.Width; x1 += mood, x2 += mood)
            {

                Graphics d = pictureBox1.CreateGraphics();
                d.DrawLine(Pens.DarkGray, x1, y1, x2, y2);
            }

            float x3 = 0;
            float y3 = 0;
            float x4 = pictureBox1.Width;
            float y4 = y3;
            for (y3 = 0; y3 < pictureBox1.Height; y3 += mood, y4 += mood)
            {
                Graphics d = pictureBox1.CreateGraphics();
                d.DrawLine(Pens.DarkGray, x3, y3, x4, y4);

            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { check(); }
            else if (!checkBox1.Checked) { pictureBox1.Refresh(); }
        }
        public void ask()
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }
            int DD = Convert.ToInt32(D.Text);
            int FF = int.Parse(F.Text);
            float j = 1.75F;
            int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text)*2;
            float X1 = (500 + df) - DD * mood + 2;
            float Y1 = FF * modd + 120 - j * mood;
            float X2 = (500 + df) - FF * mood;
            float c1 = 500 + df;
            float c2 = FF * 45 ;
            float Y2 = FF * 2 * mood + 120;
            float M = (Y2 - Y1) / (X2 - X1);
            float X3 = 500 + df;
            float Y3 = (M * (X2 - X3)) - Y2;//EDITED BY YOSEF -_-
            float x4 = 0;
            float C3 = (500 + df) + DD * 25 +3;

            Y3 *= -1;

            Graphics MS = pictureBox1.CreateGraphics();
            //MS
            float xx1 = 500 + df;
            float yy1 = FF * modd + 120 - j * mood;
            PointF MS1 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS2 = new PointF((500 + df) - DD * mood + 2, FF * 2 * mood + 120);
            MS.DrawLine(Pens.Cyan, MS1, MS2);
            PointF MS3 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS4 = new PointF(xx1, yy1);
            MS.DrawLine(Pens.Red, MS3, MS4);
            ////1

            float XX2 = 500 + df - FF * mood;
            float YY2 = FF * 2 * mood + 120;
            float mm = (YY2 - yy1) / (XX2 - xx1);
            float yy3 = (500 + df) + FF * 4;
            float xx3 = (mm * (XX2)) - (yy3 - YY2);
            if (FF == 7)
            {
                yy3 -= 50;
                PointF pp = new PointF(XX2, YY2);
                MS.DrawLine(Pens.Red, pp, MS4);
                MS.DrawLine(Pens.Red, xx3, yy3 , XX2, YY2);

            }
            else if (FF != 7)
            {
                PointF pp = new PointF(XX2, YY2);
                MS.DrawLine(Pens.Red, pp, MS4);
                MS.DrawLine(Pens.Red, xx3, yy3, XX2, YY2);
            }


            MS.DrawLine(Pens.DarkBlue, c1, c2, X1, Y1);//to F1
            MS.DrawLine(Pens.DarkBlue, new PointF( X3, c2), new PointF(x4, c2));

            MS.DrawLine(Pens.Purple , c1, c2, C3, c2); MS.DrawLine(Pens.Purple ,C3,c2,c1,Y1);
            MS.DrawLine (Pens.LimeGreen ,C3,Y2,C3, c2);
            
        }
        public void ak()
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }


            int DD = Convert.ToInt32(D.Text);            int mood = int.Parse(mod.Text );

            int FF = int.Parse(F.Text);
            float j = 1.75F;
            int modd = int.Parse(mod.Text)*2;
            float X1 = (500 + df) - DD * mood + 2;
            float Y1 = FF * modd + 120 - j * mood;
            float X2 = (500 + df) - FF * mood;
            float Y2 = FF * 2 * mood + 120;
            float M = (Y2 - Y1) / (X2 - X1);
            float X3 = 500 + df;
            float Y3 = (M * (X2 - X3)) - Y2;//EDITED BY YOSEF -_-
            float x4 = 0;
            Y3 *= -1;

            Graphics MS = pictureBox1.CreateGraphics();
            //MS
            float xx1 = 500 + df;
            float yy1 = FF * modd + 120 - j * mood;
            PointF MS1 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS2 = new PointF((500 + df) - DD * mood + 2, FF * 2 * mood + 120);
            MS.DrawLine(Pens.Cyan, MS1, MS2);
            PointF MS3 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS4 = new PointF(xx1, yy1);
            MS.DrawLine(Pens.Red, MS3, MS4);
            //1

            float XX2 = 500 + df - FF * mood;
            float YY2 = FF * 2 * mood + 120;
            float mm = (YY2 - yy1) / (XX2 - xx1);
            float yy3 = (500 + df) + FF * 4;
            float xx3 = (mm * (XX2)) - (yy3 - YY2);

            {
                if (FF == 7)
                {
                    yy3 -= 50;
                    PointF pp = new PointF(XX2, YY2);
                    MS.DrawLine(Pens.Red, pp, MS4);
                    MS.DrawLine(Pens.Red, xx3, yy3, XX2, YY2);

                }
                else if (FF != 7)
                {
                    PointF pp = new PointF(XX2, YY2);
                    MS.DrawLine(Pens.Red, pp, MS4);
                    MS.DrawLine(Pens.Red, xx3, yy3, XX2, YY2);
                }


                MS.DrawLine(Pens.DarkBlue, X2, Y2, X1, Y1);//to F1
                MS.DrawLine(Pens.DarkBlue, new PointF(X2, Y2), new PointF(X3, Y3));//from f1 to endless    EDITED BY YOSEF-_-Fgtti
                MS.DrawLine(Pens.DarkBlue, x4, Y3, X3, Y3);

              
            }
        }
        public void ben()
        {


            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }

            int DD = int.Parse (D.Text);
            int FF = int.Parse(F.Text);
            float j = 1.75F; int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text) * 2;


            float X1 = (500 + df) - DD * mood + 2;
            float Y1 = FF * modd + 120 - j * mood;
            float X2 = (500 + df) - FF * mood;
            float Y2 = FF * 2 * mood + 120;
            float M = (Y2 - Y1) / (X2 - X1);
            float X3 = 500 + df;
            float Y3 = (M * (X2 - X3)) - Y2;//EDITED BY YOSEF -_-
            float x4 = 0;
            Y3 *= -1;

            Graphics MS = pictureBox1.CreateGraphics();
            //MS
            float xx1 = 500 + df;
            float yy1 = FF * modd + 120 - j * mood;
            PointF MS1 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS2 = new PointF((500 + df) - DD * mood + 2, FF * 2 * mood + 120);
            MS.DrawLine(Pens.Cyan, MS1, MS2);
            PointF MS3 = new PointF((500 + df) - DD * mood + 2, FF * modd + 120 - j * mood);
            PointF MS4 = new PointF(xx1, yy1);
            MS.DrawLine(Pens.Red, MS3, MS4);
            //1

            float XX2 = 500 + df - FF * mood;
            float YY2 = FF * 2 * mood + 120;
            float mm = (YY2 - yy1) / (XX2 - xx1);
            float yy3 = (500 + df) + FF * 4;
            float xx3 = (mm * (XX2)) - (yy3 - YY2);

            if (FF == 7)
            {
                yy3 -= 50;
                PointF pp = new PointF(XX2, YY2);
                MS.DrawLine(Pens.Red, pp, MS4);
                MS.DrawLine(Pens.Red, xx3, yy3, XX2, YY2);

            }
            else if (FF != 7)
            {
                PointF pp = new PointF(XX2, YY2);
                MS.DrawLine(Pens.Red, pp, MS4);
                MS.DrawLine(Pens.Red, xx3, yy3, XX2, YY2);
            }

            MS.DrawLine(Pens.DarkBlue, X2, Y2, X1, Y1);//to F1
            MS.DrawLine(Pens.DarkBlue, new PointF(X2, Y2), new PointF(X3, Y3));//from f1 to endless    EDITED BY YOSEF-_-Fgtti
            MS.DrawLine(Pens.DarkBlue, x4, Y3, X3, Y3);

        }

       

       
        private void button_delet_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            la1.Text = "...";
            lab2.Text = "...";
            lab3.Text = "...";
        }

       

      
        
        private void button_other_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DF = new Form1();
            DF.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void F_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void F_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ff_DoubleClick(object sender, EventArgs e){ ff.Text = "?";}    private void dod_DoubleClick(object sender, EventArgs e) { dod.Text = "?"; } private void di_DoubleClick(object sender, EventArgs e){ di.Text = "?";}

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ff.Text == "?") { double doo = Convert.ToDouble(dod.Text); double dii = Convert.ToDouble(di.Text); double ff2 = 1 / doo + 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "f = 1/do + 1/di" + "\n" + "\n" + "f = " + "1/" + dod + " + 1/" + dii + "\n" + "\n" + "f =" + finly; }
            else if (dod.Text == "?") { double doo = Convert.ToDouble(ff.Text); double dii = Convert.ToDouble(di.Text); double ff2 = 1 / doo - 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "do = 1/f - 1/di" + "\n" + "\n" + "\n" + "\n" + "do =" + finly; }
            else if (di.Text == "?") { double doo = Convert.ToDouble(ff.Text); double dii = Convert.ToDouble(dod.Text); double ff2 = 1 / doo - 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "di = 1/f - 1/do" + "\n" + "\n" + "di = " + "1/" + dod + " + 1/" + dii + "\n" + "\n" + "di =" + finly; }

        }
        private void ho_DoubleClick(object sender, EventArgs e)
        {
            ho.Text = "?";
        }

        private void hi_DoubleClick(object sender, EventArgs e)
        {
            hi.Text = "?";
        }

        private void ddo_DoubleClick(object sender, EventArgs e)
        {
            ddo.Text = "?";
        }

        private void did_DoubleClick(object sender, EventArgs e)
        {
            did.Text = "?";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ho.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id / ih * od; double finly = Math.Pow(mm, -1); la2.Text = "ho = -di / hi* do" + "\n" + "ho = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m"; }// float fi = (float)finly; mmm.Text = "" + fi; }
            else if (hi.Text == "?") { double ih = Convert.ToDouble(ho.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id * ih / od; la2.Text = "hi =  hi*(-di) / do" + "\n" + "hi = " + -id * ih + " / " + od + "\n" + "hi = " + mm + "m";}// float fi = (float)mm; mmm.Text = "" + fi; }
            else if (ddo.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ho.Text); double id = Convert.ToDouble(did.Text); double mm = -id * od / ih; double finly = Math.Pow(mm, -1); la2.Text = "do = -di / hi* do" + "\n" + "do = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m";}// float fi = (float)finly; mmm.Text = "" + fi; }
            else if (did.Text == "?") { double ih = Convert.ToDouble(ho.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(hi.Text); double mm = od * id / ih; la2.Text = "di =  hi*(do) / ho" + "\n" + "ho = " + -id * ih + " / " + od + "\n" + "di = " + mm + "m";}// float fi = (float)mm; mmm.Text = "" + fi; }

        }

        private void ff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void dod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void di_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void ho_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void hi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ddo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

        private void did_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }
        }

      

       
        private void F_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labe1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            labe1.Text = "الحل";

        }

        private void label21_Click(object sender, EventArgs e)
        {
            la2.Text = "الحل";

        }

        private void mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled
                    = true;
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            X = e.X; if (string.IsNullOrWhiteSpace(mod.Text)) { return; }

            base.OnMouseClick(e);
            Graphics fc = pictureBox1.CreateGraphics();
            X = e.X;

            int mood = int.Parse(mod.Text);
            int DD = Convert.ToInt32(D.Text); int modd = int.Parse(mod.Text) * 2;
            int FF = int.Parse(F.Text); float j = 1.75F;
            float X1 = (500 + df) - DD * mood + 2;
            float Y1 = FF * modd + 120 - j * mood;
            float X2 = (500 + df) - FF * mood;
            float Y2 = FF * 2 * mood + 120;
            float M = (Y2 - Y1) / (X2 - X1);
            float X3 = 500 + df;
            float Y3 = (M * (X2 - X3)) - Y2;//EDITED BY YOSEF -_-
            float fff = FF * 2 * mood + 120;
            Y3 *= -1;
            //4
            if (1 + FF > FF) { PointF VC1 = new PointF(X, Y3); PointF VC2 = new PointF(X, fff); fc.DrawLine(Pens.LimeGreen, VC1, VC2); }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
           


        }

        private void button_draw_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }

            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text))
                return; int DD = int.Parse(D.Text);
            int FF = int.Parse(F.Text);
            if (FF < 4 || FF > 7)
            {
                F.Clear();
                D.Clear();
                MessageBox.Show("الرجاء اختيار رقم بين 4و7");
                return;
            }
            if (DD > 3 * FF)
            {
                MessageBox.Show(" بقية الحالات بعد العدد " + 3 * FF + " سوف تكون نفس الصفات "); return;
            }
            if (FF > DD)
            {
                ask();
            }
            else if (FF < DD || DD > FF * 2 || DD < 2 * FF)
            {
                ben();
            }

            int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text) * 2;


            //A,B
            Graphics AB = pictureBox1.CreateGraphics();
            //A
            Point A1 = new Point((500 + df), 120);
            //AB.FillEllipse(Brushes.LimeGreen, 500, 120, mood0, mood0);
            Point A2 = new Point((500 + df), FF * 4 * mood + 120);
            AB.DrawLine(Pens.Black, A1, A2);
            //B
            Point B1 = new Point(0, FF * 2 * mood + 120);
            Point B2 = new Point(pictureBox1.Width, FF * 2 * mood + 120);
            AB.DrawLine(Pens.Black, B1, B2);



            //curve1
            Graphics c = pictureBox1.CreateGraphics();
            Point c1 = new Point((470 + df) - FF * 4, 120);
            Point c2 = new Point((490 + df), FF * modd + 120);
            Point c3 = new Point((470 + df) - FF * 4, FF * 2 * modd + 120);
            Point[] cp = { c1, c2, c3 };
            c.DrawCurve(Pens.SkyBlue, cp);

            //curve2
            Graphics cu = pictureBox1.CreateGraphics();
            Point cu1 = new Point((500 + df) - FF * 2, 120);
            Point cu2 = new Point((520 + df), FF * modd + 120);
            Point cu3 = new Point((500 + df) - FF * 2, FF * 2 * modd + 120);
            Point[] cup = { cu1, cu2, cu3 };
            cu.DrawCurve(Pens.SkyBlue, cup);
            //lion
            cu.DrawLine(Pens.SkyBlue, cu1, c1);
            cu.DrawLine(Pens.SkyBlue, cu3, c3);





            //F
            Graphics f = pictureBox1.CreateGraphics();
            string ff = "F";
            Font fo = new Font("Arial", 12);
            SolidBrush fb = new SolidBrush(Color.Black);
            Point f1 = new Point((500 + df) - FF * mood - 5, FF * 2 * mood + 120);
            f.DrawString(ff, fo, fb, f1);
            //C

            Graphics fc = pictureBox1.CreateGraphics();
            string cc = "C";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            Point cc1 = new Point((500 + df) - FF * modd - 5, FF * 2 * mood + 120);
            f.DrawString(cc, co, cb, cc1);

        }

        private void linkLabel4_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text))
            {

                return;
            }

            int DD = int.Parse(D.Text);
            int FF = int.Parse(F.Text);

            if (FF < DD && DD < FF * 2)
            {
                //label
                la1.Text = "مكبرة";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
            }
            else if (2 * FF < DD)
            {
                //label
                la1.Text = "مصغرة";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
            }
            else if (2 * FF == DD)
            {
                //label
                la1.Text = "متساوية";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
            }
            else if (FF > DD)
            {
                //label
                la1.Text = "مكبرة";
                lab2.Text = "معتدلة";
                lab3.Text = "خيالية";

            }
            else if (FF == DD)
            {
                //label
                la1.Text = "لايوجد";
                lab2.Text = "لايوجد";
                lab3.Text = "لايوجد";
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            la1.Text = "...";
            lab2.Text = "...";
            lab3.Text = "...";
        }

       

     
            
        
           
        
    }
}
