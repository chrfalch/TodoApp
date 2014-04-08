using System;
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
    }
}
