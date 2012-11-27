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
    }
}
