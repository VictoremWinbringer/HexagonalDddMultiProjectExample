using System.ComponentModel.DataAnnotations;
using Domain;

namespace ItemsWebApp.Models
{
    public class ItemModel
    {
        [Display(Name = "Текст")]
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