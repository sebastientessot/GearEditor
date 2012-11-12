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
    public partial class MaterialEditorForm : Form
    {
        public MaterialEditorForm()
        {
            InitializeComponent();
            refreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialCreationForm materialCreation = new MaterialCreationForm();
            if (materialCreation.ShowDialog() == DialogResult.OK)
            {
                //Refresh
            }
        }

        private void refreshList()
        {
            foreach (Material gb in Program.materialList)
            {
                listMaterial.Items.Add(gb);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listMaterial.SelectedItems.Count > 0)
            {
                GearCreationForm.mTemp = (Material)listMaterial.SelectedItems[0];
            }
        }
    }
}
