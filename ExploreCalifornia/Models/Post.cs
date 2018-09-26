﻿using System;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime Posted { get; internal set; } = DateTime.Now;
    }
}
