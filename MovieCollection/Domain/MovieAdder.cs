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
        public Movie CreateMovieObjectForAdd() =>
            new Movie
            {
                Id = Guid.NewGuid(),
                IsNew = true
            };
    }
}
