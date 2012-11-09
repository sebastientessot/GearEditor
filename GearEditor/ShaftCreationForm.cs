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
        public ShaftCreationForm()
        {
            InitializeComponent();
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
            if (materialEditor.ShowDialog() == DialogResult.OK)
            {
                //Changer le bouton Choose correspondant 
                // Ajouter le nom du Material
            }
        }
    }
}
