using MovieCollection.Domain;
using System;

namespace MovieCollection.Models
{
    public partial class Location
    {
        public class LocationValidationException : Exception
        {
            public LocationValidationException(string message) : base(message)
            {
            }
        }

        public bool IsNew { get; set; }

        public override string ToString()
        {
            return Description;
        }

        public void Validate(LocationGetter locationGetter)
        {
            if (string.IsNullOrWhiteSpace(Description))
                throw new LocationValidationException("Description cannot be blank.");
            if (locationGetter.IsExistingByDescription(Description, Id))
                throw new LocationValidationException(
                    $"A location named {Description} already exists.");
        }

        public void ValidateForDelete(MovieGetter movieGetter)
        {
            if (movieGetter.IsMovieExistingByLocationId(Id))
                throw new LocationValidationException("At least one movie uses this location. Please move or remove " + 
                    "it and try again.");
        }
    }
}
