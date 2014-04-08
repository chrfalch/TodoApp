using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.Repositories;

namespace TodoApp.Shared.BL.Tests.TestHelpers
{
    class TodoItemTestRepository: ListRepository<ITodoItem>, ITodoItemRepository
    {
    }
}
