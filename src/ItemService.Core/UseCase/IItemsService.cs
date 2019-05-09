using System.Collections.Generic;
using ItemService.Core.Domain;

namespace ItemService.Core.UseCase
{
    public interface IItemsService
    {
        List<Item> GetAll();
        void Add(Item entity);
    }
}