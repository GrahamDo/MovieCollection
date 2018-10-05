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

        public void Validate(LocationGetter _locationGetter)
        {
            if (string.IsNullOrWhiteSpace(Description))
                throw new LocationValidationException("Description cannot be blank.");
            if (_locationGetter.IsExistingByDescription(Description, Id))
                throw new LocationValidationException(
                    $"A location named {Description} already exists.");
        }
    }
}
