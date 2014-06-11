﻿namespace NancyBlog
{
    using System;

    public class BlogPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Summary { get; set; }
        public string Localink { get; set; }
        public string OriginalLink { get; set; }
    }
}