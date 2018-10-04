using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Domain
{
    public class LocationAdder
    {
        public Location CreateObjectForAdd() =>
            new Location
            {
                Id = Guid.NewGuid(),
                IsNew = true
            };

        public void Add(Location location)
        {
            using (var context = new MovieCollectionEntities())
            {
                context.Locations.Add(location);
                context.SaveChanges();
            }
        }
    }
}
