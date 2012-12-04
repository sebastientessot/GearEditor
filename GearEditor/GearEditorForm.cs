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
                Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
                gta.Delete(gearToDelete.ID, gearToDelete.Name, gearToDelete.Alpha, gearToDelete.GearModule, gearToDelete.Material.ID, gearToDelete.Torque, gearToDelete.Shaft.ID, gearToDelete.WantedRadius, gearToDelete.Z, gearToDelete.Phi, gearToDelete.R_base, gearToDelete.R_foot, gearToDelete.R_pitch, gearToDelete.R_top);
                
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
            gForm.hideSelect();
            gForm.Show();
            this.Close();
        }

        private void shaftEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShaftEditorForm sForm = new ShaftEditorForm();
            sForm.hideSelect();
            sForm.Show();
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

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("You may delete Gear Boxes associates. Do you want to continue ?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                if (listGear.SelectedItems.Count > 0)
                {
                    Gear gearToDelete = new Gear();
                    gearToDelete = (Gear)listGear.SelectedItems[0];

                    Program.gearList.Remove(gearToDelete);
                    Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
                    Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();

                    try
                    {
                        gbta.DeleteInputGearQuery(gearToDelete.ID);
                        gbta.DeleteOutputGearQuery(gearToDelete.ID);
                        gta.Delete(gearToDelete.ID, gearToDelete.Name, gearToDelete.Alpha, gearToDelete.GearModule, gearToDelete.Material.ID, gearToDelete.Torque, gearToDelete.Shaft.ID, gearToDelete.WantedRadius, gearToDelete.Z, gearToDelete.Phi, gearToDelete.R_base, gearToDelete.R_foot, gearToDelete.R_pitch, gearToDelete.R_top);
                        Util.refreshGearBoxList();
                    }
                    catch (Exception ex) { }

                }
                refreshList();
                propertyGridGear.SelectedObject = null;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                btnSelect.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (propertyGridGear.Enabled == false)
            {
                propertyGridGear.Enabled = true;
            }
            else
            {
                propertyGridGear.Enabled = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if (savedlg.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(savedlg.FileName);
                foreach (Gear g in Program.gearList)
                {
                    sw.WriteLine(g.Name);
                    sw.WriteLine(g.Alpha);
                    sw.WriteLine(g.GearModule);
                    sw.WriteLine(g.Material.Name);
                    sw.WriteLine(g.Torque);
                    sw.WriteLine(g.Shaft.Name);
                    sw.WriteLine(g.WantedRadius);
                    sw.WriteLine(g.Z);
                    sw.WriteLine(g.Phi);
                    sw.WriteLine(g.R_base);
                    sw.WriteLine(g.R_foot);
                    sw.WriteLine(g.R_pitch);
                    sw.WriteLine(g.R_top);

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

                XmlSerializer xmls = new XmlSerializer(typeof(List<Gear>));
                xmls.Serialize(fs, Program.gearList);

                fs.Close();
            }

        }
    }
}
