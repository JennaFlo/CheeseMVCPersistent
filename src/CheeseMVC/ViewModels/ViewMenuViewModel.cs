using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;


namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        public IList<CheeseMenu> Items { get; set; }
        public Menu Menu { get; set; }

        public ViewMenuViewModel() { }

        public ViewMenuViewModel(Menu menu, List<CheeseMenu> items)
        {
            Menu = menu;
            Items = items;
        }
    }
}
