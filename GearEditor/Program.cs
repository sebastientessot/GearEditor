using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearEditor
{
    static class Program
    {
        public static List<GearBox> gearBoxList;
        public static List<Gear> gearList;
        public static List<Material> materialList;
        public static List<Shaft> shaftList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            gearBoxList = new List<GearBox>();
            gearList = new List<Gear>();
            materialList = new List<Material>();
            shaftList = new List<Shaft>();

            ///
            /// Test, à supprimer par la suite 
            /// 

            //Creation d'un materiel
            Material material = new Material();
            material.Name = "Material1";
            material.Density = 2;
            material.yieldStress = 0.1;
            material.youngsModulus = 1;

            materialList.Add(material);

            //Creation d'un Shaft
            Shaft shaft = new Shaft();
            shaft.Name = "Shaft1";
            shaft.Diameter = 1;
            shaft.KeyCutHeigth = 1;
            shaft.KeyCutLength = 1;
            shaft.KeyCutWidth = 1;
            shaft.Material = materialList.ElementAt(0);

            shaftList.Add(shaft);

            //Creation d'un Gear 
            Gear gear = new Gear();
            gear.Name = "Gear1";
            gear.Alpha = 1;
            gear.GearModule = 1;
            gear.Torque = 1;
            gear.WantedRadius = 1;
            gear.Material = materialList.ElementAt(0);
            gear.Shaft = shaftList.ElementAt(0);

            gearList.Add(gear);

            //Creation d'un GearBox
            GearBox gearBox = new GearBox();
            gearBox.Name = "GearBox1";
            gearBox.Alpha = 12;
            gearBox.AxesDistance = 4;
            gearBox.GearModule = 4;
            gearBox.InputTorque = 1;
            gearBox.OutputTorque = 1;
            gearBox.TorqueRatio = 0.1;
            gearBox.InputGear = gearList.ElementAt(0);
            gearBox.OutputGear = gearList.ElementAt(0);

            gearBoxList.Add(gearBox);

            ///
            /// Fin du test
            /// 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GearBoxEditorForm());
            Application.Run(new GearBoxGenerator());
        }
    }
}
