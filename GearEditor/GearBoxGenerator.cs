using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// TODO : Le truc avec CATIA
// TODO : Gérer le tree View et le PropertyGrid à la fin de la méthode du click sur Generate

namespace GearEditor
{
    public partial class GearBoxGenerator : Form
    {
        public static Material mInputTemp;
        public static Material mOutputTemp;
        Material inputMaterial;
        Material outputMaterial;
        Size buttonSize;
        double inputC1;
        double inputC2;
        double outputC1; 
        double outputC2; 
        String path;
        GearBox gearBox;
        Gear inputGear;
        Gear outputGear;


        public GearBoxGenerator()
        {
            InitializeComponent();
            buttonSize = new Size();
            buttonSize.Width = 26;
            buttonSize.Height = 22;
            path = Directory.GetCurrentDirectory(); 
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnValidate.Visible = false;
            
            if (txtName.Text == "")
               MessageBox.Show("You have to add a Name to your InputGear", "Impossible to generate a GearBox ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtInputMaterial.Tag == null)
                MessageBox.Show("You have to add a Material to your InputGear", "Impossible to generate a GearBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtOutputMaterial.Tag == null)
                MessageBox.Show("You have to add a Material to your OutputGear", "Impossible to generate a GearBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                tsStatusLabel.Text = "Starting the generation...";

                numTorqueRatio.Value = numOutputTorque.Value / numInputTorque.Value;
                double axesDistance = Convert.ToDouble(numAxesDistance.Value);
                double torqueRatio = Convert.ToDouble(numTorqueRatio.Value);
                gearBox = new GearBox();
                inputGear = new Gear();
                outputGear = new Gear();
                double alpha = Convert.ToDouble(numAlpha.Value)*Math.PI/180;

                /*
                 * Data extraction 
                 */

                // Gear Box Creation
                gearBox.Name = txtName.Text;
                gearBox.Alpha = alpha;
                gearBox.GearModule = Convert.ToDouble(numGearModule.Value);
                gearBox.AxesDistance = axesDistance;
                gearBox.TorqueRatio = torqueRatio;
                gearBox.InputTorque = Convert.ToDouble(numInputTorque.Value);
                gearBox.OutputTorque = Convert.ToDouble(numOutputTorque.Value);
                gearBox.InputGear = inputGear;
                gearBox.OutputGear = outputGear;

                // Input Gear Creation
                inputGear.Name = txtName.Text + " Input Gear";
                inputGear.Alpha = alpha;
                inputGear.GearModule = Convert.ToDouble(numGearModule.Value);
                inputGear.WantedRadius = axesDistance * (1 / (1 + torqueRatio));
                inputGear.Torque = Convert.ToDouble(numInputTorque.Value);
                inputGear.Material = (Material)txtInputMaterial.Tag;


                // Output Gear Creation
                outputGear.Name = txtName.Text + " Output Gear";
                outputGear.Alpha = alpha;
                outputGear.GearModule = Convert.ToDouble(numGearModule.Value);
                outputGear.WantedRadius = axesDistance * (1 - 1 / (1 + torqueRatio));
                outputGear.Torque = Convert.ToDouble(numOutputTorque.Value);
                outputGear.Material = (Material)txtOutputMaterial.Tag;

                /*
                 * Data Calculation
                 */

                //Input Gear Calculation
                gearCalculation(inputGear, true);
                updateGearOnCatia(inputGear, true);
              
                       
                gearCalculation(outputGear, false);       
                updateGearOnCatia(outputGear, false);
                showGearboxOnCatia(gearBox);

                updateTreeView(gearBox);
                this.btnValidate.Visible = true;
            }
        }

        private void gearCalculation(Gear gear, bool isInput) {
            if (isInput)
                tsStatusLabel.Text = "Calculation of the input Gear...";
            else
                tsStatusLabel.Text = "Calculation of the output Gear...";
            Mathcad.Application mathCadApp=null;
            try
            {
                mathCadApp = System.Runtime.InteropServices.Marshal.GetActiveObject("MathCAD.Application") as Mathcad.Application;
            }
            catch (Exception ex) {
                mathCadApp = System.Activator.CreateInstance(Type.GetTypeFromProgID("MathCAD.Application")) as Mathcad.Application;
            }
            finally
            {
                mathCadApp.Worksheets.Open(path + "/gear calculation.xmcd");
            }
            mathCadApp.Visible = true;

            Mathcad.Worksheet ws= mathCadApp.ActiveWorksheet;
            ws.SetValue("module", gear.GearModule );
            ws.SetValue("RD", gear.WantedRadius );
            ws.SetValue("Alpha", gear.Alpha );

            String value;
            value = ws.GetValue("z_t").asString;
            gear.Z = Convert.ToDouble(value);
            value = ws.GetValue("phi").asString;
            gear.Phi = Convert.ToDouble(value);
            value = ws.GetValue("r_base").asString;
            gear.R_base = Convert.ToDouble(value);
            value = ws.GetValue("r_foot").asString;
            gear.R_foot = Convert.ToDouble(value);
            value = ws.GetValue("r_pitch").asString;
            gear.R_pitch = Convert.ToDouble(value);
            value = ws.GetValue("r_top").asString;
            gear.R_top = Convert.ToDouble(value);

            gear.Shaft = createShaft(gear.Material, gear.Torque, isInput );

       
        }

        private Shaft createShaft(Material material, Double torque, bool isInput) {
            if (isInput)
                tsStatusLabel.Text = "Calculation of the input Shaft...";
            else
                tsStatusLabel.Text = "Calculation of the output Shaft...";
            Shaft shaft = new Shaft();
            if (isInput)
                shaft.Name = txtName.Text + " Input Shaft";
            else
                shaft.Name = txtName.Text + " Output Shaft"; 
            shaft.Material = material;
           
            // MathCAD 
            Mathcad.Application mathCadApp =null;
            try
            {
                mathCadApp = System.Runtime.InteropServices.Marshal.GetActiveObject("MathCAD.Application") as Mathcad.Application;
            }
            catch (Exception ex)
            {
                mathCadApp = System.Activator.CreateInstance(Type.GetTypeFromProgID("MathCAD.Application")) as Mathcad.Application;
            }
            finally {
                mathCadApp.Worksheets.Open(path+"/Shaft dimensioning.xmcd");
            }
            mathCadApp.Visible = true;

            Mathcad.Worksheet ws = mathCadApp.ActiveWorksheet;
            ws.SetValue("yield_stress", material.yieldStress);
            ws.SetValue("M", torque*1000);

            String value;
            value = ws.GetValue("diameter").asString;
            shaft.Diameter = Convert.ToInt32(value);

            // Microsoft Excel 
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                excelApp = System.Runtime.InteropServices.Marshal.GetActiveObject("Excel.Application") as Microsoft.Office.Interop.Excel.Application;
                if (!excelApp.ActiveWorkbook.Path.Equals(path) || !excelApp.ActiveWorkbook.Path.Equals(path))
                    excelApp.Workbooks.Open(path + "/Key design.xlsx");
            }
            catch (Exception ex)
            {
                excelApp = System.Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application")) as Microsoft.Office.Interop.Excel.Application;
                excelApp.Workbooks.Open(path + "/Key design.xlsx");
            }
           // excelApp.Visible=true;

            Microsoft.Office.Interop.Excel.Worksheet excelWs = excelApp.ActiveWorkbook.ActiveSheet;
            excelWs.Cells[5,1] = torque;
            excelWs.Cells[5, 3] = shaft.Diameter; 

            shaft.KeyCutLength = Convert.ToDouble(excelWs.Cells[5,8].Value);
            shaft.KeyCutHeigth = Convert.ToDouble(excelWs.Cells[5, 5].Value);
            shaft.KeyCutWidth = Convert.ToDouble(excelWs.Cells[5,4].Value);

            if (isInput)
            {
                inputC1 = Convert.ToDouble(excelWs.Cells[5, 6].Value);
                inputC2 = Convert.ToDouble(excelWs.Cells[5, 7].Value);
            }
            else
            {
                outputC1 = Convert.ToDouble(excelWs.Cells[5, 6].Value);
                outputC2 = Convert.ToDouble(excelWs.Cells[5, 7].Value);
            }

            return shaft; 
        }

        private void btnInputMaterial_Click(object sender, EventArgs e)
        {
            MaterialEditorForm materialEditor = new MaterialEditorForm();
            materialEditor.menuStripVisible(false);
            if (materialEditor.ShowDialog() == DialogResult.OK)
            {

                // Ajouter le nom du Material
                inputMaterial = mInputTemp;

                //Changer le bouton Choose correspondant 
                txtInputMaterial.Text = inputMaterial.Name;
                txtInputMaterial.Tag = inputMaterial;
                txtInputMaterial.Visible = true;
                btnInputMaterial.Text = "...";
                btnInputMaterial.Size = buttonSize;
                btnInputMaterial.Location = new Point(213, 144);

            }
        }

        private void btnOutputMaterial_Click(object sender, EventArgs e)
        {
            MaterialEditorForm materialEditor = new MaterialEditorForm();
            materialEditor.menuStripVisible(false);
            if (materialEditor.ShowDialog() == DialogResult.OK)
            {

                // Ajouter le nom du Material
                outputMaterial = mOutputTemp;

                //Changer le bouton Choose correspondant 
                txtOutputMaterial.Text = outputMaterial.Name;
                txtOutputMaterial.Tag = outputMaterial;
                txtOutputMaterial.Visible = true;
                btnOutputMaterial.Text = "...";
                btnOutputMaterial.Size = buttonSize;
                btnOutputMaterial.Location = new Point(213, 196);
            }
        }

        private void updateGearOnCatia(Gear g, Boolean isInput) {
            if (isInput)
                tsStatusLabel.Text = "Updating the input Gear on Catia...";
            else
                tsStatusLabel.Text = "Updating the output Gear on Catia...";
            INFITF.Application catiaApp = null;
            try
            {
                catiaApp = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application") as INFITF.Application;
            }
            catch (Exception ex)
            {
                catiaApp = System.Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application")) as INFITF.Application;
            }
            finally
            {
                catiaApp.Visible = true;
                if (isInput == true)
                {
                    catiaApp.Documents.Open(path + "\\inputGear.CATPart");
                }
                else
                    catiaApp.Documents.Open(path + "\\outputGear.CATPart");
            }
            MECMOD.PartDocument partDocument = (MECMOD.PartDocument) catiaApp.ActiveDocument;  
            ProductStructureTypeLib.Product product = partDocument.Product;

            KnowledgewareTypeLib.Parameter type = (KnowledgewareTypeLib.Parameter) product.Parameters.GetItem("Alpha");
            type.ValuateFromString(g.Alpha + "rad");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("Module");
            type.ValuateFromString(g.GearModule + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("Z");
            type.ValuateFromString(g.Z.ToString());

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("Radius");
            type.ValuateFromString(g.WantedRadius + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("r_top");
            type.ValuateFromString(g.R_top+ "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("r_base");
            type.ValuateFromString(g.R_pitch + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("r_foot");
            type.ValuateFromString(g.R_foot + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("phi");
            type.ValuateFromString(g.Phi + "rad");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("D_Shaft");
            type.ValuateFromString(g.Shaft.Diameter + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("KeyWidth");
            type.ValuateFromString(g.Shaft.KeyCutWidth + "mm");
            
            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("KeyLength");
            type.ValuateFromString(g.Shaft.KeyCutLength + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("KeyWidth");
            type.ValuateFromString(g.Shaft.KeyCutWidth + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("C1");
            if (isInput == true)
                type.ValuateFromString(inputC1 + "mm");
            else 
                type.ValuateFromString(outputC1 + "mm");

            type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("C2");
            if (isInput == true)
                type.ValuateFromString(inputC2 + "mm");
            else 
                type.ValuateFromString(outputC2 + "mm");

            product.Update();
            partDocument.Save(); 

        }

        private void showGearboxOnCatia(GearBox gb) {
            tsStatusLabel.Text = "Generating the Gear Box on Catia...";
            INFITF.Application catiaApp = null;
            try
            {
                catiaApp = System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application") as INFITF.Application;
            }
            catch (Exception ex)
            {
                catiaApp = System.Activator.CreateInstance(Type.GetTypeFromProgID("CATIA.Application")) as INFITF.Application;
            }
            finally
            {
                catiaApp.Visible = true;
                catiaApp.Documents.Open(path + "\\GearBox.CATProduct");
            }
            ProductStructureTypeLib.ProductDocument productDoc = (ProductStructureTypeLib.ProductDocument)catiaApp.ActiveDocument;
            ProductStructureTypeLib.Product product = productDoc.Product;

            KnowledgewareTypeLib.Parameter type = (KnowledgewareTypeLib.Parameter)product.Parameters.GetItem("AxesDistance");
            type.ValuateFromString(gb.AxesDistance + "mm");

            product.Update();
            productDoc.Save();
            tsStatusLabel.Text = "Generation Complete";
        }

        private void updateTreeView(GearBox gb)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(Util.fillTreeView(gb));
            propertyGrid1.SelectedObject = gb;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            propertyGrid1.SelectedObject = treeView1.SelectedNode.Tag;
        }

        private void numInputTorque_ValueChanged(object sender, EventArgs e)
        {
            numTorqueRatio.Value = numOutputTorque.Value / numInputTorque.Value;
        }

        private void numOutputTorque_ValueChanged(object sender, EventArgs e)
        {
            numTorqueRatio.Value = numOutputTorque.Value / numInputTorque.Value;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {

            Database1DataSet1TableAdapters.Shaft1TableAdapter sta = new Database1DataSet1TableAdapters.Shaft1TableAdapter();
            sta.Insert(inputGear.Shaft.Name, inputGear.Shaft.Diameter, inputGear.Shaft.Material.ID, inputGear.Shaft.KeyCutWidth, inputGear.Shaft.KeyCutHeigth, inputGear.Shaft.KeyCutLength);
            sta.Insert(outputGear.Shaft.Name, outputGear.Shaft.Diameter, outputGear.Shaft.Material.ID, outputGear.Shaft.KeyCutWidth, outputGear.Shaft.KeyCutHeigth, outputGear.Shaft.KeyCutLength);

            inputGear.Shaft.ID = (int)sta.getID(inputGear.Shaft.Name, inputGear.Shaft.Diameter, inputGear.Shaft.Material.ID, inputGear.Shaft.KeyCutWidth, inputGear.Shaft.KeyCutHeigth, inputGear.Shaft.KeyCutLength);
            outputGear.Shaft.ID = (int)sta.getID(outputGear.Shaft.Name, outputGear.Shaft.Diameter, outputGear.Shaft.Material.ID, outputGear.Shaft.KeyCutWidth, outputGear.Shaft.KeyCutHeigth, outputGear.Shaft.KeyCutLength);

            Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
            gta.Insert(inputGear.Name, inputGear.Alpha,inputGear.GearModule, inputGear.Material.ID, inputGear.Torque, inputGear.Shaft.ID, inputGear.WantedRadius, inputGear.Z, inputGear.Phi, inputGear.R_base, inputGear.R_foot, inputGear.R_pitch, inputGear.R_top);
            gta.Insert(outputGear.Name, outputGear.Alpha, outputGear.GearModule, outputGear.Material.ID, outputGear.Torque, outputGear.Shaft.ID, outputGear.WantedRadius, outputGear.Z, outputGear.Phi, outputGear.R_base, outputGear.R_foot, outputGear.R_pitch, outputGear.R_top);

            inputGear.ID = (int)gta.getID(inputGear.Name, inputGear.Alpha, inputGear.GearModule, inputGear.Material.ID, inputGear.Torque, inputGear.Shaft.ID, inputGear.WantedRadius, inputGear.Z, inputGear.Phi, inputGear.R_base, inputGear.R_foot, inputGear.R_pitch, inputGear.R_top);
            outputGear.ID = (int)gta.getID(outputGear.Name, outputGear.Alpha, outputGear.GearModule, outputGear.Material.ID, outputGear.Torque, outputGear.Shaft.ID, outputGear.WantedRadius, outputGear.Z, outputGear.Phi, outputGear.R_base, outputGear.R_foot, outputGear.R_pitch, outputGear.R_top);

            Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();
            gbta.Insert(gearBox.Name, gearBox.Alpha, gearBox.AxesDistance, gearBox.GearModule, gearBox.InputTorque, gearBox.OutputTorque, gearBox.TorqueRatio, gearBox.InputGear.ID, gearBox.OutputGear.ID);

            gearBox.ID = (int)gbta.getID(gearBox.Name, gearBox.Alpha, gearBox.AxesDistance, gearBox.GearModule, gearBox.InputTorque, gearBox.OutputTorque, gearBox.TorqueRatio, gearBox.InputGear.ID, gearBox.OutputGear.ID);

            Program.gearBoxList.Add(gearBox);
            Program.gearList.Add(inputGear);
            Program.gearList.Add(outputGear);
            Program.shaftList.Add(inputGear.Shaft);
            Program.shaftList.Add(outputGear.Shaft);

            tsStatusLabel.Text = "Gear Box saved !";
        }

        private void gearBoxEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearBoxEditorForm gbForm = new GearBoxEditorForm();
            gbForm.hideSelect(); 
            gbForm.Show(); 
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e) 
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gearEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GearEditorForm gForm = new GearEditorForm();
            gForm.hideSelect();
            gForm.Show(); 
        }

        private void shaftEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShaftEditorForm sForm = new ShaftEditorForm();
            sForm.hideSelect();
            sForm.Show(); 
        }

        private void materialEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialEditorForm mForm = new MaterialEditorForm();
            mForm.hideSelect(); 
            mForm.Show(); 
        }

        private void GearBoxGenerator_Load(object sender, EventArgs e)
        {

            // Get the Materials
            Database1DataSet1TableAdapters.MaterialsTableAdapter mta = new Database1DataSet1TableAdapters.MaterialsTableAdapter(); 
            Database1DataSet1.MaterialsDataTable MaterialsFromDB = new Database1DataSet1.MaterialsDataTable();
            mta.Fill(MaterialsFromDB);

            foreach(Database1DataSet1.MaterialsRow row in MaterialsFromDB.Rows){
                Material mat = new Material();
                mat.ID = row.ID;
                mat.Name = row.MaterialName;
                mat.Density = row.Density;
                mat.yieldStress = row.YieldStress;
                mat.youngsModulus = row.YoungsModulus;

                Program.materialList.Add(mat);

            }

            // Get the Shafts
            Database1DataSet1TableAdapters.Shaft1TableAdapter sta = new Database1DataSet1TableAdapters.Shaft1TableAdapter();
            Database1DataSet1.Shaft1DataTable ShaftsFromDB = new Database1DataSet1.Shaft1DataTable();
            sta.Fill(ShaftsFromDB);

            foreach (Database1DataSet1.Shaft1Row row in ShaftsFromDB.Rows) {
                Shaft shaft = new Shaft();
                shaft.ID = row.ID;
                shaft.Name = row.ShaftName;
                shaft.Diameter = row.Diameter;
                shaft.KeyCutHeigth = row.KeyCutHeight;
                shaft.KeyCutLength = row.KeyCutLenght;
                shaft.KeyCutWidth = row.KeyCutWidth;
                shaft.Material = Util.getMaterialById(row.MaterialID);

                Program.shaftList.Add(shaft);
            }

            Database1DataSet1TableAdapters.GearsTableAdapter gta = new Database1DataSet1TableAdapters.GearsTableAdapter();
            Database1DataSet1.GearsDataTable GearsFromDB = new Database1DataSet1.GearsDataTable();
            gta.Fill(GearsFromDB);

            foreach (Database1DataSet1.GearsRow row in GearsFromDB.Rows)
            {
                Gear gear = new Gear();
                gear.ID = row.ID;
                gear.Alpha = row.Alpha;
                gear.GearModule = row.GearModule;
                gear.Torque = row.Torque;
                gear.WantedRadius = row.WantedRadius;
                gear.Name = row.GearName;
                gear.Z = row.Z;
                gear.Phi = row.Phi;
                gear.R_base = row.RBase;
                gear.R_foot = row.RFoot;
                gear.R_pitch = row.RPitch;
                gear.R_top = row.RTop;
                gear.Material = Util.getMaterialById(row.MaterialID);
                gear.Shaft = Util.getShaftById(row.ShaftID);

                Program.gearList.Add(gear);
            }

            Util.refreshGearBoxList();
        }

    }
}
