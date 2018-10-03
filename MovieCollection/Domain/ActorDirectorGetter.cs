using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Domain
{
    public class ActorDirectorGetter
    {
        public IEnumerable<ActorDirector> GetListForFilter(bool isForDirectors = false)
        {
            var dummyActor = new ActorDirector { Id = Guid.Empty, Name = "<Please Select>" };
            var results = new List<ActorDirector>();
            results.Add(dummyActor);
            using (MovieCollectionEntities context = new MovieCollectionEntities())
            {
                results.AddRange(context.ActorDirectors
                    .Where(a => isForDirectors ? a.IsDirector : a.IsActor)
                    .OrderBy(a => a.Name));
            }
            return results;
        }
    }
}
