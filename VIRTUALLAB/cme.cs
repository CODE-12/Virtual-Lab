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
    public partial class cme : Form
    {
        public cme()
        {
            InitializeComponent();
        }
        // po
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(P1.Text) || string.IsNullOrWhiteSpace(P2.Text) || string.IsNullOrWhiteSpace(V1.Text) || string.IsNullOrWhiteSpace(V2.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (P1.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double p1 = v2 / v1 * p2;
                labP1.Text = "P1 V1 = P2 V2";
                labP2.Text = "V2 / V1 * P2";
                labP3.Text = "" + p1;
            }
           else  if (P2.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p1 = Convert.ToDouble(P1.Text);
                double p2 = v1 / v2 * p1;
                labP1.Text = "P1 V1 = P2 V2";
                labP2.Text = "V1 / V2 * P1";
                labP3.Text = "" + p2;
            }
           else  if (V1.Text == "?")
            {
                double p1 = Convert.ToDouble(P1.Text);
                double v2 = Convert.ToDouble(V2.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double v1 = p2 / p1 * v2 ;
                labP1.Text = "P1 V1 = P2 V2";
                labP2.Text = "P2 / P1 * V2";
                labP3.Text = "" + v1;
            }
          else   if (V2.Text == "?")
            {
                double v1 = Convert.ToDouble(V1.Text);
                double p1 = Convert.ToDouble(P1.Text);
                double p2 = Convert.ToDouble(P2.Text);
                double v2 = p1 / p2 * v1;
                labP1.Text = "P1 V1 = P2 V2";
                labP2.Text = "V1 / V2 * P2";
                labP3.Text = "" + v2;
            }
            //po/

        }
        //charl
        private void button2_Click(object sender, EventArgs e)
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
                double t1 = vt1* t2 / vt2;
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
            //charl
        }
        //lowsak
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tg1.Text) || string.IsNullOrWhiteSpace(Tg2.Text) || string.IsNullOrWhiteSpace(Pg1.Text) || string.IsNullOrWhiteSpace(Pgg2.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (Pg1.Text == "?")
            {
                double tg1 = Convert.ToDouble(Tg1.Text);
                double tg2 = Convert.ToDouble(Tg2.Text);
                double pg2 = Convert.ToDouble(Pgg2.Text);
                double pg1 = pg2 * tg1 / tg2;
                labG1.Text = "P1 / T1 = P2 / T2";
                labG2.Text = "P2 * T1 / T2";
                labG3.Text = "" + pg1;
            }
            else if (Pgg2.Text == "?")
            {
                double tg1 = Convert.ToDouble(Tg1.Text);
                double tg2 = Convert.ToDouble(Tg2.Text);
                double pg1 = Convert.ToDouble(Pg1.Text);
                double pg2 = pg1 * tg2 / tg1;
                labG1.Text = "P1 / T1 = P2 / T2";
                labG2.Text = "P1 * T2 / T1";
                labG3.Text = "" + pg2;
            }
            else if (Tg1.Text == "?")
            {
                double pg2 = Convert.ToDouble(Pgg2.Text);
                double tg2 = Convert.ToDouble(Tg2.Text);
                double pg1 = Convert.ToDouble(Pg1.Text);
                double tg1 = pg1 * tg2 / pg2;
                labG1.Text = "P1 / T1 = P1 / T2";
                labG2.Text = "V1 * T2 / T1";
                labG3.Text = "" + tg1;
            }
            else if (Tg2.Text == "?")
            {
                double pg1 = Convert.ToDouble(Pg1.Text);
                double tg1 = Convert.ToDouble(Tg1.Text);
                double pg2 = Convert.ToDouble(Pgg2.Text);
                double tg2 = pg2 * tg1 / pg1;
                labG1.Text = "P1 / T1 = P2 / T2";
                labG2.Text = "P2 * T1 / P1";
                labG3.Text = "" + tg2;
            }
            //lowsak
        }
        //al3am
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(P11.Text) || string.IsNullOrWhiteSpace(P22.Text) || string.IsNullOrWhiteSpace(V11.Text) || string.IsNullOrWhiteSpace(V22.Text) || string.IsNullOrWhiteSpace(T11.Text) || string.IsNullOrWhiteSpace(T22.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (P11.Text == "?")
            {
                double v11 = Convert.ToDouble(V11.Text);
                double v22 = Convert.ToDouble(V22.Text);
                double p22 = Convert.ToDouble(P22.Text);
                double t11 = Convert.ToDouble(T11.Text);
                double t22 = Convert.ToDouble(T22.Text);
                double p11 = p22 * (v22 / v11) * (t11 / t22);
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "P2 * (V2 / V1) * (T1 / T2)";
                labA3.Text = "" + p11;
            }
            else if (P22.Text == "?")
            {
                double v11 = Convert.ToDouble(V11.Text);
                double v22 = Convert.ToDouble(V22.Text);
                double p11 = Convert.ToDouble(P11.Text);
                double t11 = Convert.ToDouble(T11.Text);
                double t22 = Convert.ToDouble(T22.Text);
                double p22 = p11 * (v11 / v22) * (t22 / t11);
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "P1 * (V1 / V2) * (T2 / T1)";
                labA3.Text = "" + p22;
            }
            else if (V11.Text == "?")
            {
                double p22 = Convert.ToDouble(P22.Text);
                double v22 = Convert.ToDouble(V22.Text);
                double p11 = Convert.ToDouble(P11.Text);
                double t11 = Convert.ToDouble(T11.Text);
                double t22 = Convert.ToDouble(T22.Text);
                double v11 = v22 * (p22 / p11) * (t11 / t22);
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "V2 * (P2 / P1) * (T1 / T2)";
                labA3.Text = "" + v11;
            }
            else if (V22.Text == "?")
            {
                double p22 = Convert.ToDouble(P22.Text);
                double v11 = Convert.ToDouble(V11.Text);
                double p11 = Convert.ToDouble(P11.Text);
                double t11 = Convert.ToDouble(T11.Text);
                double t22 = Convert.ToDouble(T22.Text);
                double v22 = v11 * (p11 / p22) * (t22 / t11); ;
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "v11 * (p11 / p22) * (t22 / t11);";
                labA3.Text = "" + v22;
            }
            else if (T11.Text == "?")
            {
                double p22 = Convert.ToDouble(P22.Text);
                double v11 = Convert.ToDouble(V11.Text);
                double p11 = Convert.ToDouble(P11.Text);
                double v22 = Convert.ToDouble(V22.Text);
                double t22 = Convert.ToDouble(T22.Text);
                double t11 = t22* (p11 / p22) * (v11 / v22);
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "T2* (P1 / P2) * (V1 / V2);";
                labA3.Text = "" +t11;
            }
            else if (T22.Text == "?")
            {
                double p22 = Convert.ToDouble(P22.Text);
                double v11 = Convert.ToDouble(V11.Text);
                double p11 = Convert.ToDouble(P11.Text);
                double v22 = Convert.ToDouble(V22.Text);
                double t11 = Convert.ToDouble(T11.Text);
                double t22 = t11* (p22 / p11) * (v22 / v11); 
                labA1.Text = "P1 V1 / T1 = P2 V2 / T2";
                labA2.Text = "T1* (P2 / P1) * (V2 / v1);";
                labA3.Text = "" + t22;
            }

        }
        //al3am

        //almthly
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pm.Text) ||  string.IsNullOrWhiteSpace(Vm.Text) ||  string.IsNullOrWhiteSpace(n.Text) || string.IsNullOrWhiteSpace(Tm.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
            if (Pm.Text == "?")
            {
                double R = 0.0821;
                double vm = Convert.ToDouble(Vm.Text);
                double tm = Convert.ToDouble(Tm.Text);
                double N = Convert.ToDouble(n.Text);
                double pm = (R * tm * N)/ vm;
                labN1.Text = "PV = nRT";
                labN2.Text = "P = nRT / V";
                labN3.Text = ""+pm;
            }
            else if (Vm.Text == "?")
            {
                double R = 0.0821;
                double pm = Convert.ToDouble(Pm.Text);
                double tm = Convert.ToDouble(Tm.Text);
                double N = Convert.ToDouble(n.Text);
                double vm = (R * tm * N) / pm;
                labN1.Text = "PV = nRT";
                labN2.Text = "V = nRT / p";
                labN3.Text = "" + vm;
            }
            else if (n.Text == "?")
            {
                double R = 0.0821;
                double pm = Convert.ToDouble(Pm.Text);
                double tm = Convert.ToDouble(Tm.Text);
                double vm = Convert.ToDouble(Vm.Text);
                double N = (pm * vm) / (R * tm);
                labN1.Text = "PV = nRT";
                labN2.Text = "n = PV / RT";
                labN3.Text = "" + N;
            }
            else if (Tm.Text == "?")
            {
                double R = 0.0821;
                double pm = Convert.ToDouble(Pm.Text);
                double N = Convert.ToDouble(n.Text);
                double vm = Convert.ToDouble(Vm.Text);
                double tm= (pm * vm) / (R * N);
                labN1.Text = "PV = nRT";
                labN2.Text = "T= PV / Rn";
                labN3.Text = "" + tm;
            } //almthly





        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(M.Text) || string.IsNullOrWhiteSpace(PP.Text) || string.IsNullOrWhiteSpace(VV.Text) || string.IsNullOrWhiteSpace(TT.Text) || string.IsNullOrWhiteSpace(mm.Text)) { MessageBox.Show("البيانات ناقصة"); return; }

            labM1.Text = "";
            labM2.Text = "";
            labM3.Text = "";
            if (M.Text =="?")
            {
                const double R = 0.0821;
                double pp = Convert.ToDouble(PP.Text);
                double vv = Convert.ToDouble(VV.Text);
                double tt = Convert.ToDouble(TT.Text);
                double mM = Convert.ToDouble(mm.Text);
                double resl = (mM * R * tt )/ (pp * vv);
                labM1.Text = "mP/RT";
                labM2.Text = "mRT/PV";
                labM3.Text = ""+resl;
                
            }
            else if (VV.Text == "?")
            {
                const double R = 0.0821;
                double pp = Convert.ToDouble(PP.Text);
                double tt = Convert.ToDouble(TT.Text);
                double mM = Convert.ToDouble(mm.Text);
                double Mm = Convert.ToDouble(M.Text);
                double resl = (mM * R * tt) /( pp * Mm);
                labM1.Text = "mP/RT";
                labM2.Text = "mRT/PM";
                labM3.Text = "" + resl;

            }
            else if (PP.Text == "?")
            {
                const double R = 0.0821;
                double vv = Convert.ToDouble(VV.Text);
                double tt = Convert.ToDouble(TT.Text);
                double mM = Convert.ToDouble(mm.Text);
                double Mm = Convert.ToDouble(M.Text);
                double resl = (mM * R * tt) / (vv * Mm);
                labM1.Text = "mP/RT";
                labM2.Text = "mRT/VM";
                labM3.Text = "" + resl;

            }
            else if (TT.Text == "?")
            {
                const double R = 0.0821;
                double pp = Convert.ToDouble(PP.Text);
                double vv = Convert.ToDouble(VV.Text);
                double mM = Convert.ToDouble(mm.Text);
                double Mm = Convert.ToDouble(M.Text);
                double resl = (Mm * pp * vv) / (R * mM);
                labM1.Text = "mP/RT";
                labM2.Text = "PVM/Rm";
                labM3.Text = "" + resl;

            }
            else if (mm.Text == "?")
            {
                const double R = 0.0821;
                double pp = Convert.ToDouble(PP.Text);
                double vv = Convert.ToDouble(VV.Text);
                double tt = Convert.ToDouble(TT.Text);
                double Mm = Convert.ToDouble(M.Text);
                double resl = (Mm * pp * vv) / (R * tt);
                labM1.Text = "mP/RT";
                labM2.Text = "PVM/Rm";
                labM3.Text = "" + resl;

            }
           ////


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mmmm.Text) || string.IsNullOrWhiteSpace(Pd.Text) ||  string.IsNullOrWhiteSpace(Td.Text) || string.IsNullOrWhiteSpace(md.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
           
            if (D.Text == "?")
            {
                const double R = 0.0821;
                double td = Convert.ToDouble(Tdd.Text);
                double Md = Convert.ToDouble(mdd.Text);
                double pd = Convert.ToDouble(Pd.Text);
                double resl = (Md * pd ) / (R* td);
                labD1.Text = "";
                labD2.Text = "mP/RT";
                labD3.Text = "" + resl;

            }
            else if (Tdd.Text == "?")
            {
                const double R = 0.0821;
                double d = Convert.ToDouble(D.Text);
                double Md = Convert.ToDouble(mdd.Text);
                double pd = Convert.ToDouble(Pd.Text);
                double resl = (Md * pd) / (R * d);
                labD1.Text = "";
                labD2.Text = "mP/RD";
                labD3.Text = "" + resl;

            } 
            else if (mdd.Text == "?")
            {
                const double R = 0.0821;
                double d = Convert.ToDouble(D.Text);
                double td = Convert.ToDouble(Tdd.Text);
                double pd = Convert.ToDouble(Pd.Text);
                double resl = (R * td * d) / (pd);
                labD1.Text = "";
                labD2.Text = "DRT/P";
                labD3.Text = "" + resl;

            }
            else if (Pd.Text == "?")
            {
                const double R = 0.0821;
                double d = Convert.ToDouble(D.Text);
                double td = Convert.ToDouble(Tdd.Text);
                double Md = Convert.ToDouble(mdd.Text);
                double resl = (R * td * d) / (Md);
                labD1.Text = "";
                labD2.Text = "DRT/m";
                labD3.Text = "" + resl;

            }

        }
    }
}
