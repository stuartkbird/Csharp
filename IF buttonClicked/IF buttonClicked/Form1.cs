﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_buttonClicked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool buttonClicked = true;
            if (buttonClicked == true)
            {
                MessageBox.Show("The button was clicked");
            }
            else
            {
                MessageBox.Show("buttonClicked has a value of false");
            }
        }
    }
}
