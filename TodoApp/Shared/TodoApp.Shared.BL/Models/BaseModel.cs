using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Shared.BL.Models
{
    public class BaseModel: IModel
    {
        public virtual string Id { get; set; }
    }
}
