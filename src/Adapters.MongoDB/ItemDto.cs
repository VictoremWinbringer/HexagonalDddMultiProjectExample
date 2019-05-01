using ItemService.Lib.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Adapters.MongoDB
{
    [BsonIgnoreExtraElements]
    public class ItemDto
    {
        public ItemDto(Item entity)
        {
            Text = entity.Text.Value;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Text { get; set; }

        // Use AutoMapper for this in big project.
        public Item ToEntity()
        {
            return new Item(Text);
        }
    }
}