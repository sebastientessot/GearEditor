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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GearBoxEditorForm());
            Application.Run(new GearBoxGenerator());
        }
    }
}
