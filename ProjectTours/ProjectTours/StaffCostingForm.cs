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
    public partial class StaffCostingForm : CostingForm
    {
        private string[] _gender = { "Male", "Female", "Other" };
        private string[] _role = { "Manager", "Crew", "Trainee" };

        public StaffCostingForm()
        {
            InitializeComponent();

            gender.DataSource = _gender;
            gender.SelectedIndex = 0;

            role.DataSource = _role;
            role.SelectedIndex = 0;
        }


        protected virtual void UpdateDisplay()
        {

            base.UpdateDisplay();
            StaffCosting costingCopy = (StaffCosting)_costing;

            dateStarted.Value = costingCopy.DateStarted;
            dateOfBirth.Value = costingCopy.DateOfBirth;
            hourlyWage.Text = Convert.ToString(costingCopy.Cost);
            role.Text = costingCopy.Role;
            gender.Text = costingCopy.Gender;
            phNumber.Text = costingCopy.PhNumber;
            email.Text = costingCopy.Email;

        }

        protected override void PushData()
        {
            if (string.IsNullOrEmpty(hourlyWage.Text))
            {
                return;
            }
            else
            {

                base.PushData();
                StaffCosting costingCopy = (StaffCosting)_costing;

                costingCopy.DateOfBirth = dateOfBirth.Value;
                costingCopy.Cost = Convert.ToDecimal(hourlyWage.Text);
                costingCopy.Role = role.Text;
                costingCopy.Gender = gender.Text;
                costingCopy.DateStarted = dateStarted.Value;
                costingCopy.PhNumber = phNumber.Text;
                costingCopy.Email = email.Text;
            }
        }

        private void hourlyWage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void phNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }

        }
    }
}
