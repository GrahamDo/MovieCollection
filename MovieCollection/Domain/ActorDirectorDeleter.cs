using MovieCollection.Models;
using System;
using System.Linq;

namespace MovieCollection.Domain
{
    public class ActorDirectorDeleter
    {
        public void DeleteById(Guid id)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existing = context.ActorDirectors.FirstOrDefault(l => l.Id == id);
                context.ActorDirectors.Remove(existing);
                context.SaveChanges();
            }
        }
    }
}
