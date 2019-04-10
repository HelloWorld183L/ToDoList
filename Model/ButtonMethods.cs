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
        public object ListOfItems { get; set; }

        public string AddItem()
        {
            string input = Interaction.InputBox("Enter an item you wish to add: ");
            return input;
        }
        public void RemoveItem()
        {
            // TODO: Sort errors out
            checkedListBox.Items.Remove(checkedListBox.SelectedItem);
        }
        public void RemoveAllItems(CheckedListBox checkedListBox)
        {
            for (int index = checkedListBox.Items.Count - 1; index >= 0; index--)
            {
                checkedListBox.Items.Remove(checkedListBox.Items[index]);
            }
        }
    }
}
