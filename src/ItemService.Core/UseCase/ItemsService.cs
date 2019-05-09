using System.Collections.Generic;
using ItemService.Core.Domain;

namespace ItemService.Core.UseCase
{
    public class ItemsService : IItemsService
    {
        private readonly IItemRepository _repository;

        public ItemsService(IItemRepository repository)
        {
            _repository = repository;
        }

        public List<Item> GetAll()
        {
            return _repository.GetAll();
        }

        public void Add(Item entity)
        {
            // Тут на самом деле жолжен проверять это все какой нибудь ItemsShop или еще какой класс из домена
            // Но так как у меня очень бедная доменная модель я делаю это прямо в Порте хотя так недалать не надо
            if (_repository.GetAll().Exists(i => i.Text.Value == entity.Text.Value))
                throw new ItemExistsException(entity.Text.Value);

            _repository.Save(entity);
        }
    }
}