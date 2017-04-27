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
    public partial class Convex : MetroForm
    {
        public Convex()
        {
            InitializeComponent();            

        }
          public int df = 210;
          public void check()
          {
              if (string.IsNullOrWhiteSpace(mod.Text)) { return; }
              int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text) * 2;
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Ben()
        {
            int DD = int.Parse(D.Text); int FF = int.Parse(F.Text); float j = FF; int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text) * 2;

       
            Graphics MS = pictureBox1.CreateGraphics();
            float mm1 = (500 + df) + DD * mood + 3; float ss1 = FF * 2 * mood + 120; float mm2 = (505 + df); float mm3 = (500 + df) - DD * mood + 3;
            PointF MS1 = new PointF(mm1, ss1); PointF MS2 = new PointF(mm1, ss1 - j * mood); MS.DrawLine(Pens.Cyan, MS1, MS2);
            PointF MS3 = new PointF(mm2, ss1 - j * mood); MS.DrawLine(Pens.Red, MS2, MS3); PointF MS4 = new PointF(mm2-FF*mood, 0); MS.DrawLine(Pens.Red, MS3, MS4);
            PointF MS5 = new PointF(mm2, ss1 - mood); MS.DrawLine(Pens.Blue, MS2, MS5); PointF MS6 = new PointF(0, ss1 -mood); MS.DrawLine(Pens .Blue ,MS5 ,MS6 );
            PointF MS7 = new PointF(mm2-FF*mood, ss1); MS.DrawLine(Pens.Purple  ,MS5,MS7);
            PointF MS8 = new PointF((mm2+FF* mood)-21, ss1 - mood); MS.DrawLine(Pens.Purple , MS5, MS8); MS.DrawLine(Pens.Purple,MS3,MS8);
            PointF MS9 = new PointF(mm2 + FF * mood, ss1); MS.DrawLine(Pens.Purple   ,MS9,MS8 );
            PointF MS10 = new PointF((mm2 + FF * mood) - 21, ss1); MS.DrawLine(Pens.LimeGreen, MS8, MS10);

            L5.Text = "مسار الشعاعين";


        
        
        }
      
       
      
        
        private void Convex_Load(object sender, EventArgs e)
        {
           
        }

       

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text))
                return;
            la1.Text = "معتدلة";
            lab2.Text = "مصغرة";
            lab3.Text = "خيالية";
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            la1.Text = "...";
            lab2.Text = "...";
            lab3.Text = "...";
        }

       

        private void button_delet_Click_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void F_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled  = true;
                
            }
        }

        private void D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
           
     
        }          

      
        private void F_TextChanged(object sender, EventArgs e)
        {
        
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
        private void button1_Click(object sender, EventArgs e)
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
            if (ho.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id / ih * od; double finly = Math.Pow(mm, -1); la2.Text = "ho = -di / hi* do" + "\n" + "ho = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m";  }
            else if (hi.Text == "?") { double ih = Convert.ToDouble(ho.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(did.Text); double mm = -id * ih / od; la2.Text = "hi =  hi*(-di) / do" + "\n" + "hi = " + -id * ih + " / " + od + "\n" + "hi = " + mm + "m"; }
            else if (ddo.Text == "?") { double ih = Convert.ToDouble(hi.Text); double od = Convert.ToDouble(ho.Text); double id = Convert.ToDouble(did.Text); double mm = -id * od / ih; double finly = Math.Pow(mm, -1); la2.Text = "do = -di / hi* do" + "\n" + "do = " + -id + " / " + ih * od + "\n" + "ho = " + finly + "m";  }
            else if (did.Text == "?") { double ih = Convert.ToDouble(ho.Text); double od = Convert.ToDouble(ddo.Text); double id = Convert.ToDouble(hi.Text); double mm = od * id / ih; la2.Text = "di =  hi*(do) / ho" + "\n" + "ho = " + -id * ih + " / " + od + "\n" + "di = " + mm + "m";  }

        }

        private void ff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void di_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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
                e.Handled = true;
            }
        }

        private void did_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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

        private void button_draw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(D.Text) || string.IsNullOrWhiteSpace(mod.Text))
                return;
            int DD = int.Parse(D.Text); int mood = int.Parse(mod.Text); int modd = int.Parse(mod.Text) * 2;

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
            Ben();
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
            Point c1 = new Point((475 + df), 120);
            Point c2 = new Point(495 + df, FF * modd + 120);
            Point c3 = new Point((475 + df), FF * 2 * modd + 120);
            Point[] cp = { c1, c2, c3 };
            c.DrawCurve(Pens.SkyBlue, cp);

            //curve2
            Graphics cu = pictureBox1.CreateGraphics();
            Point cu1 = new Point((535 + df), 120);
            Point cu2 = new Point((515 + df), FF * modd + 120);
            Point cu3 = new Point((535 + df), FF * 2 * modd + 120);
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
            Point f1 = new Point((500 + df) + FF * mood, FF * 2 * mood + 120);
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
            Point f11 = new Point((500 + df) - FF * mood + 2, FF * 2 * mood + 120);
            f.DrawString(ff1, fo1, fb1, f11);
            //C

            Graphics fc1 = pictureBox1.CreateGraphics();
            string cc12 = "2F";
            Font co11 = new Font("Arial", 12);
            SolidBrush cb1 = new SolidBrush(Color.LimeGreen);
            Point cc11 = new Point((500 + df) - FF * modd - 5, FF * 2 * mood + 120);
            f.DrawString(cc12, co11, cb1, cc11);
        }          

       
    }

}
