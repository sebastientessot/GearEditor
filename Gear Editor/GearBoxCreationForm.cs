using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gear_Editor
{
    public partial class GearBoxCreationForm : Form
    {
        public GearBoxCreationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGearBoxCreationAxesDistance_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblGearBoxCreationOutputGear_Click(object sender, EventArgs e)
        {

        }

        private void nbGearBoxCreationAlpha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnInputGear_Click(object sender, EventArgs e)
        {
            GearForm inputGearCreation = new GearForm();
            inputGearCreation.Text = "Choose the Input Gear";
            inputGearCreation.ShowDialog(); 
        }


    }
}
