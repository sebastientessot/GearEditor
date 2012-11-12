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
        public ShaftEditorForm()
        {
            InitializeComponent();
            refreshList(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShaftCreationForm shaftCreation = new ShaftCreationForm(); 
            if(shaftCreation.ShowDialog()==DialogResult.OK){
                // Refresh
            }
        }

        private void listShaft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                treeViewShaft.Nodes.Clear(); 
                treeViewShaft.Nodes.Add(Util.fillTreeView(listShaft.SelectedItems[0]));
                propertyGridShaft.SelectedObject = listShaft.SelectedItems[0]; 
            }
        }

        private void treeViewShaft_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGridShaft.SelectedObject = treeViewShaft.SelectedNode.Tag; 
        }



        private void refreshList()
        {
            foreach (Shaft gb in Program.shaftList)
            {
                listShaft.Items.Add(gb);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                GearCreationForm.sTemp = (Shaft)listShaft.SelectedItems[0];
            }
        }
    }
}
