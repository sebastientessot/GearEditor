using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearEditor
{
    public partial class MaterialCreationForm : Form
    {
        public MaterialCreationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Name = txtName.Text;
            m.Density = Convert.ToDouble(numDensity.Value);
            m.yieldStress = Convert.ToDouble(numYieldStress.Value);
            m.youngsModulus = Convert.ToDouble(numYoungModulus.Value);

            if (m.Name != "")
            {
                Program.materialList.Add(m);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You have to add a Name to your Material", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
