using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.UnitsOfWork;

namespace TodoApp.Clients.Core.ViewModels
{
    public class TodoItemsViewModel : MvxViewModel
    {
        private readonly ITodoItemUnitOfWork _todoItemUnitOfWork;
        private string _newTodoItemText;

        public TodoItemsViewModel(ITodoItemUnitOfWork todoItemUnitOfWork)
        {
            _todoItemUnitOfWork = todoItemUnitOfWork;
        }

        public IEnumerable<ITodoItem> Items
        {
            get { return new List<ITodoItem>(_todoItemUnitOfWork.GetSortedItems()); }
        }

        public string NewTodoItemText
        {
            get { return _newTodoItemText; }
            set
            {
                _newTodoItemText = value;
                RaisePropertyChanged(() => NewTodoItemText);
            }
        }

        public MvxCommand AddTodoItemCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _todoItemUnitOfWork.CreateTodoItem(NewTodoItemText);
                    RaisePropertyChanged(() => Items);
                });
            }
        }
    }
}
