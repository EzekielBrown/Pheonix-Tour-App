using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTours
{
    [Serializable]
    public abstract class Costing
    {
        private string _id = UniqueID.RandomString(8);
        private string _name;
        private decimal _cost;
        private string _notes;


        public static CostingType[] Types { get => Enum.GetValues<CostingType>(); }
        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Cost { get => _cost; set => _cost = value; }
        public string Notes { get => _notes; set => _notes = value; }

        public static Costing NewCosting(CostingType costingType)
        {
            switch (costingType)
            {
                case CostingType.Vehicle:
                    return new VehicleCosting();
                case CostingType.Staff:
                    return new StaffCosting();
                default:
                    return new OtherCosting();
            }
        }

        public abstract CostingType TypeOfCosting();

        public abstract bool ViewEdit();

        public override string ToString()
        {
            return $"{Name}\t{TypeOfCosting()}\t{Cost}";
        }


        
    }
}
