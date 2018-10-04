using MovieCollection.Domain;
using System.Windows.Forms;
using System;
using MovieCollection.Models;

namespace MovieCollection
{
    public partial class LocationsForm : Form
    {
        private readonly LocationGetter _locationGetter;
        private readonly LocationAdder _locationAdder;

        public LocationsForm(LocationGetter locationGetter)
        {
            Cursor = Cursors.WaitCursor;
            InitializeComponent();
            _locationAdder = new LocationAdder();
            _locationGetter = locationGetter;
            RefreshData();
            Cursor = Cursors.Default;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddLocation();
        }

        private void addMenu_Click(object sender, System.EventArgs e)
        {
            AddLocation();
        }

        private void RefreshData()
        {
            var locations = _locationGetter.GetList();
            locationBindingSource.DataSource = locations;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditLocation();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            EditLocation();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditLocation();
        }

        private void AddLocation()
        {
            var newLocation = _locationAdder.CreateObjectForAdd();
            AddEditLocation(newLocation);
        }

        private void EditLocation()
        {
            var location = (Location)locationBindingSource.Current;
            if (location == null)
                return;

            AddEditLocation(location);
        }

        private void AddEditLocation(Location location)
        {
            using (var frm = new AddUpdateLocationForm(location, _locationGetter, _locationAdder))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    RefreshData();
            }
        }
    }
}
