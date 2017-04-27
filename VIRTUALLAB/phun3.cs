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
    public partial class phun3 : MetroForm
    {
        public phun3()
        {
            InitializeComponent();
        }
        Physics PH = new Physics();
        private void phun3_Load(object sender, EventArgs e)
        {

        }

        private void EMF_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(Tx1.Text) || string.IsNullOrWhiteSpace(TX2.Text) || string.IsNullOrWhiteSpace(TX3.Text) || string.IsNullOrWhiteSpace(TX4.Text) || string.IsNullOrWhiteSpace(TX5.Text)) { return; }
            if (Tx1.Text == "?")
            {
               PH.r= Convert.ToDouble(TX2.Text);
               
                PH.B = Convert.ToDouble(TX3.Text);

                PH.V = Convert.ToDouble(TX4.Text);
              
                PH.M = Convert.ToDouble(TX5.Text);
                PH.reslt = (PH.V * PH.M) / (PH.B * PH.r);
                labN1.Text = "q / m = v / Br";
                labN3.Text = " mv / Br";
                labN4.Text = "q =" + PH.M + " * " + PH.V + "/" + PH.B + "*" + PH.r;
                reslt1.Text = "" + PH.reslt;

               
            }
            else if (TX2.Text == "?")
            {
                PH.Q = Convert.ToDouble(Tx1.Text);
                PH.B = Convert.ToDouble(TX3.Text);
                PH.V = Convert.ToDouble(TX4.Text);
                PH.M = Convert.ToDouble(TX5.Text); ;
                PH.reslt = (PH.V * PH.M) / (PH.B * PH.Q);
                labN1.Text = "q / m = v / Br";
                labN3.Text = " mv / Bq";
                labN4.Text = "r =" + PH.M + " * " + PH.V + "/" + PH.B + "*" + PH.Q;
                reslt1.Text = "" + PH.reslt;
            }
            else if (TX3.Text == "?")
            {
                PH.Q = Convert.ToDouble(Tx1.Text);
                PH.r = Convert.ToDouble(TX2.Text);
                PH.V = Convert.ToDouble(TX4.Text);
                PH.M = Convert.ToDouble(TX5.Text); ;
                PH.reslt = (PH.V * PH.M) / (PH.Q * PH.r);
                labN1.Text = "q / m = v / Br";
                labN3.Text = " mv / qr";
                labN4.Text = "B =" + PH.M + " * " + PH.V + "/" + PH.Q + "*" + PH.r;

                reslt1.Text = "" + PH.reslt;
            }
            else if (TX4.Text == "?")
            {
                PH.Q = Convert.ToDouble(Tx1.Text);
                PH.r = Convert.ToDouble(TX2.Text);
                PH.B = Convert.ToDouble(TX3.Text);
                PH.M = Convert.ToDouble(TX5.Text);
                PH.reslt = (PH.Q * PH.B * PH.r) / (PH.M);
                labN1.Text = "q / m = v / Br";
                labN3.Text = " Bqr = m";
                labN4.Text = "v =" + PH.r + " * " + PH.Q + " * " + PH.B + " / " + PH.M;

                reslt1.Text = "" + PH.reslt;
            }
            else if (TX5.Text == "?")
            {
                PH.Q = Convert.ToDouble(Tx1.Text);
                PH.r = Convert.ToDouble(TX2.Text);
                PH.B = Convert.ToDouble(TX3.Text);
                PH.V = Convert.ToDouble(TX4.Text);
                PH.reslt = (PH.Q * PH.B * PH.r) / (PH.V);
                labN1.Text = "q / m = v / Br";
                labN3.Text = " Bqr = v";
                labN4.Text = "v =" + PH.r + " * " + PH.Q + " * " + PH.B + " / " + PH.V;

                reslt1.Text = "" + PH.reslt;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TX6.Text) || string.IsNullOrWhiteSpace(TX7.Text) || string.IsNullOrWhiteSpace(TX8.Text) || string.IsNullOrWhiteSpace(TX9.Text) || string.IsNullOrWhiteSpace(TX10.Text)) { return; }
            if (TX6.Text == "?")
            {
                PH.r = Convert.ToDouble(TX7.Text);
                PH.r *= PH.r;
                PH.B = Convert.ToDouble(TX8.Text);
                PH.B *= PH.B;
                PH.V = Convert.ToDouble(TX9.Text);
                PH.V *= 2;
                PH.M = Convert.ToDouble(TX10.Text);
                PH.reslt = (PH.V * PH.M) / (PH.B * PH.r);
                
                labN5.Text = "q / m = v / Br";
                labN6.Text = " mv / Br";
                labN7.Text = "q =" + PH.M + " * " + PH.V + "/" + PH.B + "*" + PH.r;
                reslt2.Text = "" + PH.reslt;
            }
            else if (TX7.Text == "?")
            {
                PH.Q = Convert.ToDouble(TX6.Text);
                PH.B = Convert.ToDouble(TX8.Text);
                PH.B *= PH.B;
                PH.V = Convert.ToDouble(TX9.Text);
                PH.V *= 2;
                PH.M = Convert.ToDouble(TX10.Text);
                PH.reslt = (PH.V * PH.M) / (PH.B * PH.Q);
               double reslt22 = Math.Pow(PH.reslt, (1 / 2));
                labN5.Text = "q / m = v / Br";
                labN6.Text = " mv / Bq";
                labN7.Text = "r =" + PH.M + " * " + PH.V + "/" + PH.B + "*" + PH.Q;
                reslt2.Text = "" + reslt22;
            }
            else if (TX8.Text == "?")
            {
                PH.Q = Convert.ToDouble(TX6.Text);
                PH.r = Convert.ToDouble(TX7.Text);
                PH.r *= PH.r;
                PH.V = Convert.ToDouble(TX9.Text);
                PH.V *= 2;
                PH.M = Convert.ToDouble(TX10.Text); ;
                PH.reslt = (PH.V * PH.M) / (PH.Q * PH.r);
                double reslt22 = Math.Pow(PH.reslt, (1 / 2));

                labN5.Text = "q / m = v / Br";
                labN6.Text = " mv / qr";
                labN7.Text = "B =" + PH.M + " * " + PH.V + "/" + PH.Q + "*" + PH.r;

                reslt2.Text = "" + reslt22;
            }
            else if (TX9.Text == "?")
            {
                PH.Q = Convert.ToDouble(TX6.Text);
                PH.r = Convert.ToDouble(TX7.Text);
                PH.r *= PH.r;
                PH.B = Convert.ToDouble(TX8.Text);
                PH.B *= PH.B;
                PH.M = Convert.ToDouble(TX10.Text);
                PH.reslt = (PH.Q * PH.B * PH.r) / (2 * PH.M);
                labN5.Text = "q / m = v / Br";
                labN6.Text = " Bqr / 2m";
                labN7.Text = "v =" + PH.r + " * " + PH.Q + " * " + PH.B + " / " + 2 * PH.M;

                reslt2.Text = "" + PH.reslt;
            }
            else if (TX10.Text == "?")
            {
                PH.Q = Convert.ToDouble(TX6.Text);
                PH.r = Convert.ToDouble(TX7.Text);
                PH.r *= PH.r;
                PH.B = Convert.ToDouble(TX8.Text);
                PH.B *= PH.B;
                PH.V = Convert.ToDouble(TX9.Text);
                PH.reslt = (PH.Q * PH.B * PH.r) / (2 * PH.V);
                labN5.Text = "q / m = v / Br";
                labN6.Text = " Bqr = v";
                labN7.Text = "v =" + PH.r + " * " + PH.Q + " * " + PH.B + " / " + 2 * PH.V;

                reslt2.Text = "" + PH.reslt;
            }

        }

        private void Iv_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TX6.Text) || string.IsNullOrWhiteSpace(TX7.Text) || string.IsNullOrWhiteSpace(TX8.Text))
            {
                if (tal.Text == "?")
                {
                    PH.V = Convert.ToDouble(lan.Text);
                   PH.f =Convert.ToDouble (sped.Text);
                    PH.reslt =PH.V / PH.f;
                    lab2.Text = " λ = v / f";
                    lab3.Text = "v / λ";
                    lab4.Text = " f =" +PH.f + " / " + PH.V;
                    laiv1.Text = "" + PH.reslt;
                
                }
               else if (lan.Text == "?")
                {
                    PH.V = Convert.ToDouble(tal.Text);
                    PH.f = Convert.ToDouble(sped.Text);
                    PH.reslt = PH.f / PH.V;
                    lab2.Text = " λ = v / f";
                    lab3.Text = "v / f";
                    lab4.Text = " λ =" + PH.f + " / " + PH.V;
                    laiv1.Text = "" + PH.reslt;
                
                }
                else if (sped.Text == "?")
                {
                    PH.V = Convert.ToDouble(tal.Text);
                    PH.f = Convert.ToDouble(sped.Text);
                    PH.reslt = PH.f * PH.V;
                    lab2.Text = " λ = v / f";
                    lab3.Text = "λ * f";
                    lab4.Text = " v =" +PH.f+ " * " + PH.V;
                    laiv1.Text = "" + PH.reslt;

                }
            
            
            
            }

        }
    }
}
