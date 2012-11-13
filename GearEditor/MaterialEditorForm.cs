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
        /**
        * Contructor 
        */
        public MaterialEditorForm()
        {
            InitializeComponent();
            refreshList();
        }



        /**
        * Event Handler Methods 
        * 
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialCreationForm materialCreation = new MaterialCreationForm();
            if (materialCreation.ShowDialog() == DialogResult.OK)
            {
                refreshList(); 
            }
        }

        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listMaterial.SelectedItems.Count > 0)
            {
                GearCreationForm.mTemp = (Material)listMaterial.SelectedItems[0];
                ShaftCreationForm.mTemp = (Material)listMaterial.SelectedItems[0];
            }
        }

       /*
       * No Event Handler Methods
       * 
       */
        private void refreshList()
        {
            foreach (Material gb in Program.materialList)
            {
                listMaterial.Items.Add(gb);
            }
        }

        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMaterial.SelectedItems.Count > 0)
            {
                propertyGridMaterial.SelectedObject = listMaterial.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             if (listMaterial.SelectedItems.Count > 0)
            {
                Material materialToDelete = new Material();
                materialToDelete = (Material)listMaterial.SelectedItems[0];
                foreach (Material m in Program.materialList)
                {
                    if (m.Equals(materialToDelete))
                    {
                        materialToDelete = m;
                    }
                }
                Program.materialList.Remove(materialToDelete);
            }
            refreshList();
            propertyGridMaterial.SelectedObject = null;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
        }
        }
    }
}
