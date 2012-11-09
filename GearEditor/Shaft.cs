using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearEditor
{
    public class Shaft
    {
        String _name;
        Double _diameter;
        Double _keyCutWidth;
        Double _keyCutHeigth;
        Double _keyCutLength;
        Material _material;

        public String Name {
            get { return _name; }
            set { _name = value; }
        }

        public Double Diameter { 
            get { return _diameter;}
            set { _diameter = value;}
        }

        public Double KeyCutWidth
        {
            get { return _keyCutWidth; }
            set { _keyCutWidth = value; }
        }

        public Double KeyCutHeigth
        {
            get { return _keyCutHeigth; }
            set { _keyCutHeigth = value; }
        }

        public Double KeyCutLength
        {
            get { return _keyCutLength; }
            set { _keyCutLength = value; }
        }

        public Material Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
