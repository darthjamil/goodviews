using System.Collections.Generic;

namespace Goodviews.Domain
{
    public class SearchCriteria
    {
        public string Query { get; set; }
        public int? ReleaseYear { get; set; }
        public string Language { get; set; }
        public List<string> IncludedGenres { get; set; }
        public List<string> ExcludedGenres { get; set; }
        public List<string> IncludedActors { get; set; }
        public string Director { get; set; }
        public bool SafeSearch { get; set; } = true;
        public SortOrder SortOrder { get; set; } = SortOrder.Relevance;
    }
}
