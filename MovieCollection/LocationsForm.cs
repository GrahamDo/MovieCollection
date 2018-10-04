using MovieCollection.Domain;
using System.Windows.Forms;
using System;

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

        private void AddLocation()
        {
            var newLocation = _locationAdder.CreateObjectForAdd();
            using (var frm = new AddUpdateLocationForm(newLocation, _locationGetter, _locationAdder))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    RefreshData();
            }
        }
    }
}
