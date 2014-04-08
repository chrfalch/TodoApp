using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Shared.BL.Models
{
    public interface ITodoItem: IModel
    {
        string Text { get; set; }
        bool Completed { get; set; }
    }
}
