using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Shared.BL
{

    public interface IRepository<T> where T : IModel
    {
        IQueryable<T> Items(); 
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        int Count { get; }
        T GetById(string id);
    }
}
