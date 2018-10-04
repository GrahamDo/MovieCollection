using MovieCollection.Models;
using System.Linq;

namespace MovieCollection.Domain
{
    public class LocationUpdater
    {
        public void Update(Location location)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existingLocation = context.Locations.Where(l => l.Id == location.Id)
                    .FirstOrDefault();
                existingLocation.Description = location.Description;
                existingLocation.IsUrlRequired = location.IsUrlRequired;
                context.SaveChanges();
            }
        }
    }
}
