using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            circularProgressBarCPU.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBarCPU.Value = 0;
            float fcpu = pCPU.NextValue();
            circularProgressBarCPU.Value = (int)fcpu;
            labelCPUP.Text = string.Format("{0:0}%", fcpu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
