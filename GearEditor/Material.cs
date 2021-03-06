﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearEditor
{
    [Serializable]
    public class Material
    {
        String _name;
        Double _density;
        Double _yieldStress;
        Double _youngsModulus;
        int _id;

        public int ID {
            get { return _id; }
            set { _id = value; } 
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public Double yieldStress
        {
            get { return _yieldStress; }
            set { _yieldStress = value; }
        }

        public Double youngsModulus
        {
            get { return _youngsModulus; }
            set { _youngsModulus = value; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
