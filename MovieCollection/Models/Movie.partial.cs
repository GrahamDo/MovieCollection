using System;

namespace MovieCollection.Models
{
    public partial class Movie
    {
        public bool IsNew { get; set; }

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
