using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTxt_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Click(object sender, EventArgs e)
        {
            lblN1.Visible = true;
            lblN2.Visible = true;
            lblN3.Visible = true;
            await Task.Delay(1000);
            lblN1.ForeColor = Color.White;
            lblN1.BackColor = Color.Blue;
            await Task.Delay(1000);
            lblN2.ForeColor = Color.Green;
            lblN2.BackColor = Color.Yellow;
            await Task.Delay(1000);
            lblN3.ForeColor = Color.Yellow;
            lblN3.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
