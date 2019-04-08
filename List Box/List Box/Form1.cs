using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Box
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

        private void lstCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstCountries.Items.Add(txtCountry.Text);
            txtCountry.Text = "";
            txtCountry.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstCountries.Items.RemoveAt(lstCountries.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCountries.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCountry.Text = "";
        }
    }
}
