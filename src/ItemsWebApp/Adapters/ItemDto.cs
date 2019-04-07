using Domain;

namespace ItemsWebApp.Adapters
{
    public class ItemDto
    {
        public string Id { get; set; }

        public string Text { get; set; }

        public ItemDto(ItemEntity entity)
        {
            this.Text = entity.Text;
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