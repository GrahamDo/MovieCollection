using MovieCollection.Models;
using System.Linq;

namespace MovieCollection.Domain
{
    public class ActorDirectorUpdater
    {
        public void Update(ActorDirector actorDirector)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existingActorDirector = context.ActorDirectors.Where(ad => ad.Id == actorDirector.Id)
                    .FirstOrDefault();
                existingActorDirector.Name = actorDirector.Name;
                existingActorDirector.IsActor = actorDirector.IsActor;
                existingActorDirector.IsDirector = actorDirector.IsDirector;
                context.SaveChanges();
            }
        }
    }
}
