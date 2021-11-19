using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPicture_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptrPicViewer.Load(openFileDialog1.FileName);
            }    
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            ptrPicViewer.Image = null;
        }

        private void btnSetBGColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ptrPicViewer.BackColor = colorDialog1.Color;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStretch.Checked)
                ptrPicViewer.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                ptrPicViewer.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}