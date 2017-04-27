using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIRTUALLAB
{
    public partial class pme : Form
    {
        public pme()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(I.Text) || string.IsNullOrWhiteSpace(L.Text) || string.IsNullOrWhiteSpace(B.Text)) { return; }
          
            if (F.Text == "?")
            {
                double i = Convert.ToDouble(I.Text);
                double l = Convert.ToDouble(L.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = i * b * l;
                labN1.Text = " F = ILB";
                labN2.Text = "ILB";
                labN3.Text = ""+resl ;

            }
            else if (I.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double l = Convert.ToDouble(L.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = f / b * l;
                labN1.Text = "F =LIB";
                labN2.Text = "F / BL";
                labN3.Text = ""+resl ;

            }
            else if (B.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double i = Convert.ToDouble(I.Text);
                double l = Convert.ToDouble(L.Text);
                double resl = f / (l * i);
                labN1.Text = "F =ILB";
                labN2.Text = "F / LI";
                labN3.Text = "" + resl;

            }
            else if (L.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double i = Convert.ToDouble(I.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = f / b * i;
                labN1.Text = "F = ILB";
                labN2.Text = " F/BI";
                labN3.Text = "" + resl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ii.Text) || string.IsNullOrWhiteSpace(v.Text)) { return; }
            if(ii.Text=="?"){
                double V = Convert.ToDouble(v.Text);
                double reslt = 0.707 * V;
                laiv.Text = "" + reslt;
            }
            else if (v.Text == "?")
            {
                double V = Convert.ToDouble(v.Text);
                double reslt = 0.707 * V;
                laiv.Text = "" + reslt;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tx1.Text) || string.IsNullOrWhiteSpace(TX2.Text)  || string.IsNullOrWhiteSpace(TX3.Text)||string.IsNullOrWhiteSpace(TX4.Text) || string.IsNullOrWhiteSpace(TX5.Text)) { return; }
            if (Tx1.Text == "?")
            {
                double r= Convert.ToDouble(TX2.Text);
                double b= Convert.ToDouble(TX3.Text);
                double v= Convert.ToDouble(TX4.Text);
                double m = Convert.ToDouble(TX5.Text);
                double reslt = (v * m) / (b * r);

                reslt1.Text = "" + reslt;
            }
            else if (TX2.Text == "?")
            {
                double q = Convert.ToDouble(Tx1.Text);
                double b = Convert.ToDouble(TX3.Text);
                double v = Convert.ToDouble(TX4.Text);
                double m = Convert.ToDouble(TX5.Text); ;
                double reslt = (v * m) / (b * q);

                reslt1.Text = "" + reslt;
            }
            else if (TX3.Text == "?")
            { double q = Convert.ToDouble(Tx1.Text);
                double r= Convert.ToDouble(TX2.Text);
                double v= Convert.ToDouble(TX4.Text);
                double m = Convert.ToDouble(TX5.Text);;
                double reslt = (v * m) / (q * r);

                reslt1.Text = "" + reslt;
            }
            else if (TX4.Text == "?")
            {
                 double q = Convert.ToDouble(Tx1.Text);
                double r= Convert.ToDouble(TX2.Text);
                double b= Convert.ToDouble(TX3.Text);
                double m = Convert.ToDouble(TX5.Text);
                double reslt = (q * b *r) / (m);

                reslt1.Text = "" + reslt;
            }
            else if (TX5.Text == "?")
            {
                 double q = Convert.ToDouble(Tx1.Text);
                double r= Convert.ToDouble(TX2.Text);
                double b= Convert.ToDouble(TX3.Text);
                double v= Convert.ToDouble(TX4.Text);
                double reslt = (q * b * r) / (v);

                reslt1.Text = "" + reslt;
            }
        }
    }
}
