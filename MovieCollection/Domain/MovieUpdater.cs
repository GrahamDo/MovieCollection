using MovieCollection.Models;
using System.Linq;

namespace MovieCollection.Domain
{
    public class MovieUpdater
    {
        public void Update(Movie movie)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existingMovie = context.Movies.Where(m => m.Id == movie.Id)
                    .FirstOrDefault();
                existingMovie.Title = movie.Title;
                existingMovie.Year = movie.Year;
                existingMovie.ActorId = movie.ActorId;
                existingMovie.DirectorId = movie.DirectorId;
                existingMovie.LocationId = movie.LocationId;
                existingMovie.LocationUrl = movie.LocationUrl;
                context.SaveChanges();
            }
        }
    }
}
