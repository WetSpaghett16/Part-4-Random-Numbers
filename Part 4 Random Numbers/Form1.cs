using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Random_Numbers
{
    public partial class Form1 : Form
    {
        int Minimum;
        int Maximum;
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInteger_Click_1(object sender, EventArgs e)
        {
            generator.Next(Minimum, Maximum);
        }

        private void txtMinimum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaximum_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
