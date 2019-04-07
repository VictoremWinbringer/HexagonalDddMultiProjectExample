using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using LiteDB;

namespace ItemsWebApp.Adapters
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
            return _db.GetCollection<ItemDto>()
                .FindAll()
                .Select(item => item.ToEntity())
                .ToList();
        }

        public void Save(ItemEntity entity)
        {
            _db.GetCollection<ItemDto>()
                .Insert(new ItemDto(entity));
        }
    }
}