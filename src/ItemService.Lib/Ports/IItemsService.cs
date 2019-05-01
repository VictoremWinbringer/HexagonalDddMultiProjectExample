using System.Collections.Generic;
using ItemService.Lib.Domain;

namespace ItemService.Lib.Ports
{
    public interface IItemsService
    {
        List<Item> GetAll();
        void Add(Item entity);
    }
}