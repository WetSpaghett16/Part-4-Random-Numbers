﻿using System;
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
        //Need to store result in variable
        int Minimum;
        int Maximum;
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
           
           Result = generator.Next(Minimum, Maximum);
            lblResult.Text = Result + "";
        }

        private void txtMinimum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaximum_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
