using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.View
{
    public interface IItemView
    {
        bool AddItems { get; set; }
        string SelectedItem { get; set; }
        List<string> ListOfItems { get; set; }
    }
}
