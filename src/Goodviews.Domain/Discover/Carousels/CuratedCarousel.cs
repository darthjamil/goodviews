using System;
using System.Collections.Generic;

namespace Goodviews.Domain
{
    public class CuratedCarousel : Carousel
    {
        public List<Guid> MovieIds { get; set; }
    }
}
