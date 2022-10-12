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
    public partial class TourForm : Form
    {
        protected Tour _tour;
        public TourForm()
        {
            InitializeComponent();

            costingType.DataSource = Tour.CostingTypes;
            costingType.SelectedIndex = 0;
       
        }

        public bool ShowDialog(Tour tour)
        {
            _tour = tour;
            UpdateDisplay();

            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay()
        {
            id.Text = _tour.Id;
            tourName.Text = _tour.Name;
            description.Text = _tour.Description;
            startDate.Value = _tour.StartDate;
            endDate.Value = _tour.EndDate;
            distance.Text = Convert.ToString(_tour.Distance);
            idLabel.Enabled = String.IsNullOrEmpty(_tour.Id);
            dateCreated.Text = _tour.DateCreated.Date.ToString("d");

            costingListBox.DataSource = null;
            costingListBox.DataSource = _tour.CostingList.Values.ToList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (id.Enabled && ListTours.TourList.ContainsKey(id.Text))
            {
                MessageBox.Show("Tour Id Already Exists", "Error");
            }
            if(startDate.Value >= endDate.Value)
            {
                MessageBox.Show("End Date cannot be before Start Date", "Error");
            }
            else
            {
                PushData();
                DialogResult = DialogResult.OK;
            }
        }

        protected virtual void PushData()
        {
                _tour.Id = id.Text;
                _tour.Name = tourName.Text;
                _tour.Description = description.Text;
                _tour.StartDate = startDate.Value;
                _tour.EndDate = endDate.Value;
                _tour.Distance = Convert.ToDecimal(distance.Text);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Costing costing = Costing.NewCosting((CostingType)costingType.SelectedItem);
            if (costing != null && costing.ViewEdit())
            {
                _tour.CostingList.Add(costing.Id, costing);
                UpdateDisplay();
            }
        }

        private void editButon_Click(object sender, EventArgs e)
        {
            EditCosting();
        }

        private void EditCosting()
        {
            Costing costing = (Costing)costingListBox.SelectedItem;
            if (costing != null && costing.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (costingListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no costing?", "Delete Costing", MessageBoxButtons.OK);
                return;
            }
            if (costingListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a costing to delete", "Delete costing", MessageBoxButtons.OK);
                return;
            }
            Costing costing = costingListBox.SelectedItem as Costing;
            if (MessageBox.Show($"Are you sure you want to delete the costing {costing.Name}", "Delete costing", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _tour.CostingList.Remove(costing.Id);
                UpdateDisplay();
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            _tour.StartDate = startDate.Value;
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            _tour.EndDate = endDate.Value;
        }

        private void distance_TextChanged(object sender, EventArgs e)
        {
            _tour.Distance = Convert.ToDecimal(distance.Text);
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            _tour.Description = description.Text;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            _tour.Id = id.Text;
        }

        private void tourName_TextChanged(object sender, EventArgs e)
        {
            _tour.Name = tourName.Text;
        }

        private void distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }


        }
    }


}
