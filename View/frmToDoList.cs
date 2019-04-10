﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ToDoList.Model;
using ToDoList.View;

namespace ToDoList
{
    public partial class frmToDoList : Form, IToDoList
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        public string AddItems
        {
            get { return   }
            set { }
        }

        public object SelectedItem
        {
            get { return toDoListBox.SelectedItem; }
            set { value = toDoListBox; }
        }
        public object ListOfItems
        {
            get { return toDoListBox; }
            set { value = toDoListBox; }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Button add = new Model.Button();
            add.AddItemToListBox(toDoListBox);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Model.Button remove = new Model.Button();
            remove.RemoveItem(toDoListBox);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Model.Button reset = new Model.Button();
            reset.RemoveAllItems(toDoListBox);
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            MessageBox.Show("uh welcome to the to do list application!", "Welcome!");
        }
    }
}