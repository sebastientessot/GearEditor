using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearEditor
{
    public static class Util
    {
        public static TreeNode fillTreeView(Object o)
        {
            TreeNode n2 = new TreeNode();

            if (o is GearBox)
            {
                GearBox gb = (GearBox)o;
                n2.Name = "GearBox";
                n2.Text = gb.Name;
                n2.Tag = gb;

                n2.Nodes.Add(fillTreeView(gb.InputGear));
                n2.Nodes.Add(fillTreeView(gb.OutputGear));
            }

            else if (o is Gear)
            {
                Gear g = (Gear)o;
                n2.Name = "Gear";
                n2.Text = g.Name;
                n2.Tag = g;

                n2.Nodes.Add(fillTreeView(g.Shaft));
                n2.Nodes.Add(fillTreeView(g.Material));
            }
            else if (o is Shaft)
            {
                Shaft s = (Shaft)o;
                n2.Name = "Shaft";
                n2.Text = s.Name;
                n2.Tag = s;

                n2.Nodes.Add(fillTreeView(s.Material));
            }
            else if (o is Material)
            {
                Material m = (Material)o;
                n2.Name = "Material";
                n2.Text = m.Name;
                n2.Tag = m;
            }

            return n2;
        }

        public static Material getMaterialById(int id){
            foreach (Material item in Program.materialList)
            {
                if (item.ID == id)
                    return item; 
            }
            return null;
        }

        public static Shaft getShaftById(int id)
        {
            foreach (Shaft item in Program.shaftList)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }

        public static Gear getGearById(int id)
        {
            foreach (Gear item in Program.gearList)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }

        public static List<int> listOfGearIds(int materialID, List<int> shaftIds, Database1DataSet1TableAdapters.GearsTableAdapter gta)
        {
            List<int> gearIds = new List<int>();
            Database1DataSet1.GearsDataTable gearTable = new Database1DataSet1.GearsDataTable();

            // beacause of the Material
            gearTable = gta.GetDataByMaterialID(materialID);
            foreach (Database1DataSet1.GearsRow row in gearTable)
            {
                int id = row.ID;
                gearIds.Add(id);
            }

            // because of the shaft
            foreach (int shaft in shaftIds)
            {
                gearTable = gta.GetDataByShaftID(shaft);
                foreach (Database1DataSet1.GearsRow row in gearTable)
                {
                    int id = row.ID;
                    gearIds.Add(id);
                }
            }

            return gearIds;
        }

        public static List<int> listOfGearIds(int shaftIds, Database1DataSet1TableAdapters.GearsTableAdapter gta)
        {
            List<int> gearIds = new List<int>();

            Database1DataSet1.GearsDataTable gearTable = new Database1DataSet1.GearsDataTable();
            gearTable = gta.GetDataByShaftID(shaftIds);
            foreach (Database1DataSet1.GearsRow row in gearTable)
            {
                int id = row.ID;
                gearIds.Add(id);
            }

            return gearIds;
        }


        public static List<int> listOfShaftIds(int materialID, Database1DataSet1TableAdapters.Shaft1TableAdapter sta)
        {
            List<int> shaftIds = new List<int>();

            Database1DataSet1.Shaft1DataTable shaftTable = new Database1DataSet1.Shaft1DataTable();
            shaftTable = sta.GetDataByMaterialID(materialID);
            foreach (Database1DataSet1.Shaft1Row row in shaftTable)
            {
                int id = row.ID;
                shaftIds.Add(id);
            }

            return shaftIds;
        }

        public static void refreshGearBoxList()
        {
            Program.gearBoxList.Clear();

            Database1DataSet1TableAdapters.GearBoxTableAdapter gbta = new Database1DataSet1TableAdapters.GearBoxTableAdapter();
            Database1DataSet1.GearBoxDataTable GearBoxFromDB = new Database1DataSet1.GearBoxDataTable();
            gbta.Fill(GearBoxFromDB);

            foreach (Database1DataSet1.GearBoxRow row in GearBoxFromDB)
            {
                GearBox gb = new GearBox();
                gb.ID = row.ID;
                gb.Name = row.GearBoxName;
                gb.Alpha = row.Alpha;
                gb.AxesDistance = row.AxesDistance;
                gb.GearModule = row.GearModule;
                gb.InputTorque = row.InputTorque;
                gb.OutputTorque = row.OutputTorque;
                gb.TorqueRatio = row.TorqueRatio;
                gb.InputGear = Util.getGearById(row.InputGear);
                gb.OutputGear = Util.getGearById(row.OutputGear);

                Program.gearBoxList.Add(gb);
            }
        }
    }
}
