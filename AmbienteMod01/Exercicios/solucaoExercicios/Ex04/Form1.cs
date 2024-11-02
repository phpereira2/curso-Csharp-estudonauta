using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num = 0;
            float.TryParse(txtBox.Text, out num);
            int numIntLower = (int)num;
            int numIntBigger = Convert.ToInt16(num);
            lblMsg.Visible = true;
            lblMsg.Text = $"Você digitou o valor {num:N3}\n\nA parte inteira é {numIntLower}\n\nArredondando, temos {numIntBigger}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblN1_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
