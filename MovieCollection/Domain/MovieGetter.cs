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
                return context.Movies.FirstOrDefault(m => m.Id == id);
        }

        public bool IsExistingByLocationId(Guid locationId)
        {
            using (var context = new MovieCollectionEntities())
                return context.Movies.Any(m => m.LocationId == locationId);
        }

        public bool IsExistingByDirectorId(Guid directorId)
        {
            using (var context = new MovieCollectionEntities())
                return context.Movies.Any(m => m.DirectorId == directorId);
        }

        public bool IsExistingByActorId(Guid actorId)
        {
            using (var context = new MovieCollectionEntities())
                return context.Movies.Any(m => m.ActorId == actorId);
        }
    }
}
