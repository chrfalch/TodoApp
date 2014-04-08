using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Shared.BL.Models
{
    public class TodoItem: BaseModel, ITodoItem
    {        
        public virtual string Text { get; set; }
        public virtual bool Completed { get; set; }
        public DateTime Date { get; set; }
    }
}
