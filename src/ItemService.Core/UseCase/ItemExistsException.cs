using System;

namespace ItemService.Core.UseCase
{
    internal class ItemExistsException : Exception
    {
        public ItemExistsException(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}