using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Domain
{
    public class LocationDeleter
    {
        public void DeleteById(Guid id)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existing = context.Locations.FirstOrDefault(l => l.Id == id);
                context.Locations.Remove(existing);
                context.SaveChanges();
            }
        }
    }
}
