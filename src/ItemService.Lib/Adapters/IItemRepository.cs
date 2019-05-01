using System.Collections.Generic;
using ItemService.Lib.Domain;

namespace ItemService.Lib.Adapters
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        void Save(Item entity);
    }
}