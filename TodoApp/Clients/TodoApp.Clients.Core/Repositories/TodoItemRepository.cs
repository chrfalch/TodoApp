using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.Repositories;

namespace TodoApp.Clients.Core.Repositories
{
    public class TodoItemRepository: Repository<ITodoItem>, ITodoItemRepository
    {
    }
}
