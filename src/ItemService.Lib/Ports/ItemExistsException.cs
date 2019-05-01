using System;

namespace ItemService.Lib.Ports
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