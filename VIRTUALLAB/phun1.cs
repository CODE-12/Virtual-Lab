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
    public partial class phun1 : MetroForm
    {
        public phun1()
        {
            InitializeComponent();
        }

        private void phun1_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

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
                labN3.Text = "ILB";
                labN4.Text = "F =" + l+ "*" + b + "*" + i;
                resll.Text = "" + resl;

            }
            else if (I.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double l = Convert.ToDouble(L.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = f / b * l;
                labN1.Text = "F =LIB";
                labN3.Text = "F / BL";
                labN4.Text = "I =" + f + "/" + b + "*" + l;
                resll.Text = "" + resl;
            }
            else if (B.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double i = Convert.ToDouble(I.Text);
                double l = Convert.ToDouble(L.Text);
                double resl = f / (l * i);
                labN1.Text = "F =ILB";
                labN3.Text = "F / LI";
                labN4.Text = "B =" + f + "/" + l + "*" + i;
                resll.Text = "" + resl;
            }
            else if (L.Text == "?")
            {
                double f = Convert.ToDouble(F.Text);
                double i = Convert.ToDouble(I.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = f / b * i;
                labN1.Text = "F = ILB";
                labN3.Text = " F/BI";
                labN4.Text = "L ="+f+"/"+b+"*"+i;
                resll.Text = "" + resl;
                

            }
        }

        private void F_Click(object sender, EventArgs e)
        {
            F.Clear();
        }
        private void I_Click(object sender, EventArgs e)
        {
            I.Clear();
        }
        private void L_Click(object sender, EventArgs e)
        {
            L.Clear();
        }
        private void B_Click(object sender, EventArgs e)
        {
            B.Clear();
        }
        private void FF_Click(object sender, EventArgs e)
        {
            FF.Clear();
        }
        private void Q_Click(object sender, EventArgs e)
        {
            Q.Clear();
        }
        private void V_Click(object sender, EventArgs e)
        {
            V.Clear();
        }
        private void BB_Click(object sender, EventArgs e)
        {
            BB.Clear();
        }

        private void metroTabPage2_Click_1(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(F.Text) || string.IsNullOrWhiteSpace(I.Text) || string.IsNullOrWhiteSpace(L.Text) || string.IsNullOrWhiteSpace(B.Text)) { return; }

            if (FF.Text == "?")
            {
                double q = Convert.ToDouble(Q.Text);
                double v= Convert.ToDouble(V.Text);
                double b = Convert.ToDouble(BB.Text);
                double resl = q * b * v;
                lab1.Text = " F = qvB";
                lab2.Text = "qvB";
                lab3.Text = "F =" + q+ "*" + v + "*" + b;
                lab4.Text = "" + resl;

            }
            else if (Q.Text == "?")
            {
                double f = Convert.ToDouble(FF.Text);
                double v = Convert.ToDouble(V.Text);
                double b = Convert.ToDouble(BB.Text);
                double resl = f / b * v;
                lab1.Text = "F =qvB";
                lab2.Text = "F / Bv";
                lab3.Text = "q =" + f + "/" + b + "*" + v;
                lab4.Text = "" + resl;
            }
            else if (BB.Text == "?")
            {
                double f = Convert.ToDouble(FF.Text);
                double q = Convert.ToDouble(Q.Text);
                double v = Convert.ToDouble(V.Text);
                double resl = f / (v * q);
                lab1.Text = "F =qvB";
                lab2.Text = "F / qv";
                lab3.Text = "B =" + f + "/" + q + "*" + v;
                lab4.Text = "" + resl;
            }
            else if (V.Text == "?")
            {
                double f = Convert.ToDouble(FF.Text);
                double q = Convert.ToDouble(Q.Text);
                double b = Convert.ToDouble(BB.Text);
                double resl = f / b * q;
                lab1.Text = "F = qvB";
                lab2.Text = " F/Bq";
                lab3.Text = "v =" + f + "/" + b + "*" + q;
                lab4.Text = "" + resl;


            }
        }


        private void F_DoubleClick(object sender, EventArgs e)
        {
            F.Text = "?";
        }
        private void I_DoubleClick(object sender, EventArgs e)
        {
            I.Text = "?";
        }
        private void L_DoubleClick(object sender, EventArgs e)
        {
            L.Text = "?";
        }
        private void B_DoubleClick(object sender, EventArgs e)
        {
           B.Text = "?";
        }
        private void FF_DoubleClick(object sender, EventArgs e)
        {
            FF.Text = "?";
        }
        private void Q_DoubleClick(object sender, EventArgs e)
        {
            Q.Text = "?";
        }
        private void V_DoubleClick(object sender, EventArgs e)
        {
            V.Text = "?";
        }
        private void BB_DoubleClick(object sender, EventArgs e)
        {
            BB.Text = "?";
        }
      
    }
}
