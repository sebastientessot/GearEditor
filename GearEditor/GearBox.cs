using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearEditor
{
    [Serializable]
    public class GearBox
    {
        private String _name;
        private int _id;
        private Double _alpha;
        private Double _axesDistance;
        private Double _gearModule;
        private Double _inputTorque;
        private Double _outputTorque;
        private Double _torqueRatio;
        private Gear _inputGear;
        private Gear _outputGear;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID {
            get { return _id; } 
            set { _id = value; } 
        }

        public Double Alpha
        {
            get { return _alpha; }
            set { _alpha = value; }
        }

        public Double AxesDistance
        {
            get { return _axesDistance; }
            set { _axesDistance = value; }
        }

        public Double GearModule
        {
            get { return _gearModule; }
            set { _gearModule = value; }
        }

        public Double InputTorque
        {
            get { return _inputTorque; }
            set { _inputTorque = value; }
        }

        public Double OutputTorque
        {
            get { return _outputTorque; }
            set { _outputTorque = value; }
        }
        public Double TorqueRatio
        {
            get { return _torqueRatio; }
            set { _torqueRatio = value; }
        }
        public Gear InputGear
        {
            get { return _inputGear; }
            set { _inputGear = value; }
        }

        public Gear OutputGear
        {
            get { return _outputGear; }
            set { _outputGear = value; }
        }
    }
}
