using ItemService.Core.Domain;
using LiteDB;

namespace ItemService.Infrastructure.LiteDB
{
    public class ItemDto
    {
        public ItemDto(Item entity)
        {
            Text = entity.Text.Value;
        }

        public ItemDto()
        {
        }

        public ObjectId Id { get; set; }

        public string Text { get; set; }

        // Use AutoMapper for this in big project.
        public Item ToEntity()
        {
            return new Item(Text);
        }
    }
}