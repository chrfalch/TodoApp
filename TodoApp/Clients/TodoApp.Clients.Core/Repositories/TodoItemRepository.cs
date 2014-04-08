using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.Community.Plugins.Sqlite;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.Repositories;

namespace TodoApp.Clients.Core.Repositories
{
    public class TodoItemRepository: Repository<TodoItem, ITodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(ISQLiteConnectionFactory factory) : base(factory)
        {
        }
    }
}
