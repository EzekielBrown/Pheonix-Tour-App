using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTours
{
    [Serializable]
    public class Tour
    {
        private string _id;
        private string _name;
        private string _description;

        private DateTime _dateCreated = DateTime.Today;
        private DateTime _startDate = DateTime.Today;
        private DateTime _endDate = DateTime.Today.AddDays(1);

        private decimal _distance;

        private TourForm _form = new TourForm();

        private Dictionary<string, Costing> _costingList = new Dictionary<string, Costing>();
        public Dictionary<string, Costing> CostingList { get => _costingList; set => _costingList = value; }
        public static CostingType[] CostingTypes { get => Enum.GetValues<CostingType>(); }
        public static Status[] Status { get => Enum.GetValues<Status>(); }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public decimal Distance { get => _distance; set => _distance = value; }
        public DateTime DateCreated { get => _dateCreated; }

        public static Tour NewTour()
        {
            return new Tour();
        }


        public bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{StartDate}\t{TotalCost()}";
        }

        public decimal TotalCost()
        {
            decimal total = 0;
            foreach (Costing costing in _costingList.Values)
            {
                switch (costing.TypeOfCosting())
                {
                    case CostingType.Vehicle:
                        total += costing.Cost * _distance;
                        break;
                    case CostingType.Staff:
                        TimeSpan numDays = _endDate - _startDate;
                        total += costing.Cost * numDays.Days;
                        break;
                    default:
                        total += costing.Cost;
                        break;
                }
            }
            return total;
        }
    }
}
