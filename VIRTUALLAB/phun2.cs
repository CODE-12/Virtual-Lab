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
    public partial class phun2 : MetroForm
    {
        public phun2()
        {
            InitializeComponent();
        }

        private void phun2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EMF.Text) || string.IsNullOrWhiteSpace(V.Text) || string.IsNullOrWhiteSpace(L.Text) || string.IsNullOrWhiteSpace(B.Text)) { return; }

            if (EMF.Text == "?")
            {
                double v = Convert.ToDouble(V.Text);
                double l = Convert.ToDouble(L.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = v * b * l;
                labN1.Text = " EMF = BVL";
                labN3.Text = "BVL";
                labN4.Text = "EMF =" + b + "*" + v + "*" + l;
                resll.Text = "" + resl;

            }
            else if (V.Text == "?")
            {
                double emf = Convert.ToDouble(EMF.Text);
                double l = Convert.ToDouble(L.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = emf / b * l;
                labN1.Text = "EMF =BVL";
                labN3.Text = "EMF / BL";
                labN4.Text = "V =" + emf + " / " + b + " * " + l;
                resll.Text = "" + resl;
            }
            else if (B.Text == "?")
            {
                double emf = Convert.ToDouble(EMF.Text);
                double v = Convert.ToDouble(V.Text);
                double l = Convert.ToDouble(L.Text);
                double resl = emf / (l * v);
                labN1.Text = "EMF =BVL";
                labN3.Text = "EMF / LV";
                labN4.Text = "B = " + emf + " / " + l + " * " + v;
                resll.Text = "" + resl;
            }
            else if (L.Text == "?")
            {
                double emf = Convert.ToDouble(EMF.Text);
                double v = Convert.ToDouble(V.Text);
                double b = Convert.ToDouble(B.Text);
                double resl = emf / (b * v);
                labN1.Text = "EMF = BVL";
                labN3.Text = " EMF / BV";
                labN4.Text = "L = " + emf + " / " + b + " * " + v;
                resll.Text = "" + resl;


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ii.Text) || string.IsNullOrWhiteSpace(vv.Text)) { return; }
            if (ii.Text == "?")
            {
                double V = Convert.ToDouble(vv.Text);
                double reslt = 0.707 * V;
                lab1.Text = "V = 0.707 * V";
                lab2.Text = "V = 0.707 *" + V;
                laiv.Text = "" + reslt;
            }
            else if (vv.Text == "?")
            {
                double V = Convert.ToDouble(ii.Text);
                double reslt = V/0.707 ;
                laiv.Text = "" + reslt;
                lab1.Text = "V = 0.707 * V";
                lab2.Text = "V = "+V+"/ 0.707" ;
                laiv.Text = "" + reslt;


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(I.Text) || string.IsNullOrWhiteSpace(Iv.Text)) { return; }
            if (I.Text == "?")
            {
                double V = Convert.ToDouble(Iv.Text);
                double reslt = 0.707 * V;
                lab3.Text = "I = 0.707 * I";
                lab4.Text = "I = 0.707 *" + V;
                laiv1.Text = "" + reslt;
            }
            else if (Iv.Text == "?")
            {
                double V = Convert.ToDouble(I.Text);
                double reslt =  V/0.707 ;
                lab3.Text = "I= 0.707 * I";
                lab4.Text = "I = " + V+"/ 0.707";
                laiv1.Text = "" + reslt;


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Is.Text) || string.IsNullOrWhiteSpace(Ip.Text))
            {
                if (string.IsNullOrWhiteSpace(Vs.Text) || string.IsNullOrWhiteSpace(Vp.Text) || string.IsNullOrWhiteSpace(Ns.Text) || string.IsNullOrWhiteSpace(Np.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
                else
                {
                    if (Vs.Text == "?")
                    {
                        double vp = Convert.ToDouble(Vp.Text);
                        double np = Convert.ToDouble(Np.Text);
                        double ns= Convert.ToDouble(Ns.Text);
                        double reslt = (vp * ns) / np;
                       la.Text = "Vp / Vs = Np / Ns";
                       la2.Text = "Vp * Ns / Np";
                       la3.Text = " Vs ="+vp+" * "+ns+" / "+np;
                       la4.Text = "" + reslt;
                    }
                    else if (Vp.Text == "?")
                    {
                        double vs = Convert.ToDouble(Vs.Text);
                        double np = Convert.ToDouble(Np.Text);
                        double ns = Convert.ToDouble(Ns.Text);
                        double reslt = (vs * np) / ns;
                       la.Text = "Vp / Vs = Np / Ns";
                       la2.Text = "Vs * Np / Ns";
                       la3.Text = " Vs = " + vs + " * " + ns + " / " + np;
                       la4.Text = "" + reslt;
                    }
                    else if (Ns.Text == "?")
                    {
                        double vp = Convert.ToDouble(Vp.Text);
                        double np = Convert.ToDouble(Np.Text);
                        double vs = Convert.ToDouble(Vs.Text);
                        double reslt = (vs * np) / vp;
                       la.Text = "Vp / Vs = Np / Ns";
                       la2.Text = "Vs * Np / Vp"; 
                       la3.Text = " Vs =" + vs + " * " + np + "/ " + vp;
                       la4.Text = "" + reslt;
                    }
                    else if (Np.Text == "?")
                    {
                        double vp = Convert.ToDouble(Vp.Text);
                        double ns = Convert.ToDouble(Ns.Text);
                        double vs = Convert.ToDouble(Vs.Text);
                        double reslt = (vp * ns) / vs;
                       la.Text = "Vp / Vs = Np / Ns";
                       la2.Text = "Vp* Ns / Vs";
                       la3.Text = " Vs =" + vp + " * " + ns + "/ " + vs;
                       la4.Text = "" + reslt;
                    }
                }
            }
            else if (string.IsNullOrWhiteSpace(Vs.Text) || string.IsNullOrWhiteSpace(Vp.Text))
                {
                    if (string.IsNullOrWhiteSpace(Is.Text) || string.IsNullOrWhiteSpace(Ip.Text) || string.IsNullOrWhiteSpace(Ns.Text) || string.IsNullOrWhiteSpace(Np.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
                    else
                    {
                        if (Is.Text == "?")
                        {
                            double ip = Convert.ToDouble(Ip.Text);
                            double np = Convert.ToDouble(Np.Text);
                            double ns = Convert.ToDouble(Ns.Text);
                            double reslt = (ip * ns) / np;
                           la.Text = "Is / Ip = Np / Ns";
                           la2.Text = "Ip * Np / Ns";
                           la3.Text = " Is =" + ip + " * " + np + " / " + ns;
                           la4.Text = "" + reslt;
                        }
                        else if (Ip.Text == "?")
                        {
                            double iis = Convert.ToDouble(Is.Text);
                            double np = Convert.ToDouble(Np.Text);
                            double ns = Convert.ToDouble(Ns.Text);
                            double reslt = (iis * ns) / np;
                           la.Text = "Is / Ip = Np / Ns";
                           la2.Text = "Ip * Ns / Np";
                           la3.Text = " Ip = " + iis + " * " + ns + " / " + np;
                           la4.Text = "" + reslt;
                        }
                        else if (Ns.Text == "?")
                        {
                            double ip = Convert.ToDouble(Ip.Text);
                            double np = Convert.ToDouble(Np.Text);
                            double iis = Convert.ToDouble(Is.Text);
                            double reslt = (ip * np) / iis;
                           la.Text = "Is / Ip = Np / Ns";
                           la2.Text = "Ip * Np / Is";
                           la3.Text = " Ns =" + ip + " * " + np + "/ " + iis;
                           la4.Text = "" + reslt;
                        }
                        else if (Np.Text == "?")
                        {
                            double ip = Convert.ToDouble(Ip.Text);
                            double ns = Convert.ToDouble(Ns.Text);
                            double iis = Convert.ToDouble(Is.Text);
                            double reslt = (iis * ns) / ip;
                           la.Text = "Is / Ip = Np / Ns";
                           la2.Text = "Is * Ns / Ip";
                           la3.Text = " Np =" + iis + " * " + ns + "/ " + ip;
                           la4.Text = "" + reslt;
                        }
                    }
                }
            else if (string.IsNullOrWhiteSpace(Ns.Text) || string.IsNullOrWhiteSpace(Np.Text))
            {
                if (string.IsNullOrWhiteSpace(Is.Text) || string.IsNullOrWhiteSpace(Ip.Text) || string.IsNullOrWhiteSpace(Vs.Text) || string.IsNullOrWhiteSpace(Vp.Text)) { MessageBox.Show("البيانات ناقصة"); return; }
                else
                {
                    if (Is.Text == "?")
                    {
                        double ip = Convert.ToDouble(Ip.Text);
                        double vp = Convert.ToDouble(Vp.Text);
                        double vs = Convert.ToDouble(Vs.Text);
                        double reslt = (ip * vs) / vp;
                       la.Text = "Is / Ip = Vp / Vs";
                       la2.Text = "Ip * Vp / Vs";
                       la3.Text = " Is =" + ip + " * " + vp + " / " + vs;
                       la4.Text = "" + reslt;
                    }
                    else if (Ip.Text == "?")
                    {
                        double iis = Convert.ToDouble(Is.Text);
                        double vp = Convert.ToDouble(Vp.Text);
                        double vs = Convert.ToDouble(Vs.Text);
                        double reslt = (iis * vs) / vp;
                       la.Text = "Is / Ip = Vp / Vs";
                       la2.Text = "Ip * Vs / Vp";
                       la3.Text = " Ip = " + iis + " * " + vs + " / " + vp;
                       la4.Text = "" + reslt;
                    }
                    else if (Vs.Text == "?")
                    {
                        double ip = Convert.ToDouble(Ip.Text);
                        double vp = Convert.ToDouble(Vp.Text);
                        double iis = Convert.ToDouble(Is.Text);
                        double reslt = (ip * vp) / iis;
                       la.Text = "Is / Ip = Vp / Vs";
                       la2.Text = "Ip * Vp / Is";
                       la3.Text = " Vs =" + ip + " * " + vp + "/ " + iis;
                       la4.Text = "" + reslt;
                    }
                    else if (Vp.Text == "?")
                    {
                        double ip = Convert.ToDouble(Ip.Text);
                        double vs = Convert.ToDouble(Vs.Text);
                        double iis = Convert.ToDouble(Is.Text);
                        double reslt = (iis * vs) / ip;
                       la.Text = "Is / Ip = Vp / Vs";
                       la2.Text = "Is * Vs / Ip";
                       la4.Text = " Vp =" + iis + " * " + vs + "/ " + ip;
                       la3.Text = "" + reslt;
                    }
                }
            }


        }
    }

    }

