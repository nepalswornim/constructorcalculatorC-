using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace class3constructorcalculator
{
    public partial class Form1 : Form
    {
        Utilities utl = new Utilities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Text = "";
            txtSecondNum.Text = "";
            txtResult.Text = "";


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int sum = utl.div(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));
            txtResult.Text = sum.ToString();
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int sum = utl.multi(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));
            txtResult.Text = sum.ToString();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            int sum =utl.sub(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));
            txtResult.Text = sum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           int sum = utl.add(Convert.ToInt32(txtFirstNum.Text), Convert.ToInt32(txtSecondNum.Text));
           txtResult.Text = sum.ToString();
             
        }
    }
}
