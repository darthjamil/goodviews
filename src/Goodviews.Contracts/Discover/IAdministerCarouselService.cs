using Goodviews.Contracts;
using System;
using System.Collections.Generic;

namespace Goodviews.Discover
{
    public interface IAdministerCarouselService
    {
        /// <summary>
        /// Gets all carousels in the system, paginated.
        /// </summary>
        /// <param name="pagination">How many carousels to show</param>
        /// <returns>A paginated set of carousels in the system, dynamic or otherwise</returns>
        public Page<Carousel> GetCarousels(Pagination pagination);

        /// <summary>
        /// Creates a new curated carousel.
        /// </summary>
        /// <param name="title">The title of the new carousel</param>
        /// <param name="movieIds">The list of movie IDs in the order they will appear in the carousel</param>
        public void CreateCarousel(string title, List<string> movieIds);

        /// <summary>
        /// Updates a curated carousel.
        /// </summary>
        /// <param name="carouselId">The ID of the carousel to update</param>
        /// <param name="title">The new title. Must be a valid title.</param>
        /// <param name="movieIds">The new set of ordered movie IDs. Must be a valid list of movie IDs.</param>
        public void UpdateCarousel(string carouselId, string title, List<string> movieIds);

        /// <summary>
        /// Creates a new dynamic carousel based on the supplied criteria.
        /// </summary>
        /// <param name="title">The title of the new carousel</param>
        /// <param name="criteria">The filter criteria for this carousel</param>
        /// <remarks>
        /// Note: We may later want to add something to specify how often the criteria
        /// is evaluated. Currently, it will be evaluated on every request.
        /// </remarks>
        public void CreateCarousel(string title, SearchCriteria criteria);

        /// <summary>
        /// Updates a dynamic carousel.
        /// </summary>
        /// <param name="carouselId">The ID of the carousel to update</param>
        /// <param name="title">The new title. Must be a valid title.</param>
        /// <param name="criteria">The new criteria for this carousel</param>
        public void UpdateCarousel(string carouselId, string title, SearchCriteria criteria);

        /// <summary>
        /// Removes a carouself from the system. Note: The UI should remove any references
        /// to this carousel before it is deleted.
        /// </summary>
        /// <param name="carouselId">The ID of the carousel to remove</param>
        public void DeleteCarousel(string carouselId);
    }
}
