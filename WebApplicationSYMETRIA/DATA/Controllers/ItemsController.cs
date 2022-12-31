using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationSYMETRIA.DATA.Interfaces;
using WebApplicationSYMETRIA.ViewModels;


namespace WebApplicationSYMETRIA.DATA.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IAllItems _allItems;
        private readonly IItemsCategory _allCategories;

        public ItemsController(IAllItems iAllItems, IItemsCategory iItemsCat)
        {
            _allItems = iAllItems;
            _allCategories = iItemsCat;
        }

        public ViewResult ViewList()
        {
            ViewBag.Title = "Projects page";
            ItemsListViewModel obj = new ItemsListViewModel();
            obj.getAllItems = _allItems.Items;
            obj.currCategory = "Concepts";            

            return View(obj);
        }
    }
}
