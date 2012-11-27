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
    public partial class GearBoxCreationForm : Form
    {
        Gear inputGear;
        Gear outputGear;
        public static Gear gTemp;
        Size btnSize;

        public GearBoxCreationForm()
        {
            InitializeComponent();
            btnSize = new Size();
            btnSize.Width = 26;
            btnSize.Height = 22;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TODO: Save
            GearBox gb = new GearBox();
            gb.Name = txtName.Text;
            gb.Alpha = Convert.ToDouble(numAlpha.Value);
            gb.AxesDistance = Convert.ToDouble(numAxisDistance.Value);
            gb.GearModule = Convert.ToDouble(numGearModule.Value);
            gb.InputGear = inputGear;
            gb.OutputGear = outputGear;
            gb.OutputTorque = Convert.ToDouble(numOutputTorque.Value);
            gb.InputTorque = Convert.ToDouble(numInputTorque.Value);
            gb.TorqueRatio = Convert.ToDouble(numTorqueRatio.Value);

            if (gb.Name != "" && gb.InputGear != null && gb.OutputGear != null)
            {
                Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();
                gbta.Insert(gb.Name, gb.Alpha,gb.AxesDistance,gb.GearModule,gb.InputTorque, gb.OutputTorque, gb.TorqueRatio, gb.InputGear.ID, gb.OutputGear.ID);
                Program.gearBoxList.Add(gb);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (gb.Name == "")
                    MessageBox.Show("You have to add a Name to your gear box", "Impossible to save the gear box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (gb.InputGear == null)
                    MessageBox.Show("You have to add a Input Gear to your gear box", "Impossible to save the gear box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You have to add a Output Gear to your gear box", "Impossible to save the gear box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInputGear_Click(object sender, EventArgs e)
        {
            GearEditorForm gearEditor = new GearEditorForm();
            gearEditor.menuStripVisible(false);
            if (gearEditor.ShowDialog() == DialogResult.OK)
            {
                // Ajouter le nom du gear
                inputGear = gTemp;

                //Changer le bouton Choose correspondant
                txtInputGear.Text = inputGear.Name;
                txtInputGear.Visible = true;
                btnInputGear.Text = "...";
                btnInputGear.Size = btnSize;
                btnInputGear.Location = new Point(188, 191);


            }

        }

        private void btnOutputGear_Click(object sender, EventArgs e)
        {
            GearEditorForm gearEditor = new GearEditorForm();
            gearEditor.menuStripVisible(false);
            if (gearEditor.ShowDialog() == DialogResult.OK)
            {
                // Ajouter le nom du gear
                outputGear = gTemp;

                //Changer le bouton Choose correspondant
                txtOutputGear.Text = outputGear.Name;
                txtOutputGear.Visible = true;
                btnOutputGear.Text = "...";
                btnOutputGear.Size = btnSize;
                btnOutputGear.Location = new Point(188, 220);
            }
        }
    }
}
