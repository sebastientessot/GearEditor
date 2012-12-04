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
    public partial class GearBoxEditorForm : Form
    {
        /**
         * Contructor 
         */

        public GearBoxEditorForm()
        {
            InitializeComponent();
            btnSelect.Hide();
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
                Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();
                gbta.Delete(gearBoxToDelete.ID, gearBoxToDelete.Name, gearBoxToDelete.Alpha, gearBoxToDelete.AxesDistance, gearBoxToDelete.GearModule, gearBoxToDelete.InputTorque, gearBoxToDelete.OutputTorque, gearBoxToDelete.TorqueRatio, gearBoxToDelete.InputGear.ID, gearBoxToDelete.OutputGear.ID);
                
            }
            refreshList();
            treeViewGearBox.Nodes.Clear();
            propertyGridGearBox.SelectedObject = null;
            this.btnRemove.Enabled = false;
            this.btnEdit.Enabled = false;
        }

        private void gearEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearEditorForm gForm = new GearEditorForm();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (propertyGridGearBox.Enabled == false)
            {
                propertyGridGearBox.Enabled = true;
            }
            else
            {
                propertyGridGearBox.Enabled = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if (savedlg.ShowDialog() == DialogResult.OK)
            {

                StreamWriter sw = new StreamWriter(savedlg.FileName);
                foreach (GearBox gb in Program.gearBoxList)
                {
                    sw.WriteLine(gb.Name);
                    sw.WriteLine(gb.Alpha);
                    sw.WriteLine(gb.AxesDistance);
                    sw.WriteLine(gb.GearModule);
                    sw.WriteLine(gb.InputTorque);
                    sw.WriteLine(gb.OutputTorque);
                    sw.WriteLine(gb.InputGear.Name);
                    sw.WriteLine(gb.OutputGear.Name);
                  

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

                XmlSerializer xmls = new XmlSerializer(typeof(List<GearBox>));
                xmls.Serialize(fs, Program.gearBoxList);

                fs.Close();
            }
        }
    }
}
