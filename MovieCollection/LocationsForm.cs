using MovieCollection.Domain;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class LocationsForm : Form
    {
        public LocationsForm(LocationGetter locationGetter)
        {
            Cursor = Cursors.WaitCursor;
            InitializeComponent();
            var locations = locationGetter.GetList();
            locationBindingSource.DataSource = locations;
            Cursor = Cursors.Default;
        }
    }
}
