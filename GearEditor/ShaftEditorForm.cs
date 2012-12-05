using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


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
            if (shaftCreation.ShowDialog() == DialogResult.OK)
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
            foreach (Shaft s in Program.shaftList)
            {
                listShaft.Items.Add(s);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("You may delete Gears and Gear Boxes associated. Do you want to continue ?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                if (listShaft.SelectedItems.Count > 0)
                {
                    Shaft shaftToDelete = new Shaft();
                    shaftToDelete = (Shaft)listShaft.SelectedItems[0];

                    Program.shaftList.Remove(shaftToDelete);
                    Database1DataSet1TableAdapters.Shaft1TableAdapter sta = new Database1DataSet1TableAdapters.Shaft1TableAdapter();
                    Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
                    Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();

                    List<int> gearIds = Util.listOfGearIds(shaftToDelete.ID, gta);
                    try
                    {
                        foreach (int g in gearIds)
                        {
                            gbta.DeleteInputGearQuery(g);
                            gbta.DeleteOutputGearQuery(g);
                            Gear gear = Util.getGearById(g);
                            Program.gearList.Remove(gear);
                        }

                        gta.DeleteShaftQuery(shaftToDelete.ID);
                        sta.Delete(shaftToDelete.ID, shaftToDelete.Name, shaftToDelete.Diameter, shaftToDelete.Material.ID, shaftToDelete.KeyCutWidth, shaftToDelete.KeyCutHeigth, shaftToDelete.KeyCutLength);
                        Util.refreshGearBoxList();
                    }
                    catch (Exception ex) { }
                }
                refreshList();
                treeViewShaft.Nodes.Clear();
                propertyGridShaft.SelectedObject = null;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                btnSelect.Enabled = false;
            }
        }

        private void ShaftEditorForm_Load(object sender, EventArgs e)
        {
            refreshList();
        }

        private void gearBoxEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearBoxEditorForm gbForm = new GearBoxEditorForm();
            gbForm.hideSelect();
            gbForm.Show();
            this.Close();
        }

        private void gearEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearEditorForm gForm = new GearEditorForm();
            gForm.hideSelect();
            gForm.Show();
            this.Close();
        }

        private void materialEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialEditorForm mForm = new MaterialEditorForm();
            mForm.hideSelect();
            mForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (propertyGridShaft.Enabled == false)
            {
                propertyGridShaft.Enabled = true;
            }
            else
            {
                propertyGridShaft.Enabled = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if (savedlg.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(savedlg.FileName);
                foreach (Shaft s in Program.shaftList)
                {
                    sw.WriteLine(s.Name);
                    sw.WriteLine(s.Diameter);
                    sw.WriteLine(s.KeyCutWidth);
                    sw.WriteLine(s.KeyCutLength);
                    sw.WriteLine(s.KeyCutHeigth);
                    sw.WriteLine(s.Material.Name);
                }
                sw.Close();
            }
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if (savedlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(savedlg.FileName, FileMode.Create);

                XmlSerializer xmls = new XmlSerializer(typeof(List<Shaft>));
                xmls.Serialize(fs, Program.shaftList);

                fs.Close();
            }

        }

        private void propertyGridShaft_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (listShaft.SelectedItems.Count > 0)
            {
                treeViewShaft.Nodes.Clear();
                treeViewShaft.Nodes.Add(Util.fillTreeView(listShaft.SelectedItems[0]));
                propertyGridShaft.SelectedObject = listShaft.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
            }
        }
    }
}
