using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
