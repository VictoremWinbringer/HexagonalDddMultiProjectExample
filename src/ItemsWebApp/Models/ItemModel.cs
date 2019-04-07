using System.ComponentModel.DataAnnotations;
using Domain;

namespace ItemsWebApp.Models
{
    public class ItemModel
    {
        [StringLength(255, MinimumLength = 4)]
        public string Text { get; set; }

        public ItemModel(ItemEntity entity)
        {
            this.Text = entity.Text;
        }

        public ItemModel()
        {
            
        }

        public ItemEntity ToEntity()
        {
            return new ItemEntity()
            {
                Text = this.Text
            };
        }
    }
}