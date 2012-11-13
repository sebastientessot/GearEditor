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
    public partial class GearBoxEditorForm : Form
    {
        /**
         * Contructor 
         */

        public GearBoxEditorForm()
        {
            InitializeComponent();
            btnSelect.Hide();
            btnCancel.Hide();
            refreshList();
        }


        /**
         * Event Handler Methods 
         * 
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GearBoxCreationForm gearBoxCreation = new GearBoxCreationForm();
            if (gearBoxCreation.ShowDialog() == DialogResult.OK)
            {
                refreshList();
            }
        }

        private void listGearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGearBox.SelectedItems.Count > 0)
            {
                treeViewGearBox.Nodes.Clear();
                treeViewGearBox.Nodes.Add(Util.fillTreeView(listGearBox.SelectedItems[0]));
                propertyGridGearBox.SelectedObject = listGearBox.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        private void treeViewGearBox_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGridGearBox.SelectedObject = treeViewGearBox.SelectedNode.Tag;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
         * No Event Handler Methods
         * 
         */

        private void refreshList()
        {
            listGearBox.Items.Clear();
            foreach (GearBox gb in Program.gearBoxList)
            {
                listGearBox.Items.Add(gb);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listGearBox.SelectedItems.Count > 0)
            {
                GearBox gearBoxToDelete = new GearBox();
                gearBoxToDelete = (GearBox)listGearBox.SelectedItems[0];
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
            treeViewGearBox.Nodes.Clear();
            propertyGridGearBox.SelectedObject = null;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
        }
    }
}
