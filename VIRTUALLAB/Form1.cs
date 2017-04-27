using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetroFramework.Forms;
namespace VIRTUALLAB
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; tt();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void tt (){ 
            comboBox2.Text = null;
            comboB.Text = null;
       //     comboBox1.Text = null;
            
            {
                comboBox2.SelectedIndex = -1;
                comboBox2.Items.Clear();
               
                    comboBox2.Items.AddRange(new string[] { "الانعكاس والمرايا", "الانكسار والعدسات", "التداخل والحيود" });
            }}


        public void com2()
        {
            try
            {
                if (comboBox2.SelectedItem.ToString() == "الانعكاس والمرايا")
                {


                    comboB.SelectedIndex = -1;
                    comboB.Items.Clear();
                    comboB.Items.AddRange(new string[] { "انعكاس الضوء في مرايا محدبة", "انعكاس الضوء في مرايا مقعرة" });
                }
                else if (comboBox2.SelectedItem.ToString() == "الانكسار والعدسات")
                {


                    comboB.SelectedIndex = -1;
                    comboB.Items.Clear();
                    comboB.Items.AddRange(new string[] { "انكسار الضوء في عدسة محدبة", "انكسار الضوء في عدسة مقعرة" });
                }
                else if (comboBox2.SelectedItem.ToString() == "التداخل والحيود")
                {


                    comboB.SelectedIndex = -1;
                    comboB.Items.Clear();
                    comboB.Items.AddRange(new string[] { "تداخل الضوء المتزامن - تجربة يونج" });
                }
            }
            catch { return; }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            com2();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }private void button2_Click(object sender, EventArgs e)
        {

            if ( comboBox2.SelectedItem == null || comboB.SelectedItem == null)
            {
                return;

             
            }


            else if (comboBox2.SelectedItem.ToString() == "الانعكاس والمرايا" && comboB.SelectedItem.ToString() == "انعكاس الضوء في مرايا مقعرة")
            {
                this.Hide();
                Concave_mirrors jk = new Concave_mirrors();
                jk.ShowDialog();
                this.Close();
            }
            else if (comboBox2.SelectedItem.ToString() == "الانعكاس والمرايا" && comboB.SelectedItem.ToString() == "انعكاس الضوء في مرايا محدبة")
            {
                this.Hide();
                Convex_mirrors jk = new Convex_mirrors();
                jk.ShowDialog();
                this.Close();
            }
            else if (comboBox2.SelectedItem.ToString() == "الانكسار والعدسات" && comboB.SelectedItem.ToString() == "انكسار الضوء في عدسة محدبة")
            {
                this.Hide();
                Concave jk = new Concave();
                jk.ShowDialog();
                this.Close();
            }
            else if (comboBox2.SelectedItem.ToString() == "الانكسار والعدسات" && comboB.SelectedItem.ToString() == "انكسار الضوء في عدسة مقعرة")
            {
                this.Hide();
                Convex jk = new Convex();
                jk.ShowDialog();
                this.Close();
            }
            else if (comboBox2.SelectedItem.ToString() == "التداخل والحيود" && comboB.SelectedItem.ToString() == "تداخل الضوء المتزامن - تجربة يونج")
            {
                this.Hide();
                Young_Try jk = new Young_Try();
                jk.ShowDialog();
                this.Close();
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.comboB = new MetroFramework.Controls.MetroComboBox();
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(95, 319);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(229, 43);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "ابدا";
            this.metroButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboB
            // 
            this.comboB.FormattingEnabled = true;
            this.comboB.ItemHeight = 24;
            this.comboB.Location = new System.Drawing.Point(99, 196);
            this.comboB.Name = "comboB";
            this.comboB.Size = new System.Drawing.Size(220, 30);
            this.comboB.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboB.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 24;
            this.comboBox2.Location = new System.Drawing.Point(99, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 30);
            this.comboBox2.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(336, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "اختر الدرس ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(333, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "اختر التجربة  ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(469, 392);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboB);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox comboB;

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private MetroFramework.Controls.MetroComboBox comboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }  
}
