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
    public partial class GearCreationForm : Form
    {
        public GearCreationForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddGearBox_Click(object sender, EventArgs e)
        {
            GearBoxCreationForm newGearBox = new GearBoxCreationForm();
            if (newGearBox.ShowDialog().Equals(DialogResult.OK)){
                newGearBox.Close();
            }

        }

        private void listGearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
