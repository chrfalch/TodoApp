using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Shared.BL.Tests.TestHelpers
{
    class ListRepository<T>: IRepository<T> where T : IModel
    {
        private readonly List<T> _items = new List<T>();

        public ListRepository()
        {            
        }

        public ListRepository(IEnumerable<T> items)
        {
            _items.AddRange(items);
        }
 
        public IQueryable<T> Items()
        {
            return new EnumerableQuery<T>(_items);
        }

        public void Add(T entity)
        {
            _items.Add(entity);
        }

        public void Remove(T entity)
        {
            _items.Remove(entity);
        }

        public void Update(T entity)
        {
            // do nothing, we dont save
        }

        public int Count { get { return _items.Count; } }

        public T GetById(string id)
        {
            return _items.FirstOrDefault(m => m.Id.Equals(id));
        }
    }
}
