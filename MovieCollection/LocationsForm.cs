using MovieCollection.Domain;
using System.Windows.Forms;
using System;
using MovieCollection.Models;

namespace MovieCollection
{
    public partial class LocationsForm : Form
    {
        private readonly LocationGetter _locationGetter;
        private readonly MovieGetter _movieGetter;
        private readonly LocationAdder _locationAdder;

        public LocationsForm(LocationGetter locationGetter, MovieGetter movieGetter)
        {
            Cursor = Cursors.WaitCursor;
            InitializeComponent();
            _locationAdder = new LocationAdder();
            _locationGetter = locationGetter;
            _movieGetter = movieGetter;
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

        private void locationsGrid_DoubleClick(object sender, EventArgs e)
        {
            EditLocation();
        }

        private void locationsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EditLocation();
                    break;
                case Keys.Delete:
                    DeleteLocation();
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteLocation();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            DeleteLocation();
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

        private void DeleteLocation()
        {
            var currentLocation = (Location)locationBindingSource.Current;
            if (currentLocation == null)
                return;

            Cursor = Cursors.WaitCursor;
            try
            {
                currentLocation.ValidateForDelete(_movieGetter);

                var confirm = MessageBox.Show($"Are you sure you want to delete {currentLocation.Description}?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var deleter = new LocationDeleter();
                    deleter.DeleteById(currentLocation.Id);
                    RefreshData();
                }
            } catch (Location.LocationValidationException lve)
            {
                MessageBox.Show(lve.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
