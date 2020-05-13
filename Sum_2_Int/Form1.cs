using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_2_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Solve_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Int32.Parse(txtNum1.Text) + Int32.Parse(txtNum2.Text)).ToString();

        }
    }
}
