using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleModel
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Blog Blog { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
