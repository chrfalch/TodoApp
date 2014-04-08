using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.UnitsOfWork;

namespace TodoApp.Clients.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Register units of work
            Mvx.LazyConstructAndRegisterSingleton<ITodoItemUnitOfWork, TodoItemUnitOfWork>();
            	
            RegisterAppStart<ViewModels.TodoItemsViewModel>();
        }
    }
}