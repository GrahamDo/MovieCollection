using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Domain
{
    public class LocationGetter
    {
        public IEnumerable<Location> GetListForFilter()
        {
            var dummyLocation = new Location { Id = Guid.Empty, Description = "<Please Select>" };
            var results = new List<Location> { dummyLocation };
            using (MovieCollectionEntities context = new MovieCollectionEntities())
                results.AddRange(context.Locations.OrderBy(l => l.Description));
            return results;
        }
    }
}
