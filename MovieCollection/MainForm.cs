using MovieCollection.Domain;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class MainForm : Form
    {
        private readonly ActorDirectorGetter _actorGetter;
        private readonly LocationGetter _locationGetter;

        public MainForm()
        {
            InitializeComponent();
            _actorGetter = new ActorDirectorGetter();
            _locationGetter = new LocationGetter();

            actorBindingSource.DataSource = _actorGetter.GetActorListForFilter();
            locationBindingSource.DataSource = _locationGetter.GetListForFilter();
        }

        private void yearFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
