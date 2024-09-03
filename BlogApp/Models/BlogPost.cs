using System;
using System.Collections.Generic;

namespace BlogApp.Models;

public class BlogPost
{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Comment> Comments { get; set; }
}