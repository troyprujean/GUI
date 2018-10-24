using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fCPU = CPU.NextValue();
            float fRAM = RAM.NextValue();
            float fNSent = NetworkSent.NextValue();
            float fNReceived = NetworkReceived.NextValue();
            cpbCPU.Value = (int)fCPU;
            cpbRAM.Value = (int)fRAM;
            lblSent.Text = fNSent.ToString();
            lblReceived.Text = fNReceived.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
