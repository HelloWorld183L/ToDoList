using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;
using ToDoList.View;

namespace ToDoList.Presenter
{
    public class ButtonPresenter
    {
        private IItemView itemView;
        private Button button;

        public ButtonPresenter(IItemView view)
        {
            this.itemView = view;
            button = new Button();
        }
    }
}