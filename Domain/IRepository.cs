using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();

    }
}
