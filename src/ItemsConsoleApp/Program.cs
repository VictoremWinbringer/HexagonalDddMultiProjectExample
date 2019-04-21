using System;
using System.Linq;
using Adapters.LiteDB;
using Domain;
using LiteDB;

namespace ItemsConsoleApp
{
    class ConsolePort
    {
        private readonly IItemsService _service;

        public ConsolePort(IItemsService service)
        {
            _service = service;
        }
        public void AddItem(string text)
        {
            _service.Add(new ItemEntity(){ Text = text});
        }

        public string ShowAll()
        {
            return string.Join("\r\n",_service.GetAll().Select(item => item.Text));
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var db = new LiteDatabase("Items.db");
            var repository = new ItemLiteDbRepository(db);
            var service = new ItemsService(repository);
            var port = new ConsolePort(service);
            
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