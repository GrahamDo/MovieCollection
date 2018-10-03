using MovieCollection.Domain;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class MainForm : Form
    {
        private readonly ActorGetter _actorGetter;
        private readonly LocationGetter _locationGetter;

        public MainForm()
        {
            InitializeComponent();
            _actorGetter = new ActorGetter();
            _locationGetter = new LocationGetter();

            actorBindingSource.DataSource = _actorGetter.GetListForFilter();
            locationBindingSource.DataSource = _locationGetter.GetListForFilter();
        }

        private void yearFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
