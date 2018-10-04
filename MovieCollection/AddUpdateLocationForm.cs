using MovieCollection.Domain;
using MovieCollection.Models;
using System.Windows.Forms;
using static MovieCollection.Models.Location;

namespace MovieCollection
{
    public partial class AddUpdateLocationForm : Form
    {
        private Location _location;
        private LocationGetter _locationGetter;
        private LocationAdder _locationAdder;

        public AddUpdateLocationForm(Location location, LocationGetter locationGetter, LocationAdder locationAdder)
        {
            InitializeComponent();
            _location = location;
            _locationGetter = locationGetter;
            _locationAdder = locationAdder;
            locationBindingSource.DataSource = _location;

            if (_location.IsNew)
                Text = "Add Location";
            else
                Text = _location.Description;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                _location.Validate(_locationGetter);
                _locationAdder.Add(_location);
                DialogResult = DialogResult.OK;
            }
            catch (LocationValidationException lve)
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
