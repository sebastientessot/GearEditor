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
                btnSelect.Enabled = true;
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
                GearBoxCreationForm.gTemp = (Gear)listGear.SelectedItems[0];
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listGear.SelectedItems.Count > 0)
            {
                Gear gearToDelete = new Gear();
                gearToDelete = (Gear)listGear.SelectedItems[0];
                foreach (Gear g in Program.gearList)
                {
                    if (g.Equals(gearToDelete))
                    {
                        gearToDelete = g;
                    }
                }
                Program.gearList.Remove(gearToDelete);
            }
            refreshList();
            treeViewGear.Nodes.Clear();
            propertyGridGear.SelectedObject = null;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            btnSelect.Enabled = false;
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

        private void gearBoxEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearBoxEditorForm gForm = new GearBoxEditorForm();
            gForm.Show();
            this.Close();
        }

        private void shaftEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShaftEditorForm sForm = new ShaftEditorForm();
            sForm.Show();
            this.Close();
        }

        private void materialEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialEditorForm mForm = new MaterialEditorForm();
            mForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
