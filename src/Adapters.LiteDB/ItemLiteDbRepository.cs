using System.Collections.Generic;
using System.Linq;
using ItemService.Lib.Adapters;
using ItemService.Lib.Domain;
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

        public List<Item> GetAll()
        {
            return _db.GetCollection<ItemDto>()
                .FindAll()
                .Select(item => item.ToEntity())
                .ToList();
        }

        public void Save(Item entity)
        {
            _db.GetCollection<ItemDto>()
                .Insert(new ItemDto(entity));
        }
    }
}