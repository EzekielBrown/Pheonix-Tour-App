namespace ProjectTours
{
    [Serializable]
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();

            statusComboBox.DataSource = Tour.Status;
            statusComboBox.SelectedIndex = 0;

            try
            {
                ListTours.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }

            UpdateDisplay();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Tour tour = Tour.NewTour();
            if (tour != null && tour.ViewEdit())
            {
                ListTours.TourList.Add(tour.Id, tour);
                UpdateDisplay();
            }

        }

        private void EditTour()
        {
            Tour tour = (Tour)tourListBox.SelectedItem;
            if (tour != null && tour.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditTour();
        }

        private void UpdateDisplay()
        {
            tourListBox.DataSource = null;
            switch (statusComboBox.SelectedIndex)
            {
                case 0:
                    tourListBox.DataSource = ListTours.TourList.Values.Where(t => t.EndDate > DateTime.Today).ToList();
                    break;
                case 1:
                    tourListBox.DataSource = ListTours.TourList.Values.Where(t => t.EndDate <= DateTime.Today).ToList();
                    break;
                default:
                    tourListBox.DataSource = ListTours.TourList.Values.ToList();
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tourListBox.Items.Count == 0)
            {
                MessageBox.Show("There are no tours to delete", "Delete Tour", MessageBoxButtons.OK);
                return;
            }
            if (tourListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a tour to delete", "Delete Tour", MessageBoxButtons.OK);
                return;
            }
            Tour tour = tourListBox.SelectedItem as Tour;
            if (MessageBox.Show($"Are you sure you want to delete the tour {tour.Name}", "Delete Tour", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListTours.TourList.Remove(tour.Id);
                UpdateDisplay();
            }
        }

        private void tourListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditTour();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ListTours.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}