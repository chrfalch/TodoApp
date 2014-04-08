using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Shared.BL.Repositories;

namespace TodoApp.Shared.BL.UnitsOfWork
{
    public class TodoItemUnitOfWork: ITodoItemUnitOfWork
    {
        private readonly ITodoItemRepository _todoRepository;

        public TodoItemUnitOfWork(ITodoItemRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
