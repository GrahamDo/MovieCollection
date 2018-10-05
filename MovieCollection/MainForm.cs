using MovieCollection.Domain;
using System.Windows.Forms;
using System;
using MovieCollection.Models;
using System.Diagnostics;
using System.ComponentModel;

namespace MovieCollection
{
    public partial class MainForm : Form
    {
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly LocationGetter _locationGetter;
        private readonly MovieResultGetter _movieResultGetter;
        private readonly MovieGetter _movieGetter;
        private readonly MovieAdder _movieAdder;
        private bool _isInitialising;
        private bool _isFormClosing = false;

        public MainForm()
        {
            //TODO Add a splash screen while loading all this stuff (it could take a while
            //     with lots of actors, directors, or locations)
            //TODO Add an icon for the application and all resizable forms
            //TODO Implement sorting on all grids
            //TODO Move Domain and Models into their own assembly (MovieCollectionLib), so we
            //     can have multiple types of clients all using it
            //TODO Add linking table between Movie and Actor, so we can have multiple actors
            //     per movie, and update UI and all code to support this
            //TODO Make LocationsForm and ActorsDirectorsForm single instance
            Cursor = Cursors.WaitCursor;
            _isInitialising = true;
            InitializeComponent();
            _actorDirectorGetter = new ActorDirectorGetter();
            _locationGetter = new LocationGetter();
            _movieResultGetter = new MovieResultGetter();
            _movieGetter = new MovieGetter();
            _movieAdder = new MovieAdder();

            RefreshActors();
            RefreshDirectors();
            RefreshLocations();
            _isInitialising = false;
            DoFilter(); //This will set the cursor back to default
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isFormClosing = true;
            //DoFilter sometimes fires while the form is closing
        }

        private void yearFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void titleFilterText_TextChanged(object sender, System.EventArgs e)
        {
            DoFilter();
        }

        private void yearFilterText_TextChanged(object sender, System.EventArgs e)
        {
            DoFilter();
        }

        private void actorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void directorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void locationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void addMovieMenu_Click(object sender, EventArgs e)
        {
            AddMovie();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            AddMovie();
        }

        private void movieResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var selected = (MovieResult)movieResultBindingSource.Current;
            if (selected == null)
                return;

            browseToUrlMenu.Enabled = !string.IsNullOrWhiteSpace(selected.LocationUrl);
            browseToUrlButton.Enabled = !string.IsNullOrWhiteSpace(selected.LocationUrl);
        }

        private void browseToUrlMenu_Click(object sender, EventArgs e)
        {
            BrowseToUrl();
        }

        private void browseToUrlButton_Click(object sender, EventArgs e)
        {
            BrowseToUrl();
        }

        private void movieResultsGrid_DoubleClick(object sender, EventArgs e)
        {
            EditMovie();
        }

        private void editMovieButton_Click(object sender, EventArgs e)
        {
            EditMovie();
        }

        private void editMovieMenu_Click(object sender, EventArgs e)
        {
            EditMovie();
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void deleteMovieMenu_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void movieResultsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EditMovie();
                    break;
                case Keys.Delete:
                    DeleteMovie();
                    break;
            }
        }

        private void actorDirectorsButton_Click(object sender, EventArgs e)
        {
            var frm = new ActorsDirectorsForm(_actorDirectorGetter, _movieGetter);
            frm.DataChanged += actorsDirectors_DataChanged;
            frm.Show();
        }

        private void locationsButton_Click(object sender, EventArgs e)
        {
            var frm = new LocationsForm(_locationGetter, _movieGetter);
            frm.DataChanged += locationsForm_DataChanged;
            frm.Show();
        }

        private void actorsDirectors_DataChanged(object sender, EventArgs e)
        {
            RefreshActors();
            RefreshDirectors();
        }

        private void locationsForm_DataChanged(object sender, EventArgs e)
        {
            RefreshLocations();
        }

        private void DoFilter()
        {
            if (_isInitialising || _isFormClosing)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                movieResultBindingSource.DataSource = null;
                var title = titleFilterText.Text.Trim();
                var year = yearFilterText.Text == string.Empty ? 0 :
                    Convert.ToInt32(yearFilterText.Text);
                var actorId = ((ActorDirector)actorBindingSource.Current).Id;
                var directorId = ((ActorDirector)directorBindingSource.Current).Id;
                var locationId = ((Location)locationBindingSource.Current).Id;

                var data = _movieResultGetter.Search(title, year, actorId, directorId,
                    locationId);
                if (_movieResultGetter.IsMaxResultsCountExceeded(data,
                    Settings.Default.MaxResultsAllowed))
                {
                    resultsLabel.Text = "Too many records returned. Please narrow your filter.";
                    return;
                }

                movieResultBindingSource.DataSource = data;
                resultsLabel.Text = $"{data.Count} result{Pluralise(data.Count)} returned.";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string Pluralise(int count) => count == 1 ? "" : "s";

        private void AddMovie()
        {
            if (locationBindingSource.Count == 1) //The <Please Select> item
            {
                MessageBox.Show("Please add at least one location before attempting " + 
                    "to add a movie.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newMovie = _movieAdder.CreateObjectForAdd();
            AddOrEditMovie(newMovie);
        }

        private void AddOrEditMovie(Movie movie)
        {
            using (var frm = new AddUpdateMovieForm(movie, _actorDirectorGetter,
                _locationGetter, _movieAdder))
            {
                frm.ShowDialog();
                if (frm.IsRefreshRequired)
                    DoFilter();
            };
        }

        private void EditMovie()
        {
            var currentMovieResult = (MovieResult)movieResultBindingSource.Current;
            if (currentMovieResult == null)
                return;

            var movieToEdit = _movieGetter.GetById(currentMovieResult.Id);
            AddOrEditMovie(movieToEdit);
        }

        private void DeleteMovie()
        {
            var currentMovieResult = (MovieResult)movieResultBindingSource.Current;
            if (currentMovieResult == null)
                return;

            var confirm = MessageBox.Show($"Are you sure you want to delete {currentMovieResult.Title}?", 
                Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var deleter = new MovieDeleter();
                deleter.DeleteById(currentMovieResult.Id);
                DoFilter();
            }
        }

        private void BrowseToUrl()
        {
            var currentMovie = (MovieResult)movieResultBindingSource.Current;
            try
            {
                Process.Start(currentMovie.LocationUrl);
            }
            catch (Win32Exception e)
            {
                MessageBox.Show($"Unable to browse to URL {currentMovie.LocationUrl}. The error was: {e.Message}.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshActors()
        {
            var previousActor = (ActorDirector)actorBindingSource.Current;
            actorBindingSource.DataSource = _actorDirectorGetter.GetListForFilter();

            if (previousActor == null)
                return;

            var itemFound = false;
            for (var i = 0; i < actorFilterSelect.Items.Count; i++)
            {
                var actor = (ActorDirector)actorFilterSelect.Items[i];
                if (actor.Id == previousActor.Id)
                {
                    actorFilterSelect.SelectedIndex = i;
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
                actorFilterSelect.SelectedIndex = 0;
        }

        private void RefreshDirectors()
        {
            var previousDirector = (ActorDirector)directorBindingSource.Current;
            directorBindingSource.DataSource = _actorDirectorGetter.GetListForFilter(
                isForDirectors: true);

            if (previousDirector == null)
                return;

            var itemFound = false;
            for (var i = 0; i < directorFilterSelect.Items.Count; i++)
            {
                var director = (ActorDirector)directorFilterSelect.Items[i];
                if (director.Id == previousDirector.Id)
                {
                    directorFilterSelect.SelectedIndex = i;
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
                directorFilterSelect.SelectedIndex = 0;
        }

        private void RefreshLocations()
        {
            var previousLocation = (Location)locationBindingSource.Current;
            locationBindingSource.DataSource =
               _locationGetter.GetList(showPleaseSelect: true);

            if (previousLocation == null)
                return;

            var itemFound = false;
            for (var i = 0; i < LocationFilterSelect.Items.Count; i++)
            {
                var location = (Location)LocationFilterSelect.Items[i];
                if (location.Id == previousLocation.Id)
                {
                    LocationFilterSelect.SelectedIndex = i;
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
                LocationFilterSelect.SelectedIndex = 0;
        }
    }
}