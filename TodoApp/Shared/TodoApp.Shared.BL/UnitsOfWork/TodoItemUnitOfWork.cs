using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Shared.BL.Models;

namespace TodoApp.Shared.BL.UnitsOfWork
{
    public class TodoItemUnitOfWork: ITodoItemUnitOfWork
    {
        private readonly IRepository<ITodoItem> _todoRepository;

        public TodoItemUnitOfWork(IRepository<ITodoItem> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IEnumerable<ITodoItem> GetSortedItems()
        {
            return _todoRepository.Items().OrderByDescending(m => m.Date);
        }
    }
}
