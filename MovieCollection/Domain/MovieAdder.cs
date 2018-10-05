using MovieCollection.Models;
using System;

namespace MovieCollection.Domain
{
    public class MovieAdder
    {
        public Movie CreateObjectForAdd() =>
            new Movie
            {
                Id = Guid.NewGuid(),
                IsNew = true
            };

        public void Add(Movie movie)
        {
            using (var context = new MovieCollectionEntities())
            {
                context.Movies.Add(movie);
                context.SaveChanges();
            }
        }
    }
}
