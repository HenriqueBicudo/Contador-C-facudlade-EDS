using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int clickNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickNumber++;
            label2.Text = clickNumber.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickNumber > 0)
            {
                clickNumber--;
                label2.Text = clickNumber.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickNumber = 0;
            label2.Text = clickNumber.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }