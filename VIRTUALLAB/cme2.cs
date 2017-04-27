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
    public partial class cme2 : Form
    {
        public cme2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            if (D.Text == "?") {
                double thk = Convert.ToDouble(mdd.Text);
                double mhk = Convert.ToDouble(Pd.Text);
                double resl = (thk / mhk) * 100;
                labD1.Text = "كتلة المحلول /كتلة المذيب *100";
                labD2.Text = "";
                labD3.Text = ""+resl;


            }
            else if (mdd.Text == "?")
            {
                double nk = Convert.ToDouble(D.Text);
                double mhk = Convert.ToDouble(Pd.Text);

                double resl = (nk* mhk)/ 100;
                labD1.Text = "كتلة المحلول*نسبة بالكتلة  *100";
                labD2.Text = "";
                labD3.Text = "" + resl;


            }  else if (Pd.Text == "?")
            {
                double nk = Convert.ToDouble(D.Text);
                double thk = Convert.ToDouble(mdd.Text);
                double resl = (thk / nk) * 100;
                labD1.Text = "النسبة بالكتله /كتلة المذيب *100";
                labD2.Text = "";
                labD3.Text = "" + resl;


            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nj.Text == "?")
            {
                double thk = Convert.ToDouble(thj.Text);
                double mhk = Convert.ToDouble(mhj.Text);
                double resl = (thk / mhk) * 100;
                labJ1.Text = "كتلة المحلول /كتلة المذيب *100";
                labJ2.Text = "";
                labJ3.Text = "" + resl;


            }
            else if (thj.Text == "?")
            {
                double nk = Convert.ToDouble(nj.Text);
                double mhk = Convert.ToDouble(mhj.Text);

                double resl = (nk * mhk) / 100;
                labJ1.Text = "كتلة المحلول*نسبة بالكتلة  *100";
                labJ2.Text = "";
                labJ3.Text = "" + resl;


            } if (mhj.Text == "?")
            {
                double nk = Convert.ToDouble(nj.Text);
                double thk = Convert.ToDouble(thj.Text);
                double resl = (thk / nk) * 100;
                labJ1.Text = "النسبة بالكتله /كتلة المذيب *100";
                labJ2.Text = "";
                labJ3.Text = "" + resl;


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (M.Text == "?")
            {
                double mhj = Convert.ToDouble(hmj.Text);
                double mn = Convert.ToDouble(nm.Text);
                double resl = mn / mhj;
                labM1.Text = "N / L";
                labM2.Text = "";
                labM3.Text = ""+resl;
            
            }
            else if (hmj.Text == "?")
            {
                double mn = Convert.ToDouble(nm.Text);
                double m = Convert.ToDouble(M.Text);
                double resl = mn / m;
                labM1.Text = "N / M";
                labM2.Text = "";
                labM3.Text = "" + resl;

            }
        else    if (nm.Text == "?")
            {
                double mhj = Convert.ToDouble(hmj.Text);
            double m = Convert.ToDouble(M.Text);
                double resl = m * mhj;
                labM1.Text = "M * L";
                labM2.Text = "";
                labM3.Text = "" + resl;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mm.Text == "?")
            {
                double mhj = Convert.ToDouble(km.Text);
                double mn = Convert.ToDouble(nnm.Text);
                double resl = mn / mhj;
                labmm1.Text = "N / L";
                labmm2.Text = "";
                labmm3.Text = "" + resl;

            }
            else if (km.Text == "?")
            {
                double mn = Convert.ToDouble(nnm.Text);
                double m = Convert.ToDouble(mm.Text);
                double resl = mn / m;
                labmm1.Text = "N / M";
                labmm2.Text = "";
                labmm3.Text = "" + resl;

            }
            else if (nnm.Text == "?")
            {
                double mhj = Convert.ToDouble(km.Text);
                double m = Convert.ToDouble(mm.Text);
                double resl = m * mhj;
                labmm1.Text = "M * L";
                labmm2.Text = "";
                labmm3.Text = "" + resl;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(P1.Text) || string.IsNullOrWhiteSpace(P2.Text) || string.IsNullOrWhiteSpace(V1.Text) || string.IsNullOrWhiteSpace(V2.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (P1.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double p1 = v2 / v1 * p2;
                labP1.Text = "M1 V1 = M2 V2";
                labP2.Text = "V2 / V1 * M2";
                labP3.Text = "" + p1;
            }
            else if (P2.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p1 = Convert.ToDouble(P1.Text);
                double p2 = v1 / v2 * p1;
                labP1.Text = "M1 V1 = M2 V2";
                labP2.Text = "V1 / V2 * M1";
                labP3.Text = "" + p2;
            }
            else if (V1.Text == "?")
            {
                double p1 = Convert.ToDouble(P1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double v1 = p2 / p1 * v2;
                labP1.Text = "M1 V1 = M2 V2";
                labP2.Text = "M2 / M1 * V2";
                labP3.Text = "" + v1;
            }
            else if (V2.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double p1 = Convert.ToDouble(P1.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double v2 = p1 / p2 * v1;
                labP1.Text = "M1 V1 = M2 V2";
                labP2.Text = "V1 / V2 * M2";
                labP3.Text = "" + v2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(T1.Text) || string.IsNullOrWhiteSpace(T2.Text) || string.IsNullOrWhiteSpace(Vt1.Text) || string.IsNullOrWhiteSpace(Vt2.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (Vt1.Text == "?")
            {
                double t1 = Convert.ToDouble(T1.Text);
                double t2 = Convert.ToDouble(T2.Text);
                double vt2 = Convert.ToDouble(Vt2.Text);
                double vt1 = vt2 * t1 / t2;
                labT1.Text = "V1 / T1 = V2 / T2";
                labT2.Text = "V2 * T1 / T2";
                labT3.Text = "" + vt1;
            }
            else if (Vt2.Text == "?")
            {
                double t1 = Convert.ToDouble(T1.Text);
                double t2 = Convert.ToDouble(T2.Text);
                double vt1 = Convert.ToDouble(Vt1.Text);
                double vt2 = vt1 * t2 / t1;
                labT1.Text = "V1 / T1 = V2 / T2";
                labT2.Text = "V1 * T2 / T1";
                labT3.Text = "" + vt2;
            }
            else if (T1.Text == "?")
            {
                double vt2 = Convert.ToDouble(Vt2.Text);
                double t2 = Convert.ToDouble(T2.Text);
                double vt1 = Convert.ToDouble(Vt1.Text);
                double t1 = vt1 * t2 / vt2;
                labT1.Text = "V1 / T1 = V2 / T2";
                labT2.Text = "V1 * T2 / T1";
                labT3.Text = "" + t1;
            }
            else if (T2.Text == "?")
            {
                double vt1 = Convert.ToDouble(Vt1.Text);
                double t1 = Convert.ToDouble(T1.Text);
                double vt2 = Convert.ToDouble(Vt2.Text);
                double t2 = vt2 * t1 / vt1;
                labT1.Text = "V1 / T1 = V2 / T2";
                labT2.Text = "V2 * T1 / V1";
                labT3.Text = "" + t2;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PH.Text)) { return; }
            else {
                double ph = Convert.ToDouble(PH.Text);
                double Hp = (Math.Log(ph));
                    Hp*=-1;
                hh1.Text = "-" + Hp;
            

            }

        }

        private void label22_Click_1(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(POH.Text)) { return; }
                else
                {
                    double ph = Convert.ToDouble(POH.Text);
                    double Hp = (Math.Log(ph));
                    hh2.Text = "-" + Hp;
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(POPH.Text)) { return; }
            else
            {
                double ph = Convert.ToDouble(POPH.Text);
                double Hp = 14 - ph;
                hh3.Text = "" + Hp;
            }
        }
    }
}
