using System;
using System.Collections.Generic;
using System.Diagnostics;
using ItemsWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemsWebApp.Controllers
{
    public class ItemsController : Controller
    {
        private readonly List<ItemModel> _items;
        public ItemsController()
        {
            _items = new List<ItemModel>()
            {
                new ItemModel(){Text = "Hello World"}
            };
        }
        
        public IActionResult Index()
        {
            return
            View(_items);
        }

        [HttpPost]
        public IActionResult Add([FromForm] ItemModel item)
        {
            _items.Add(item);
            return RedirectToAction(nameof(Index));
        }
    }
}