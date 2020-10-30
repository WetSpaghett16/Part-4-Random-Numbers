using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers
{
    public partial class Form1 : Form
    {
       
        int Result;
        Random generator;
        public Form1()
        {
            InitializeComponent();
            generator = new Random();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInteger_Click_1(object sender, EventArgs e)
        {
            int Minimum = Convert.ToInt32(txtMinimum.Text);
            int Maximum = Convert.ToInt32(txtMaximum.Text);
            Result = generator.Next(Minimum, Maximum);
            lblResult.Text = Result + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
