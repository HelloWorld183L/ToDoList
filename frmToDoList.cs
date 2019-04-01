using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ToDoList
{
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItemToListBox();
        }

        #region Button Add Methods

        private void AddItemToListBox()
        {
            toDoListBox.Items.Add(AddItem());
        }
        private string AddItem()
        {
            string input = Interaction.InputBox("Enter an item you wish to add: ");
            return input;
        }
        #endregion 

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        #region Button Remove Methods

        private void RemoveItem()
        {
            toDoListBox.Items.Remove(toDoListBox.SelectedItem);
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            RemoveAllItems();
        }

        #region Reset Methods

        private void RemoveAllItems()
        {
            for (int index = toDoListBox.Items.Count - 1; index >= 0; index--)
            {
                toDoListBox.Items.Remove(toDoListBox.Items[index]);
            }
        }
        #endregion

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            MessageBox.Show("uh welcome to the to do list application!", "Welcome!");
        }
    }
}