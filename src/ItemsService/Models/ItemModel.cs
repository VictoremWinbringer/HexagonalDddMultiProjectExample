using System;
using System.ComponentModel.DataAnnotations;
using ItemService.Lib.Domain;

namespace ItemsService.Models
{
    public class ItemModel
    {
        public ItemModel(Item entity)
        {
            Text = entity.Text.Value;
        }

        [Obsolete("For serialization")]
        public ItemModel()
        {
        }

        [Display(Name = "Текст")] public string Text { get; set; }

        public Item ToEntity()
        {
            return new Item(Text);
        }
    }
}