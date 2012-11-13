using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GearEditor
{
    public class Gear
    {
        //User input
        Double _alpha;
        Double _gearModule;
        Material _material;
        Double _torque;
        Shaft _shaft;
        Double _wantedRadius;
        String _name;

        //Calculated values
        Double _z;
        Double _phi;
        Double _r_base;
        Double _r_foot;
        Double _r_pitch;
        Double _r_top;

        public Double Alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        public Double GearModule
        {
            get { return _gearModule; }
            set { _gearModule = value; }
        }

        public Material Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public Double Torque
        {
            get { return _torque; }
            set { _torque = value; }
        }

        public Shaft Shaft
        {
            get { return _shaft; }
            set { _shaft = value; }
        }

        public Double WantedRadius
        {
            get { return _wantedRadius; }
            set { _wantedRadius = value; }
        }


        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
