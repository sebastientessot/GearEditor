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
        public GearCreationForm()
        {
            InitializeComponent();
        }

        private void btnShaft_Click(object sender, EventArgs e)
        {
            ShaftEditorForm shaftEditor = new ShaftEditorForm();
            if (shaftEditor.ShowDialog() == DialogResult.OK) {
                //Changer le bouton Choose correspondant 
                // Ajouter le nom du Shaft
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            MaterialEditorForm materialEditor = new MaterialEditorForm();
            if (materialEditor.ShowDialog() == DialogResult.OK)
            {
                //Changer le bouton Choose correspondant 
                // Ajouter le nom du Material
            }
        }
    }
}
