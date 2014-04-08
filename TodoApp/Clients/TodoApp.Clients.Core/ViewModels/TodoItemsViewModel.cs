using Cirrious.MvvmCross.ViewModels;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.UnitsOfWork;

namespace TodoApp.Clients.Core.ViewModels
{
    public class TodoItemsViewModel : MvxViewModel
    {
        private readonly ITodoItemUnitOfWork _todoItemUnitOfWork;

        public TodoItemsViewModel(ITodoItemUnitOfWork todoItemUnitOfWork)
        {
            _todoItemUnitOfWork = todoItemUnitOfWork;
        }
    }
}
