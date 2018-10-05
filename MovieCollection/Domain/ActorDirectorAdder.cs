using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
