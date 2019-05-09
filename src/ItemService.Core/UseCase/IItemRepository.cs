using System.Collections.Generic;
using ItemService.Core.Domain;

namespace ItemService.Core.UseCase
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        void Save(Item entity);
    }
}