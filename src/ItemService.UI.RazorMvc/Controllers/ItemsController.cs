using System.Linq;
using ItemService.Core.UseCase;
using ItemService.UI.RazorMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemService.UI.RazorMvc.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IItemsService _service;

        public ItemsController(IItemsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var items = _service
                .GetAll()
                .Select(item => new ItemModel(item))
                .ToList();
            return View(items);
        }

        [HttpPost]
        public IActionResult Add([FromForm] ItemModel item)
        {
            _service.Add(item.ToEntity());
            return RedirectToAction(nameof(Index));
        }
    }
}