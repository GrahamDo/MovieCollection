using MovieCollection.Domain;
using System.Windows.Forms;
using System;
using MovieCollection.Models;

namespace MovieCollection
{
    public partial class MainForm : Form
    {
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly LocationGetter _locationGetter;
        private readonly MovieResultGetter _movieResultGetter;
        private bool _isInitialising = true;
        private bool _formIsClosing = false;

        public MainForm()
        {
            //TODO Add a splash screen while loading all this stuff (it could take a while
            //     with lots of actors, directors, or locations)
            InitializeComponent();
            _actorDirectorGetter = new ActorDirectorGetter();
            _locationGetter = new LocationGetter();
            _movieResultGetter = new MovieResultGetter();

            actorBindingSource.DataSource = _actorDirectorGetter.GetListForFilter();
            directorBindingSource.DataSource = _actorDirectorGetter.GetListForFilter(
                isForDirectors: true);
            locationBindingSource.DataSource = _locationGetter.GetListForFilter();
            _isInitialising = false;
            DoFilter();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _formIsClosing = true;
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

        private void DoFilter()
        {
            if (_isInitialising || _formIsClosing)
                return;

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

        private object Pluralise(int count) => count == 1 ? "" : "s";
    }
}