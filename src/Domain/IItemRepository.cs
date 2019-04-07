using System.Collections.Generic;

namespace Domain
{
    public interface IItemRepository
    {
        List<ItemEntity> GetAll();
        void Save(ItemEntity entity);
    }
}