using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace محمود_اغh_lesson_6_code_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height= 300;
            pictureBox1.BorderStyle= BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BackgroundImage = Image.FromFile(@"sleep.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"clock.jpg");
            toolTip1.SetToolTip(pictureBox1, "photo clock");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
           
        }
    }
}
