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

        /// <summary>
        /// Returns all items sorted by date with the newest first
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ITodoItem> GetSortedItems()
        {
            return _todoRepository.Items().OrderByDescending(m => m.Date);
        }

        /// <summary>
        /// Create a new Todoitem
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public ITodoItem CreateTodoItem(string text)
        {
            var retVal = new TodoItem
            {
                Text = text, 
                Date = DateTime.Now, 
                Completed = false, 
                Id = Guid.NewGuid().ToString()
            };            

            _todoRepository.Add(retVal);

            return retVal;
        }

    }
}
