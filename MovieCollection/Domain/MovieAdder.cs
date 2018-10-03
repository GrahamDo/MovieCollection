using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
