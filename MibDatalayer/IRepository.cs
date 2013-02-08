using System;
namespace MibDatalayer
{
    interface IRepository<T>
     where T : class, new()
    {
        T FindById(int id);
    }
}
