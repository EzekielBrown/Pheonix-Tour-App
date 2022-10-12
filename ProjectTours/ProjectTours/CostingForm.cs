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
    public partial class CostingForm : Form
    {
        protected Costing _costing;
        public CostingForm()
        {
            InitializeComponent();
        }

        public bool ShowDialog(Costing costing)
        {
            _costing = costing;
            UpdateDisplay();

            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void UpdateDisplay()
        {
            id.Text = _costing.Id;
            name.Text = _costing.Name;
            notes.Text = _costing.Notes;
            id.Enabled = string.IsNullOrEmpty(_costing.Id);

            
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

                PushData();
                DialogResult = DialogResult.OK;
           
        }

        protected virtual void PushData()
        {
            _costing.Id = id.Text;
            _costing.Name = name.Text;


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
