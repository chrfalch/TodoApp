using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Community.Plugins.Sqlite;
using TodoApp.Shared.BL;
using TodoApp.Shared.BL.Models;

namespace TodoApp.Clients.Core.Repositories
{
    public class Repository<TModel, TInterface> : IRepository<TInterface>
        where TModel : BaseModel, TInterface, new()
        where TInterface: IModel
    {
        protected readonly ISQLiteConnection Connection;

        public Repository(ISQLiteConnectionFactory factory): base()
        {
            Connection = factory.Create("todoitem.sqlite");

            Connection.CreateTable<TModel>();
        }

        public IQueryable<TInterface> Items()
        {
            return Connection.Table<TModel>().AsQueryable();
        }

        public void Add(TInterface entity)
        {
            Connection.Insert(entity);
        }

        public void Remove(TInterface entity)
        {
            Connection.Delete(entity);
        }

        public void Update(TInterface entity)
        {
            Connection.Update(entity);
        }

        public int Count
        {
            get { return Connection.Table<TModel>().Count(); }
        }

        public TInterface GetById(string id)
        {
            return Items().FirstOrDefault(m => m.Id.Equals(id));
        }
    }
}
