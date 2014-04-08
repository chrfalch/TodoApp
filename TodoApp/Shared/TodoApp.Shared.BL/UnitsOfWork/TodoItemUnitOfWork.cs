using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Shared.BL.Models;
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
