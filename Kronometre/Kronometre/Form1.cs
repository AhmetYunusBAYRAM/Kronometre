using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dak=0, san=0, sal=0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Text = "DURDUR";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sal++;
            if (sal==100)
            {
                sal = 0;
                san++;
                if (san==60)
                {
                    san = 0;
                    dak++;
                }
            }
            lbldk.Text = String.Format("{0:D2}",dak);
            lblsan.Text = String.Format("{0:D2}", san);
            lblsal.Text = String.Format("{0:D2}", sal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "DURDUR" && sal!=0)
            {
                button2.Text = "SIFIRLA";
                timer1.Stop();
            }
            else
            {
                button2.Text = "DURDUR";
                dak = 0;
                san = 0;
                sal = 0;
                lbldk.Text = String.Format("{0:D2}", dak);
                lblsan.Text = String.Format("{0:D2}", san);
                lblsal.Text = String.Format("{0:D2}", sal);
            }      
        }
    }
}
