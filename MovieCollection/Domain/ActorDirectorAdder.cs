using MovieCollection.Models;
using System;

namespace MovieCollection.Domain
{
    public class ActorDirectorAdder
    {
        public ActorDirector CreateObjectForAdd() =>
            new ActorDirector
            {
                Id = Guid.NewGuid(),
                IsNew = true
            };

        public void Add(ActorDirector actorDirector)
        {
            using (var context = new MovieCollectionEntities())
            {
                context.ActorDirectors.Add(actorDirector);
                context.SaveChanges();
            }
        }
    }
}
