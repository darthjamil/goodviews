
namespace Goodviews.Movies
{
    public class Actor : Contributor
    {
        public string CharacterName { get; set; }
        /// <summary>
        /// The order in which this actor is to be creditor among other actors
        /// in this movie
        /// </summary>
        public int CreditOrder { get; set; }
    }
}
