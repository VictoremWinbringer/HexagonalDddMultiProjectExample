using System.Collections.Generic;
using System.Linq;
using Domain;
using LiteDB;

namespace Adapters.LiteDB
{
    public class ItemLiteDbRepository : IItemRepository
    {
        private readonly LiteDatabase _db;

        public ItemLiteDbRepository(LiteDatabase db)
        {
            _db = db;
        }

        public List<ItemEntity> GetAll()
        {
            return _db.GetCollection<Item>()
                .FindAll()
                .Select(item => item.ToEntity())
                .ToList();
        }

        public void Save(ItemEntity entity)
        {
            _db.GetCollection<Item>()
                .Insert(new Item(entity));
        }
    }
}