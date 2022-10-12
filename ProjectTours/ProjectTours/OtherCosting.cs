using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTours
{
    [Serializable]
    class OtherCosting : Costing
    {
        private OtherCostingForm _form = new OtherCostingForm();

        public override CostingType TypeOfCosting()
        {
            return CostingType.Other;
        }

        public override bool ViewEdit()
        {
            return Convert.ToBoolean(_form.ShowDialog(this));
        }

    }
}
