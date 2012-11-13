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
          /*  Shaft s = new Shaft();
            s.Name = txtName.Text;
            s.Diameter = Convert.ToDouble(numDiameter.Value);
            s.KeyCutWidth = Convert.ToDouble(numKeyCutWidth.Value);
            s.KeyCutHeigth = Convert.ToDouble(numKeyCutHeight.Value);
            s.KeyCutLength = Convert.ToDouble(numKeyCutLength.Value);
            s.Material = material;
            */
            if (s.Name != "")
            {
                Program.shaftList.Add(s);
                DialogResult = DialogResult.OK;
            }
            else
            {
                 MessageBox.Show("You have to add a Name to your Material", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }
    }
}
