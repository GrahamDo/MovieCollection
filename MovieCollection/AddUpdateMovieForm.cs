using MovieCollection.Domain;
using MovieCollection.Models;
using System.Windows.Forms;
using System;

namespace MovieCollection
{
    public partial class AddUpdateMovieForm : Form
    {
        private bool _isInitialising;
        private Movie _movie;
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly LocationGetter _locationGetter;
        private readonly MovieAdder _movieAdder;

        public bool IsRefreshRequired { get; private set; }

        public AddUpdateMovieForm(Movie movie, ActorDirectorGetter actorDirectorGetter, 
            LocationGetter locationGetter, MovieAdder movieAdder)
        {
            InitializeComponent();

            _isInitialising = true;
            _movie = movie;
            _actorDirectorGetter = actorDirectorGetter;
            _locationGetter = locationGetter;
            _movieAdder = movieAdder;

            movieBindingSource.DataSource = _movie;
            actorBindingSource.DataSource = 
                _actorDirectorGetter.GetListForAddUpdateMovie();
            directorBindingSource.DataSource = 
                _actorDirectorGetter.GetListForAddUpdateMovie(isForDirectors: true);
            locationBindingSource.DataSource =
                _locationGetter.GetList();

            if (_movie.IsNew)
                Text = "Add Movie";
            else
            {
                Text = _movie.Title;
                submitButton.Text = "OK";
                closeButton.Text = "Cancel";

                SelectCorrectActor();
                SelectCorrectDirector();
                SelectCorrectLocation();
            }
            _isInitialising = false;
        }

        private void yearText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void actorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentActor = (ActorDirector)actorBindingSource.Current;
            if (!_isInitialising || _movie.IsNew)
                _movie.ActorId = currentActor.Id;
        }

        private void directorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentDirector = (ActorDirector)directorBindingSource.Current;
            if (!_isInitialising || _movie.IsNew)
                _movie.DirectorId = currentDirector.Id;
        }

        private void locationBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            var currentLocation = (Location)locationBindingSource.Current;
            if (!_isInitialising || _movie.IsNew)
                _movie.LocationId = currentLocation.Id;
            locationUrlText.Enabled = currentLocation.IsUrlRequired;
            locationUrlBrowseButton.Enabled = currentLocation.IsUrlRequired;
            if (!locationUrlText.Enabled)
                locationUrlText.Text = string.Empty;
        }

        private void locationUrlBrowseButton_Click(object sender, System.EventArgs e)
        {
            var dialogResult = locationUrlBrowseDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _movie.LocationUrl = locationUrlBrowseDialog.FileName;
                _movie.ConvertUrlToUri();
                locationUrlText.Text = _movie.LocationUrl;
            }            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                var currentLocation = (Location)locationBindingSource.Current;
                _movie.ValidateAndConvertUrl(currentLocation);
                if (_movie.IsNew)
                    _movieAdder.Add(_movie);
                else
                {
                    var updater = new MovieUpdater();
                    updater.Update(_movie);
                }
                
                IsRefreshRequired = true;
                if (!_movie.IsNew)
                {
                    Close();
                    return;
                }

                resultLabel.Text = $"{_movie.Title} added successfully.";
                resultLabel.Visible = true;
                _movie = _movieAdder.CreateObjectForAdd();
                _movie.LocationId = ((Location)locationBindingSource.Current).Id;
                movieBindingSource.DataSource = _movie;
            }
            catch (Movie.MovieValidationException mve)
            {
                MessageBox.Show(mve.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void SelectCorrectActor()
        {
            for (var i = 0; i < actorSelect.Items.Count; i++)
            {
                var actor = (ActorDirector)actorSelect.Items[i];
                if (actor.Id == _movie.ActorId)
                {
                    actorSelect.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SelectCorrectDirector()
        {
            for (var i = 0; i < directorSelect.Items.Count; i++)
            {
                var director = (ActorDirector)directorSelect.Items[i];
                if (director.Id == _movie.DirectorId)
                {
                    directorSelect.SelectedIndex = i;
                    break;
                }
            }
        }

        private void SelectCorrectLocation()
        {
            for (var i = 0; i < locationSelect.Items.Count; i++)
            {
                var location = (Location)locationSelect.Items[i];
                if (location.Id == _movie.LocationId)
                {
                    locationSelect.SelectedIndex = i;
                    break;
                }
            }            
        }
    }
}
