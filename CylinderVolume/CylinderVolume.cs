/*
*Created by: Matthew Clement
*Created on: 05-Nov-2015
*Created for: Unit #4-05
*This program calculates the volume of a cylinder
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CylinderVolume
{
    public partial class frmCylinderVolume : Form
    {

        public double CalculateVolume(double radius, double height)
        {
            double volume = 0;
            volume = Math.PI * (radius * radius) * height;
            return volume;
        }

        public frmCylinderVolume()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radiusInput;
            double heightInput;
            double volume;

            radiusInput = Convert.ToDouble(this.txtRadius.Text);
            heightInput = Convert.ToDouble(this.txtHeight.Text);

            volume = CalculateVolume(radiusInput, heightInput);
            volume = Math.Round(volume, 2);

            this.lblAnswer.Text = Convert.ToString(volume);
        }
    }
}
