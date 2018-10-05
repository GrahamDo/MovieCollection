using MovieCollection.Models;
using System;
using System.Linq;

namespace MovieCollection.Domain
{
    public class MovieGetter
    {
        public Movie GetById(Guid id)
        {
            using (var context = new MovieCollectionEntities())
                return context.Movies.Where(m => m.Id == id).FirstOrDefault();
        }

        public bool IsMovieExistingByLocationId(Guid locationId)
        {
            using (var context = new MovieCollectionEntities())
                return context.Movies.Any(m => m.LocationId == locationId);
        }
    }
}
