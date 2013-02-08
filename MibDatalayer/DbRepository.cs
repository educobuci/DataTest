using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MibDatalayer
{
    public class DbRepository<T> : IRepository<T> where T : class, new()
    {
        DbConfiguration Configuration { get; set; }

        public DbRepository()
        {
            // This is meant to be replaced by the configuration library
            using (var steamReader = File.OpenText(".\\Config\\Database.json"))
            {
                var conn = steamReader.ReadToEnd();
                this.Configuration = new DbConfiguration()
                {
                    ConnectionString = conn
                };
            }
        }

        public DbRepository(DbConfiguration configuration)
        {
            this.Configuration = configuration;
        }
        public T FindById(int id) 
        {
            return default(T);
        }
    }
}
