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
    public partial class ShaftEditorForm : Form
    {
        /**
        * Contructor 
        */
        public ShaftEditorForm()
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
            ShaftCreationForm shaftCreation = new ShaftCreationForm(); 
            if(shaftCreation.ShowDialog()==DialogResult.OK)
            {
                refreshList(); 
            }
        }

        private void listShaft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                treeViewShaft.Nodes.Clear(); 
                treeViewShaft.Nodes.Add(Util.fillTreeView(listShaft.SelectedItems[0]));
                propertyGridShaft.SelectedObject = listShaft.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                btnSelect.Enabled = true; 
            }
        }

        private void treeViewShaft_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGridShaft.SelectedObject = treeViewShaft.SelectedNode.Tag; 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                GearCreationForm.sTemp = (Shaft)listShaft.SelectedItems[0];
            }
        }

        /*
        * No Event Handler Methods
        * 
        */

        private void refreshList()
        {
            listShaft.Items.Clear();
            foreach (Shaft gb in Program.shaftList)
            {
                listShaft.Items.Add(gb);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                Shaft shaftToDelete = new Shaft();
                shaftToDelete = (Shaft)listShaft.SelectedItems[0];
                foreach (Shaft s in Program.shaftList)
                {
                    if (s.Equals(shaftToDelete))
                    {
                        shaftToDelete = s;
                    }
                }
                Program.shaftList.Remove(shaftToDelete);
            }
            refreshList();
            treeViewShaft.Nodes.Clear();
            propertyGridShaft.SelectedObject = null;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnSelect.Enabled = false; 
        }
    }
}
