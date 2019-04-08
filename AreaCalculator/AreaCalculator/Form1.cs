using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            //declare variable (local scope)
            int width;  //stores the width of the rectangle
            int height; //stores the height of the rectangle
            int area;   //stores the result of multiplying width by height

            //read inputs
            width = Convert.ToInt32(txtWidth.Text);
            height = Convert.ToInt32(txtHeight.Text);

            //process(do calculation)
            area = width * height;

            //display output
            lblArea.Text = Convert.ToString(area);

        }
    }
}
