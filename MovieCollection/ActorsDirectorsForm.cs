using MovieCollection.Domain;
using System.Windows.Forms;
using System;
using MovieCollection.Models;

namespace MovieCollection
{
    public partial class ActorsDirectorsForm : Form
    {
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly MovieGetter _movieGetter;
        private readonly ActorDirectorAdder _actorDirectorAdder;

        public event EventHandler DataChanged;

        public ActorsDirectorsForm(ActorDirectorGetter actorDirectorGetter, MovieGetter movieGetter)
        {
            Cursor = Cursors.WaitCursor;
            InitializeComponent();
            _actorDirectorAdder = new ActorDirectorAdder();
            _actorDirectorGetter = actorDirectorGetter;
            _movieGetter = movieGetter;
            RefreshData();
            Cursor = Cursors.Default;
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddActorDirector();
        }

        private void addMenu_Click(object sender, System.EventArgs e)
        {
            AddActorDirector();
        }

        private void RefreshData()
        {
            var actorsDirectors = _actorDirectorGetter.GetList();
            actorDirectorBindingSource.DataSource = actorsDirectors;
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
                    DeleteActorDirector();
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteActorDirector();
        }

        private void deleteMenu_Click(object sender, EventArgs e)
        {
            DeleteActorDirector();
        }

        private void AddActorDirector()
        {
            var newActorDirector = _actorDirectorAdder.CreateObjectForAdd();
            AddEditActorDirector(newActorDirector);
        }

        private void EditLocation()
        {
            var actorDirector = (ActorDirector)actorDirectorBindingSource.Current;
            if (actorDirector == null)
                return;

            AddEditActorDirector(actorDirector);
        }

        private void AddEditActorDirector(ActorDirector actorDirector)
        {
            using (var frm = new AddUpdateActorDirectorForm(actorDirector, _actorDirectorGetter, _actorDirectorAdder, _movieGetter))
            {
                if (frm.ShowDialog() == DialogResult.OK || !actorDirector.IsNew)
                {
                    RefreshData();
                    RaiseDataChanged();
                }
            }
        }

        private void DeleteActorDirector()
        {
            var currentActorDirector = (ActorDirector)actorDirectorBindingSource.Current;
            if (currentActorDirector == null)
                return;

            Cursor = Cursors.WaitCursor;
            try
            {
                currentActorDirector.ValidateForDelete(_movieGetter);

                var confirm = MessageBox.Show($"Are you sure you want to delete {currentActorDirector.Name}?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var deleter = new ActorDirectorDeleter();
                    deleter.DeleteById(currentActorDirector.Id);
                    RefreshData();
                    RaiseDataChanged();
                }
            }
            catch (ActorDirector.ActorDirectorValidationException adve)
            {
                MessageBox.Show(adve.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void RaiseDataChanged()
        {
            if (DataChanged != null)
                DataChanged(this, new EventArgs());
        }
    }
}
