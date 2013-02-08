using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleModel;
using SampleDatalayer;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogs = new BlogRepository(null);
            Console.WriteLine(blogs.FindById(1).Title);
        }
    }
}
