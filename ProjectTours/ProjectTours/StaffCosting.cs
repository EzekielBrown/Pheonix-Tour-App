using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTours
{
    [Serializable]
    class StaffCosting : Costing
    {

        private DateTime _dateOfBirth = DateTime.Today;
        private string _role;
        private string _gender;
        private DateTime dateStarted = DateTime.Today;
        private string _phNumber;
        private string _email;
        private StaffCostingForm _form = new StaffCostingForm();

 
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Role { get => _role; set => _role = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public DateTime DateStarted { get => dateStarted; set => dateStarted = value; }
        public string PhNumber { get => _phNumber; set => _phNumber = value; }
        public string Email { get => _email; set => _email = value; }

        public override CostingType TypeOfCosting()
        {
            return CostingType.Staff;
        }

        public override bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }


    }
}
