﻿using System.Collections.Generic;

namespace Goodviews.Services
{
    public class Page<T>
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int NumPages { get; set; }
        public List<T> Items { get; set; }
    }
}
