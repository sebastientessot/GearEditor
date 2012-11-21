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
         /*   if (txtName == null)
               MessageBox.Show("You have to add a Name to your InputGear", "Impossible to generate a GearBox ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else*/ if (mInputTemp == null)
                MessageBox.Show("You have to add a Material to your InputGear", "Impossible to generate a GearBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double axesDistance = Convert.ToDouble(numAxesDistance.Value);
                double torqueRatio = Convert.ToDouble(numTorqueRatio.Value);
                GearBox gearBox = new GearBox();
                Gear inputGear = new Gear();
                Gear outputGear = new Gear();
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
                updateGearOnCatia(outputGear, false);
          //      showGearboxOnCatia();

                this.btnValidate.Visible = true;
            }
        }

        private void gearCalculation(Gear gear, bool isInput) {
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
            Shaft shaft = new Shaft();
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
            ws.SetValue("M", torque);

            String value;
            value = ws.GetValue("diameter").asString;
            shaft.Diameter = Convert.ToDouble(value);

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
            excelApp.Visible=true;

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
                    catiaApp.Documents.Open(path + "\\input_gear.CATPart");
                }
                else
                    catiaApp.Documents.Open(path + "\\output_gear.CATPart");
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
            type.ValuateFromString((g.Phi*Math.PI/180) + "rad");

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

        public void showGearboxOnCatia() {
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
                catiaApp.Documents.Open(path + "\\input_gear.CATPart");
            }
            MECMOD.PartDocument partDocument = (MECMOD.PartDocument)catiaApp.ActiveDocument;
            ProductStructureTypeLib.Product product = partDocument.Product;

        }
    }
}
