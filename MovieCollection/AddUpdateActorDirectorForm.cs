using MovieCollection.Domain;
using MovieCollection.Models;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class AddUpdateActorDirectorForm : Form
    {
        private ActorDirector _actorDirector;
        private ActorDirectorGetter _actorDirectorGetter;
        private ActorDirectorAdder _actorDirectorAdder;
        private LocationUpdater _actorDirectorUpdater;

        public AddUpdateActorDirectorForm(ActorDirector actorDirector, ActorDirectorGetter actorDirectorGetter, ActorDirectorAdder actorDirectorAdder)
        {
            InitializeComponent();
            _actorDirector = actorDirector;
            _actorDirectorGetter = actorDirectorGetter;
            _actorDirectorAdder = actorDirectorAdder;
            _actorDirectorUpdater = new LocationUpdater();
            actorDirectorBindingSource.DataSource = _actorDirector;

            if (_actorDirector.IsNew)
                base.Text = "Add Location";
            else
                base.Text = _actorDirector.Name;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                _actorDirector.Validate(_actorDirectorGetter);
                if (_actorDirector.IsNew)
                    _actorDirectorAdder.Add(_actorDirector);
                //TODO else
                //    _actorDirectorUpdater.Update(actorDirector);
                DialogResult = DialogResult.OK;
            }
            catch (ActorDirector.ActorDirectorValidationException lve)
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
