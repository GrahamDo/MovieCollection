using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Domain
{
    public class ActorGetter
    {
        public IEnumerable<Actor> GetListForFilter()
        {
            var dummyActor = new Actor { Id = Guid.Empty, Name = "<Please Select>" };
            var results = new List<Actor>();
            results.Add(dummyActor);
            using (MovieCollectionEntities context = new MovieCollectionEntities())
            {
                results.AddRange(context.Actors.OrderBy(a => a.Name));
            }
            return results;
        }
    }
}
