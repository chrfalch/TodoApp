using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Shared.BL.Models;

namespace TodoApp.Shared.BL.UnitsOfWork
{
    public interface ITodoItemUnitOfWork: IUnitOfWork
    {
        /// <summary>
        /// Return all items sorted by date
        /// </summary>
        /// <returns></returns>
        IEnumerable<ITodoItem> GetSortedItems();

        /// <summary>
        /// Create a new Todoitem
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        ITodoItem CreateTodoItem(string text);
    }
}
