using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTours
{
    [Serializable]
    class VehicleCosting : Costing
    {

        private string _make;
        private string _model;
        private string _rego;
        private DateTime _wofExpiry = DateTime.Today;
        private string _vehicleType;

        private VehicleCostingForm _form = new VehicleCostingForm();

 
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Rego { get => _rego; set => _rego = value; }
        public DateTime WofExpiry { get => _wofExpiry; set => _wofExpiry = value; }
        public string VehicleType { get => _vehicleType; set => _vehicleType = value; }

        public override CostingType TypeOfCosting()
        {
            return CostingType.Vehicle;
        }

        public override bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }


    }
}
