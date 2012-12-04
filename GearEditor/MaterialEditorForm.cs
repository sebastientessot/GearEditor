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
                GearBoxGenerator.mInputTemp = (Material)listMaterial.SelectedItems[0];
                GearBoxGenerator.mOutputTemp = (Material)listMaterial.SelectedItems[0];
            }
        }



        private void listMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMaterial.SelectedItems.Count > 0)
            {
                propertyGridMaterial.SelectedObject = listMaterial.SelectedItems[0];
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;
                btnSelect.Enabled = true;
            }
        }

        /*
        * No Event Handler Methods
        * 
        */
        private void refreshList()
        {
            listMaterial.Items.Clear();
            foreach (Material gb in Program.materialList)
            {
                listMaterial.Items.Add(gb);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("You may delete the Shafts, Gears and Gear Boxes associates. Do you want to continue ?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                if (listMaterial.SelectedItems.Count > 0)
                {
                    Material materialToDelete = new Material();
                    materialToDelete = (Material)listMaterial.SelectedItems[0];

                    Program.materialList.Remove(materialToDelete);
                    Database1DataSet1TableAdapters.MaterialsTableAdapter mta = new Database1DataSet1TableAdapters.MaterialsTableAdapter();
                    Database1DataSet1TableAdapters.Shaft1TableAdapter sta = new Database1DataSet1TableAdapters.Shaft1TableAdapter();
                    Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
                    Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();

                    List<int> shaftIds = Util.listOfShaftIds(materialToDelete.ID, sta);
                    List<int> gearIds = Util.listOfGearIds(materialToDelete.ID, shaftIds, gta);
                    try
                    {
                        foreach (int g in gearIds)
                        {
                            gbta.DeleteInputGearQuery(g);
                            gbta.DeleteOutputGearQuery(g);
                            Gear gear = Util.getGearById(g);
                            Program.gearList.Remove(gear);
                        }

                        foreach (int s in shaftIds) 
                        {
                            gta.DeleteShaftQuery(s);
                            Shaft shaft = Util.getShaftById(s);
                            Program.shaftList.Remove(shaft);
                        }
                        sta.DeleteQuery(materialToDelete.ID);
                        mta.Delete(materialToDelete.ID, materialToDelete.Name, materialToDelete.youngsModulus, materialToDelete.Density, materialToDelete.yieldStress);
                        Util.refreshGearBoxList();
                    }
                    catch (Exception ex) { }

                }
                refreshList();
                propertyGridMaterial.SelectedObject = null;
                btnRemove.Enabled = false;
                btnEdit.Enabled = false;
                btnSelect.Enabled = false;
            }
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

        private void shaftEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShaftEditorForm sForm = new ShaftEditorForm();
            sForm.hideSelect();
            sForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if(savedlg.ShowDialog() == DialogResult.OK){

                StreamWriter sw = new StreamWriter(savedlg.FileName);
                foreach (Material m in Program.materialList)
                {
                    sw.WriteLine(m.Name);
                    sw.WriteLine(m.Density);
                    sw.WriteLine(m.yieldStress);
                    sw.WriteLine(m.youngsModulus);
                }
                sw.Close();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if(opendlg.ShowDialog() == DialogResult.OK){
                StreamReader sr = new StreamReader(opendlg.FileName);
                Boolean readNext = true;
                String line = sr.ReadLine();
                while (readNext == true)
                {
                    try
                    {
                        Material m = new Material();
                        m.Name = sr.ReadLine();
                        m.Density = Convert.ToDouble(sr.ReadLine());
                        m.yieldStress = Convert.ToDouble(sr.ReadLine());
                        m.youngsModulus = Convert.ToDouble(sr.ReadLine());

                        if (m.Name != null)
                            Program.materialList.Add(m);
                        else
                            readNext = false;
                    }
                    catch (Exception ex)
                    {
                        readNext = false; 
                    }
                }
            }
        }

        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            if (savedlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(savedlg.FileName, FileMode.Create);

                XmlSerializer xmls = new XmlSerializer(typeof(List<Material>));
                xmls.Serialize(fs, Program.materialList);

                fs.Close();
            }
        }

        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(opendlg.FileName, FileMode.Open);

                XmlSerializer xmls = new XmlSerializer(typeof(List<Material>));

                object o = xmls.Deserialize(fs);

                fs.Close();

                Program.materialList.AddRange((List<Material>)o);
            }
        }

        private void MaterialEditorForm_Load(object sender, EventArgs e)
        {
            propertyGridMaterial.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (propertyGridMaterial.Enabled == false)
            {
                propertyGridMaterial.Enabled = true;
            }
            else
            {
                propertyGridMaterial.Enabled = false;
            }
        }
    }
}
