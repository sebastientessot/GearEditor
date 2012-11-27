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
    public partial class ShaftCreationForm : Form
    {
        Material material;
        public static Material mTemp;
        Size btnSize;

        public ShaftCreationForm()
        {
            InitializeComponent();
            btnSize = new Size();
            btnSize.Width = 26;
            btnSize.Height = 22;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShaftCreationForm_Load(object sender, EventArgs e)
        {

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
                txtMaterial.Tag = material;
                txtMaterial.Visible = true;
                btnMaterial.Text = "...";
                btnMaterial.Size = btnSize;
                btnMaterial.Location = new Point(186, 134);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Shaft s = new Shaft();
            s.Name = txtName.Text;
            s.Diameter = Convert.ToDouble(numDiameter.Value);
            s.KeyCutWidth = Convert.ToDouble(numKeyCutWidth.Value);
            s.KeyCutHeigth = Convert.ToDouble(numKeyCutHeight.Value);
            s.KeyCutLength = Convert.ToDouble(numKeyCutLength.Value);
            s.Material = material;

            if (s.Name != "" && s.Material != null)
            {
                Database1DataSet1TableAdapters.Shaft1TableAdapter sta = new Database1DataSet1TableAdapters.Shaft1TableAdapter();
                sta.Insert(s.Name, s.Diameter, s.Material.ID, s.KeyCutWidth, s.KeyCutHeigth, s.KeyCutLength);
                Program.shaftList.Add(s);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (s.Name == "")
                    MessageBox.Show("You have to add a Name to your shaft", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You have to add a Material to your shaft", "Impossible to save the gear", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
