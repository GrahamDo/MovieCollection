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
            return GetListOfTypeForCombo("<Please Select>", isForDirectors);
        }

        public IEnumerable<ActorDirector> GetListForAddUpdateMovie(bool isForDirectors = false)
        {
            return GetListOfTypeForCombo("<None>", isForDirectors);
        }

        public IEnumerable<ActorDirector> GetList()
        {
            using (var context = new MovieCollectionEntities())
                return context.ActorDirectors.ToList();
        }

        public bool IsExistingByName(string name, Guid id)
        {
            using (var context = new MovieCollectionEntities())
                return context.ActorDirectors
                    .Any(ad => ad.Name.ToUpper() == name.ToUpper() && ad.Id != id);
        }

        private IEnumerable<ActorDirector> GetListOfTypeForCombo(string firstItemText, bool isForDirectors=false)
        {
            var dummyActor = new ActorDirector { Id = Guid.Empty, Name = firstItemText };
            var results = new List<ActorDirector> { dummyActor };
            using (MovieCollectionEntities context = new MovieCollectionEntities())
                results.AddRange(context.ActorDirectors
                    .Where(a => isForDirectors ? a.IsDirector : a.IsActor)
                    .OrderBy(a => a.Name));
            return results;
        }
    }
}
