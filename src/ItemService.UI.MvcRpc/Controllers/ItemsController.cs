﻿using System.Collections.Generic;
using System.Linq;
using ItemService.Core.UseCase;
using ItemService.UI.RPC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemService.UI.RPC.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemsService _service;

        public ItemsController(IItemsService service)
        {
            _service = service;
        }


        public List<ItemModel> GetAll()
        {
            return _service.GetAll().Select(item => new ItemModel(item)).ToList();
        }

        [HttpPost]
        public void Add([FromBody] ItemModel model)
        {
            _service.Add(model.ToEntity());
        }
    }
}