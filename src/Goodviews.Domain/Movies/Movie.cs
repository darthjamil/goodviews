using System;
using System.Collections.Generic;
using System.Linq;

namespace Goodviews.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        /// <summary>
        /// Full language name in English
        /// </summary>
        public string Language { get; set; }
        public DateTime? ReleaseDate { get; set; }
        /// <summary>
        /// ISO-3166 Alpha 3 country code
        /// </summary>
        public string ReleaseCountry { get; set; }
        public string MPAARating { get; set; }
        public string PosterImageUrl { get; set; }
        public List<Contributor> Contributors { get; set; } = new List<Contributor>();
        public List<string> Genres { get; set; } = new List<string>();

        public List<Actor> GetActors()
        {
            return Contributors.OfType<Actor>().OrderBy(a => a.CreditOrder).ToList();
        }
    }
}
