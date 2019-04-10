using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.View
{
    public interface IToDoList
    {
        bool AddItems { get; set; }
        object SelectedItem { get; set; }
        object ListOfItems { get; set; }
    }
}
