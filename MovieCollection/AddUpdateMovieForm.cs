﻿using MovieCollection.Domain;
using MovieCollection.Models;
using System.Windows.Forms;
using System;

namespace MovieCollection
{
    public partial class AddUpdateMovieForm : Form
    {
        private Movie _movie;
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly LocationGetter _locationGetter;
        private readonly MovieAdder _movieAdder;

        public bool IsRefreshRequired { get; private set; }

        public AddUpdateMovieForm(Movie movie, ActorDirectorGetter actorDirectorGetter, 
            LocationGetter locationGetter, MovieAdder movieAdder)
        {
            InitializeComponent();

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
        }

        private void yearText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void actorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentActor = (ActorDirector)actorBindingSource.Current;
            _movie.ActorId = currentActor.Id;
        }

        private void directorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var currentDirector = (ActorDirector)actorBindingSource.Current;
            _movie.DirectorId = currentDirector.Id;
        }

        private void locationBindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            var currentLocation = (Location)locationBindingSource.Current;
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
                var fileUri = GetUriFromPath(locationUrlBrowseDialog.FileName);
                locationUrlText.Text = fileUri;
                _movie.LocationUrl = fileUri; 
                //Doesn't update automatically if you set the textbox programmatically
            }            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (string.IsNullOrWhiteSpace(_movie.Title))
                {
                    MessageBox.Show("Title cannot be blank.", Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (_movie.ActorId == Guid.Empty)
                    _movie.ActorId = null;
                if (_movie.DirectorId == Guid.Empty)
                    _movie.DirectorId = null;

                var currentLocation = (Location)locationBindingSource.Current;
                if (currentLocation.IsUrlRequired && string.IsNullOrWhiteSpace(_movie.LocationUrl))
                {
                    MessageBox.Show("The selected location requires you to specify a URL.", 
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _movieAdder.Add(_movie);
                IsRefreshRequired = true;
                resultLabel.Text = $"{_movie.Title} added successfully.";
                resultLabel.Visible = true;
                _movie = _movieAdder.CreateObjectForAdd();
                movieBindingSource.DataSource = _movie;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GetUriFromPath(string fileName)
        {
            var uri = new Uri(fileName);
            return uri.AbsoluteUri;
        }
    }
}