using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x;
            x = pictureBox1.Location.X;
            int y;
            y = pictureBox1.Location.Y;

            if(e.KeyCode ==Keys.Right)
            {
                x = x + 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                x = x - 5;
            }
            if(e.KeyCode ==Keys.Up)
            {
                y = y - 5;
            }
            if(e.KeyCode ==Keys.Down)
            {
                y = y + 5;
            }
            if(e.KeyCode == Keys.P)
            {
                MessageBox.Show("oyunu durdurdun");
               
            }
           if(e.KeyCode ==Keys.Escape)
            {
                Application.Exit();
            }

            pictureBox1.Location = new Point(x, y);





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int labellocation;
            labellocation = label1.Left;
            label1.Left = label1.Left - 5;
            label1.Location = new Point(label1.Left);
            if(labellocation <=pictureBox1.Location.X)
            {
                timer1.Enabled = false;
                MessageBox.Show("kaybettiniz!!");
                Application.Restart();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
