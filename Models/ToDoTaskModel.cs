using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoTaskModel
    {
        public List<ToDoTaskModel> Completed { get; set; }
        public List<ToDoTaskModel> Due { get; set; }
    }
}
