using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Domain
{
    public class LocationGetter
    {
        public IEnumerable<Location> GetList(bool showPleaseSelect = false)
        {
            var results = new List<Location>();
            if (showPleaseSelect)
            {
                var dummyLocation = new Location
                {
                    Id = Guid.Empty,
                    Description = "<Please Select>"
                };
                results.Add(dummyLocation);
            }
            using (MovieCollectionEntities context = new MovieCollectionEntities())
                results.AddRange(context.Locations.OrderBy(l => l.Description));
            return results;
        }
    }
}
