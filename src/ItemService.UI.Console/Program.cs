using System;
using System.Linq;
using ItemService.Core.Domain;
using ItemService.Core.UseCase;
using ItemService.Infrastructure.LiteDB;
using LiteDB;

namespace ItemService.UI.Console
{
    internal class ConsoleController
    {
        private readonly IItemsService _service;

        public ConsoleController(IItemsService service)
        {
            _service = service;
        }

        public void AddItem(string text)
        {
            _service.Add(new Item(text));
        }

        public string ShowAll()
        {
            return string.Join("\r\n",
                _service.GetAll().Select(item => item.Text.Value));
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var db = new LiteDatabase("Items.db");
            var repository = new ItemLiteDbRepository(db);
            var service = new ItemsService(repository);
            var port = new ConsoleController(service);

            while (true)
            {
                System.Console.WriteLine("Current items");
                System.Console.WriteLine(port.ShowAll());
                System.Console.WriteLine("Inter new item to add");
                port.AddItem(System.Console.ReadLine()?.Trim());
            }
        }
    }
}