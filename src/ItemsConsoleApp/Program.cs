using System;
using System.Linq;
using Adapters.LiteDB;
using ItemService.Lib.Domain;
using ItemService.Lib.Ports;
using LiteDB;

namespace ItemsConsoleApp
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
                Console.WriteLine("Current items");
                Console.WriteLine(port.ShowAll());
                Console.WriteLine("Inter new item to add");
                port.AddItem(Console.ReadLine()?.Trim());
            }
        }
    }
}