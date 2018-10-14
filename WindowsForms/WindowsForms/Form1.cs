using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pictBox.Image = null;
        }

        private void chkStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStretch.Checked)
                pictBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictBox.BackColor = colorDialog1.Color;
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictBox.Image = null;
        }

        private void btnShowPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictBox.Load(openFileDialog1.FileName);
        }
    }
}
