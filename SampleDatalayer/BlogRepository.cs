using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MibDatalayer;
using SampleModel;

namespace SampleDatalayer
{
    public class BlogRepository:DbRepository<Blog>
    {
        public void Save(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
