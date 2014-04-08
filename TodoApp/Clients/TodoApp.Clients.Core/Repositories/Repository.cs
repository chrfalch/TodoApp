using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Shared.BL;

namespace TodoApp.Clients.Core.Repositories
{
    public class Repository<T>: IRepository<T> where T: IModel
    {
        public IQueryable<T> Items()
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public int Count { get; private set; }
        public T GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
