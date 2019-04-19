using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ToDoList.Model
{
    public class Button
    {
        public bool AddItems { get; set; }
        public object SelectedItem { get; set; }
        public List<string> ListOfItems { get; set; }

        public string AddItemInput()
        {
            string input = Interaction.InputBox("Enter an item you wish to add: ");
            return input;
        }

        public void AddItem()
        {
            ListOfItems.Add(AddItemInput());
        }

        public void RemoveItem()
        {
            ListOfItems.Remove(SelectedItem.ToString());
        }

        public void RemoveAllItems()
        {
            for (int index = ListOfItems.Count - 1; index >= 0; index--)
            {
                ListOfItems.Remove(ListOfItems[index]);
            }
        }

    }
}
