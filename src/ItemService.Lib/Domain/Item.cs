namespace ItemService.Lib.Domain
{
    public class Item
    {
        public Item(string text)
        {
            Text = new Name(text);
        }

        public Name Text { get; }
    }
}