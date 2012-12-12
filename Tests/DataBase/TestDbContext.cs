using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.DataBase
{
    class TestDbContext:DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }
}
