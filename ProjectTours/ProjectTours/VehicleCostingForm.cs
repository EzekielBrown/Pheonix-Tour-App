using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTours
{
    
    public partial class VehicleCostingForm : CostingForm
    {


        private string[] _vehicleType = { "Car", "Van", "Boat", "Bus" };
        public VehicleCostingForm()
        {
            InitializeComponent();

            vehicleType.DataSource = _vehicleType;
            vehicleType.SelectedIndex = 0;
        }

        protected virtual void UpdateDisplay()
        {

            base.UpdateDisplay();
            VehicleCosting costingCopy = (VehicleCosting)_costing;

            make.Text = costingCopy.Make;
            model.Text = costingCopy.Model;
            wofExpiry.Value = costingCopy.WofExpiry;
            pricePerKM.Text = Convert.ToString(costingCopy.Cost);

        }

        protected override void PushData()
        {
            if (string.IsNullOrEmpty(pricePerKM.Text))
            {
                return;
            }
            else
            {
                base.PushData();
                VehicleCosting costingCopy = (VehicleCosting)_costing;

                costingCopy.Make = make.Text;
                costingCopy.Model = model.Text;
                costingCopy.WofExpiry = wofExpiry.Value;
                costingCopy.Cost = Convert.ToDecimal(pricePerKM.Text);
            }

        }

        private void pricePerKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
