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
        public GearEditorForm()
        {
            InitializeComponent();
            refreshList(); 
        }

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
            }
        }

        private void treeViewGear_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGridGear.SelectedObject = treeViewGear.SelectedNode.Tag; 
        }



        private void refreshList()
        {
            listGear.Items.Clear();
            foreach (Gear gb in Program.gearList)
            {
                listGear.Items.Add(gb);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listGear.SelectedItems.Count > 0)
            {
                GearBoxCreationForm.gTemp = (Gear) listGear.SelectedItems[0];
            }    
        }
    }
}
