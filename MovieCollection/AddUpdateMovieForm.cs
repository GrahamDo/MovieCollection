using MovieCollection.Domain;
using MovieCollection.Models;
using System.Windows.Forms;

namespace MovieCollection
{
    public partial class AddUpdateMovieForm : Form
    {
        private readonly ActorDirectorGetter _actorDirectorGetter;
        private readonly LocationGetter _locationGetter;

        public AddUpdateMovieForm(Movie movie, ActorDirectorGetter actorDirectorGetter, LocationGetter locationGetter)
        {
            InitializeComponent();

            _actorDirectorGetter = actorDirectorGetter;
            _locationGetter = locationGetter;
        }
    }
}
