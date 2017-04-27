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
    public partial class Concave : MetroForm
    {public int df =210;
  public   float X;

        public Concave()
        {
            InitializeComponent(); 
        }
        public void check()
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }
            int mood = int.Parse(mod.Text);
            int modd = int.Parse(mod.Text) * 2;
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
       
        public void ASK()
        {
            int DD = int.Parse(D.Text); int FF = int.Parse(F.Text); float j = 1.75F; int mood = int.Parse(mod.Text);
            int modd = int.Parse(mod.Text) * 2;
            Graphics MS = pictureBox1.CreateGraphics();
            float mm1 = (500 + df) + DD * mood + 3; float ss1 = FF * 2 * mood + 120; float mm2 = (505 + df); float mm3 = (500 + df) - DD * mood + 3; float M1 = mm2 + FF * mood; float S1 = ss1 - j * mood; float sm = (ss1 - S1) / (M1 - mm1); float ss2 = (sm * (M1 - mm2)) - ss1; float M2 = mm2 + FF * mood; float M = (ss1 - S1) / (M2 - mm2); float mm4 = (M * (M2)) - (pictureBox1.Height - ss1);
            PointF MS1 = new PointF(mm1, ss1); PointF MS2 = new PointF(mm1, ss1 - j * mood); MS.DrawLine(Pens.Cyan, MS1, MS2);
            PointF MS3 = new PointF(mm2, ss1 - j * mood); MS.DrawLine(Pens.Red, MS3, MS2); PointF MS4 = new PointF(mm2 - FF * mood, ss1); MS.DrawLine(Pens.Red, MS3, MS4);
            if (FF == 4) { PointF MS8 = new PointF(mm4, pictureBox1.Height - (230+mood) ); MS.DrawLine(Pens.Red, MS8, MS4); }
            else if (FF == 5) { PointF MS8 = new PointF(mm4, pictureBox1.Height - 280+mood ); MS.DrawLine(Pens.Red, MS8, MS4); }
            else if (FF == 6) { PointF MS8 = new PointF(mm4, pictureBox1.Height - 330+mood ); MS.DrawLine(Pens.Red, MS8, MS4); }
            else if (FF == 7) { PointF MS8 = new PointF(mm4, pictureBox1.Height - 380+mood ); MS.DrawLine(Pens.Red, MS8, MS4); }
            PointF MS5 = new PointF(mm2, ss1 - FF * 30); MS.DrawLine(Pens.Blue, MS5, MS2); 
            PointF MS6 = new PointF(0, ss1 - FF * 30); MS.DrawLine(Pens.Blue, MS5, MS6); PointF MS7 = new PointF(mm2 + DD * 50, ss1 - FF * 30); MS.DrawLine(Pens.Purple, MS3, MS7); MS.DrawLine(Pens.Purple, MS5, MS7);
            PointF MS9 = new PointF(mm2 + DD * 50, ss1); MS.DrawLine(Pens.LimeGreen, MS9, MS7);
            L5.Text = "مسار الشعاعين";
            
        }
        public void Ben()
        {
            int DD = int.Parse(D.Text); int FF = int.Parse(F.Text); float j = 1.75F; int mood = int.Parse(mod.Text);
            int modd = int.Parse(mod.Text) * 2;

            Graphics MS = pictureBox1.CreateGraphics();
            float mm1 = (500 + df) + DD * mood + 3; float ss1 = FF * 2 * mood + 120; float mm2 = (505 + df); float mm3 = (500 + df) - DD * mood + 3; float M1 = mm2 + FF * mood; float S1 = ss1 - j * mood; float sm = (ss1  - S1 ) / (M1 - mm1); float ss2 = (sm * (M1 -mm2)) - ss1; ss2 *= -1; float M2 = mm2 + FF * mood;float M = (ss1 - S1) / (M2-mm2);float mm4 = (M * (M2)) - (pictureBox1.Height - ss1);


            PointF MS1 = new PointF(mm1, ss1); PointF MS2 = new PointF(mm1, ss1 - j * mood); MS.DrawLine(Pens.Cyan,MS1,MS2);
            PointF MS3 = new PointF(mm2, ss1 - j * mood); MS.DrawLine(Pens.Red, MS3, MS2); PointF MS4 = new PointF(mm2 - FF * mood, ss1); MS.DrawLine(Pens.Red, MS3, MS4);
            if (FF == 4) { PointF MS8 = new PointF(mm4, 900 - 250 ); MS.DrawLine(Pens.Red, MS8, MS4); }
       else if (FF == 5) { PointF MS8 = new PointF(mm4, 900 - 330 ); MS.DrawLine(Pens.Red, MS8, MS4); }
       else if (FF == 6) { PointF MS8 = new PointF(mm4, 900 - 380); MS.DrawLine(Pens.Red, MS8, MS4); }
       else if (FF == 7) { PointF MS8 = new PointF(mm4, 900 - 400 ); MS.DrawLine(Pens.Red, MS8, MS4); }

            PointF MS5 = new PointF(mm2 + FF * mood, ss1); MS.DrawLine(Pens.Blue, MS5, MS2); PointF MS6 = new PointF(mm2, ss2); MS.DrawLine(Pens.Blue, MS5, MS6);PointF MS7 = new PointF(0,ss2); MS.DrawLine(Pens.Blue, MS7, MS6);
          
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            


        }
       
       
      
        private void Concave_Load(object sender, EventArgs e)
        {
        }

       



       

        private void button_delet_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            la1.Text = "...";
            lab2.Text = "...";
            lab3.Text = "...";
           
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button_other_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 DF = new Form1();
            DF.ShowDialog();
            this.Close();
        }

        private void button_draw_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text) || string.IsNullOrWhiteSpace(mod.Text))
                return;
            int mood = int.Parse(mod.Text);
            int modd = int.Parse(mod.Text)*2;

            int DD = int.Parse(D.Text);
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
                MessageBox.Show(" بقية الحالات بعد العدد " + 3 * FF + " سوف تكون نفس الصفات ");
                return;
            }
            if (FF > DD)
            {
                ASK();
            }

            else if (FF < DD || DD > FF * 2 || DD < 2 * FF) { Ben(); }

            //A,B
            Graphics AB = pictureBox1.CreateGraphics();
            //A
            Point A1 = new Point((500 + df) + 5, 120);
            Point A2 = new Point((500 + df) + 5, FF * 4 * mood + 120);
            AB.DrawLine(Pens.Black, A1, A2);
            //B
            Point B1 = new Point(0, FF * 2 * mood + 120);
            Point B2 = new Point(pictureBox1.Width, FF * 2 * mood + 120);
            AB.DrawLine(Pens.Black, B1, B2);


            //or

            //curve1
            Graphics c = pictureBox1.CreateGraphics();
            Point c1 = new Point((495 + df), 120);
            Point c2 = new Point(475 + df, FF * modd + 120);
            Point c3 = new Point((495 + df), FF * 2 * modd + 120);
            Point[] cp = { c1, c2, c3 };
            c.DrawCurve(Pens.SkyBlue, cp);

            //curve2
            Graphics cu = pictureBox1.CreateGraphics();
            Point cu1 = new Point((515 + df), 120);
            Point cu2 = new Point((535 + df), FF * modd + 120);
            Point cu3 = new Point((515 + df), FF * 2 * modd + 120);
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
            Point f1 = new Point((500 + df) + FF * mood + 1, FF * 2 * mood + 120);
            f.DrawString(ff, fo, fb, f1);
            //C

            Graphics fc = pictureBox1.CreateGraphics();
            string cc = "2F";
            Font co = new Font("Arial", 12);
            SolidBrush cb = new SolidBrush(Color.Black);
            Point cc1 = new Point((500 + df) + FF * modd - 10, FF * 2 * mood + 120);
            f.DrawString(cc, co, cb, cc1);


            //F

            string ff1 = "F";
            Font fo1 = new Font("Arial", 12);
            SolidBrush fb1 = new SolidBrush(Color.LimeGreen);
            Point f11 = new Point((500 + df) - FF * mood + 3, FF * 2 * mood + 120);
            f.DrawString(ff1, fo1, fb1, f11);
            //C

            Graphics fc1 = pictureBox1.CreateGraphics();
            string cc12 = "2F";
            Font co11 = new Font("Arial", 12);
            SolidBrush cb1 = new SolidBrush(Color.LimeGreen);
            Point cc11 = new Point((500 + df) - FF * modd - 5, FF * 2 * mood + 120);
            f.DrawString(cc12, co11, cb1, cc11);
            //shp
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ff.Text == "?") { double doo = Convert.ToDouble(dod.Text); double dii = Convert.ToDouble(di.Text); double ff2 = 1 / doo + 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "f = 1/do + 1/di" + "\n" + "\n" + "f = " + "1/" + dod + " + 1/" + dii + "\n" + "\n" + "f =" + finly; }
            else if (dod.Text == "?") { double doo = Convert.ToDouble(ff.Text); double dii = Convert.ToDouble(di.Text); double ff2 = 1 / doo - 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "do = 1/f - 1/di" + "\n" + "\n" + "\n" + "\n" + "do =" + finly; }
            else if (di.Text == "?") { double doo = Convert.ToDouble(ff.Text); double dii = Convert.ToDouble(dod.Text); double ff2 = 1 / doo - 1 / dii; double finly = Math.Pow(ff2, -1); labe1.Text = "di = 1/f - 1/do" + "\n" + "\n" + "di = " + "1/" + dod + " + 1/" + dii + "\n" + "\n" + "di =" + finly; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ho.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id / ih * od; double finly = Math.Pow(mm, -1); la2.Text = "ho = -di / hi* do" + "\n" + "ho = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m";}// float fi = (float)finly; mmm.Text = "" + fi; }
            else if (hi.Text == "?") { double ih = Convert.ToDouble(ho.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id * ih / od; la2.Text = "hi =  hi*(-di) / do" + "\n" + "hi = " + -id * ih + " / " + od + "\n" + "hi = " + mm + "m";}// float fi = (float)mm; mmm.Text = "" + fi; }
            else if (ddo.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ho.Text); double id = Convert.ToDouble(did.Text); double mm = -id * od / ih; double finly = Math.Pow(mm, -1); la2.Text = "do = -di / hi* do" + "\n" + "do = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m"; }//float fi = (float)finly; mmm.Text = "" + fi; }
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

        private void ho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void hi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {
            labe1.Text = "الحل";

        }

        private void label21_Click(object sender, EventArgs e)
        {
            la2.Text = "الحل";

        }

        private void ff_DoubleClick(object sender, EventArgs e)
        {
            ff.Text = "?";
        }

        private void dod_DoubleClick(object sender, EventArgs e)
        {
            dod.Text = "?";
        }

        private void di_DoubleClick(object sender, EventArgs e)
        {
            di.Text = "?";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mod.Text)) { return; }

          
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
            if (DD > FF) { PointF VC1 = new PointF(X, Y3); PointF VC2 = new PointF(X, fff); fc.DrawLine(Pens.LimeGreen, VC1, VC2); }
        }

        private void ho_DoubleClick_1(object sender, EventArgs e)
        {
            ho.Text = "?";
        }

        private void hi_DoubleClick_1(object sender, EventArgs e)
        {
            hi.Text = "?";
        }

        private void ddo_DoubleClick_1(object sender, EventArgs e)
        {
            ddo.Text = "?";
        }

        private void did_DoubleClick_1(object sender, EventArgs e)
        {
            did.Text = "?";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text) || string.IsNullOrWhiteSpace(mod.Text))
                return;
            int DD = int.Parse(D.Text); int FF = int.Parse(F.Text); Graphics fc = pictureBox1.CreateGraphics();

            if (FF > DD)
            {
                la1.Text = "مكبرة";
                lab2.Text = "معتدلة";
                lab3.Text = "خيالية";

            }

            if (FF < DD || DD < 2 * FF)
            {
                la1.Text = "مكبرة";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
            }
            if (FF == DD)
            {
                la1.Text = "لايوجد";
                lab2.Text = "لايوجد";
                lab3.Text = "لايوجد";
            }
            if (FF * 2 == DD)
            {
                la1.Text = "مساوية";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
            }
            if (DD > FF * 2)
            {
                la1.Text = "مصغرة";
                lab2.Text = "مقلوبة";
                lab3.Text = "حقيقية";
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
