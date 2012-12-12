using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MibDatalayer
{
    public class DbRepository<T> where T:class
    {
        public T FindById(int id) 
        {
            return default(T);
        }
    }
}
