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
    public partial class GearEditorForm : Form
    {
        /**
        * Contructor 
        */
        public GearEditorForm()
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
            GearCreationForm gearCreation = new GearCreationForm();
            if (gearCreation.ShowDialog() == DialogResult.OK)
            {
                refreshList();
            }

        }

        private void listGear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGear.SelectedItems.Count > 0)
            {
                treeViewGear.Nodes.Clear(); 
                treeViewGear.Nodes.Add(Util.fillTreeView(listGear.SelectedItems[0]));
                propertyGridGear.SelectedObject = listGear.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true; 
            }
        }

        private void treeViewGear_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGridGear.SelectedObject = treeViewGear.SelectedNode.Tag; 
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listGear.SelectedItems.Count > 0)
            {
                GearBoxCreationForm.gTemp = (Gear) listGear.SelectedItems[0];
            }    
        }

        /*
        * No Event Handler Methods
        * 
        */

        private void refreshList()
        {
            listGear.Items.Clear();
            foreach (Gear gb in Program.gearList)
            {
                listGear.Items.Add(gb);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listGear.SelectedItems.Count > 0)
            {
                GearBox gearBoxToDelete = new GearBox();
                gearBoxToDelete = (GearBox)listGear.SelectedItems[0];
                foreach (GearBox gb in Program.gearBoxList)
                {
                    if (gb.Equals(gearBoxToDelete))
                    {
                        gearBoxToDelete = gb;
                    }
                }
                Program.gearBoxList.Remove(gearBoxToDelete);
            }
            refreshList();
            treeViewGear.Nodes.Clear();
            propertyGridGear.SelectedObject = null;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
        }
    }
}
