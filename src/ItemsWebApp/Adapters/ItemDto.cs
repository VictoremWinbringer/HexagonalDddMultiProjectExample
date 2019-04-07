using Domain;
using LiteDB;

namespace ItemsWebApp.Adapters
{
    public class ItemDto
    {
        public ObjectId Id { get; set; }

        public string Text { get; set; }

        public ItemDto(ItemEntity entity)
        {
            this.Text = entity.Text;
        }

        public ItemDto()
        {
            
        }

        // Use AutoMapper for this in big project.
        public ItemEntity ToEntity()
        {
            return new ItemEntity
            {
                Text = this.Text
            };
        }
    }
}