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
    public partial class GearCreationForm : Form
    {
        Material material;
        public static Material mTemp;
        Shaft shaft;
        public static Shaft sTemp;
        Size btnSize;
        public GearCreationForm()
        {
            InitializeComponent();
            btnSize = new Size();
            btnSize.Width = 26;
            btnSize.Height = 22;
        }

        private void btnShaft_Click(object sender, EventArgs e)
        {
            ShaftEditorForm shaftEditor = new ShaftEditorForm();
            shaftEditor.menuStripVisible(false);
            if (shaftEditor.ShowDialog() == DialogResult.OK)
            {
                // Ajouter le nom du Shaft
                shaft = sTemp;

                //Changer le bouton Choose correspondant
                txtShaft.Text = shaft.Name;
                txtShaft.Visible = true;
                btnShaft.Text = "...";
                btnShaft.Size = btnSize;
                btnShaft.Location = new Point(186, 129);

            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MaterialEditorForm materialEditor = new MaterialEditorForm();
            materialEditor.menuStripVisible(false);
            if (materialEditor.ShowDialog() == DialogResult.OK)
            {
                // Ajouter le nom du Material
                material = mTemp;

                //Changer le bouton Choose correspondant 
                txtMaterial.Text = material.Name;
                txtMaterial.Visible = true;
                btnMaterial.Text = "...";
                btnMaterial.Size = btnSize;
                btnMaterial.Location = new Point(186, 158);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Gear g = new Gear();
            g.Name = txtName.Text;
            g.Alpha = Convert.ToDouble(numAlpha.Value);
            g.GearModule = Convert.ToDouble(numGearModule.Value);
            g.Torque = Convert.ToDouble(numTorque.Value);
            g.WantedRadius = Convert.ToDouble(numWantedRadius.Value);
            g.Shaft = shaft;
            g.Material = material;



            if (g.Name != "" && g.Material != null && g.Shaft != null)
            {
                Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
                gta.Insert(g.Name, g.Alpha, g.GearModule, g.Material.ID, g.Torque, g.Shaft.ID,g.WantedRadius, 0,0,0,0,0,0);
                Program.gearList.Add(g);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (g.Name == "")
                    MessageBox.Show("You have to add a Name to your gear", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (g.Shaft == null)
                    MessageBox.Show("You have to add a Shaft to your gear", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You have to add a Material to your gear", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
