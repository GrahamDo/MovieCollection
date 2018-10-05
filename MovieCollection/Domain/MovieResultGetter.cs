using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Domain
{
    public class MovieResultGetter
    {
        public List<MovieResult> Search(string title, int year, Guid actorId, Guid directorId,
            Guid locationId)
        {
            var results = new List<MovieResult>();
            using (var context = new MovieCollectionEntities())
            {
                results.AddRange(context.MovieResults);
                if (!string.IsNullOrEmpty(title))
                    results = results.Where(m => m.Title.ToUpper()
                        .Contains(title.ToUpper())).ToList();
                if (year > 0)
                    results = results.Where(m => m.Year == year).ToList();
                if (actorId != Guid.Empty)
                    results = results.Where(m => m.ActorId == actorId).ToList();
                if (directorId != Guid.Empty)
                    results = results.Where(m => m.DirectorId == directorId).ToList();
                if (locationId != Guid.Empty)
                    results = results.Where(m => m.LocationId == locationId).ToList();
            }
            return results;
        }

        public bool IsMaxResultsCountExceeded(List<MovieResult> list, uint maxResults)
            => list.Count > maxResults || maxResults == 0;
    }
}
