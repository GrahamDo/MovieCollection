using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollection.Domain
{
    public class MovieDeleter
    {
        public void DeleteById(Guid id)
        {
            using (var context = new MovieCollectionEntities())
            {
                var existing = context.Movies.Where(m => m.Id == id).FirstOrDefault();
                context.Movies.Remove(existing);
                context.SaveChanges();
            }
        }
    }
}
