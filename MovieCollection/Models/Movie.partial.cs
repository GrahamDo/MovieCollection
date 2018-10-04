using System;

namespace MovieCollection.Models
{
    public partial class Movie
    {
        public class MovieValidationException : Exception
        {
            public MovieValidationException(string message) : base(message)
            {
            }
        }

        public bool IsNew { get; set; }

        public void ValidateAndConvertUrl(Location location)
        {
            if (string.IsNullOrWhiteSpace(Title))
                throw new MovieValidationException("Title cannot be blank.");

            if (ActorId == Guid.Empty)
                ActorId = null;
            if (DirectorId == Guid.Empty)
                DirectorId = null;

            if (location.IsUrlRequired && string.IsNullOrWhiteSpace(LocationUrl))
                throw new MovieValidationException("The selected location requires you to specify a URL.");

            ConvertUrlToUri(); //In case the user put it in manually and didn't use the browse button
        }

        public void ConvertUrlToUri()
        {
            if (!string.IsNullOrWhiteSpace(LocationUrl))
                LocationUrl = GetUriFromPath(LocationUrl);
        }

        private string GetUriFromPath(string fileName)
        {
            try
            {
                var uri = new Uri(fileName);
                return uri.AbsoluteUri;
            }
            catch (UriFormatException)
            {
                return fileName; //It's obviously not meant to be a valid URL
            }
        }
    }
}
