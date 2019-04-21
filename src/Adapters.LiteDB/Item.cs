using Domain;
using LiteDB;

namespace Adapters.LiteDB
{
    public class Item
    {
        public ObjectId Id { get; set; }

        public string Text { get; set; }

        public Item(ItemEntity entity)
        {
            this.Text = entity.Text;
        }

        public Item()
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