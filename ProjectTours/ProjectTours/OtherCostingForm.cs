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
    public partial class OtherCostingForm : CostingForm
    {
        public OtherCostingForm()
        {
            InitializeComponent();
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            OtherCosting costingCopy = (OtherCosting)_costing;
            
            cost.Text = Convert.ToString(costingCopy.Cost);

            

        }

        protected override void PushData()
        {
            if (string.IsNullOrEmpty(cost.Text))
            {
                return;
            }
            else
            {
                base.PushData();
                OtherCosting costingCopy = (OtherCosting)_costing;

                costingCopy.Cost = Convert.ToDecimal(cost.Text);
            }
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
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
