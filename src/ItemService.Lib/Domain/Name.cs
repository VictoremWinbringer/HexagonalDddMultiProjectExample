using System.Text.RegularExpressions;
using ItemService.Lib.Domain.Exceptions;

namespace ItemService.Lib.Domain
{
    public struct Name
    {
        public Name(string name)
        {
            var maxLength = 100;
            var nameFormat = "[a-zA-Z0-9_ ]";

            if (string.IsNullOrWhiteSpace(name))
                throw new NameIsEmptyException();

            if (name.Length > 100)
                throw new NameToLongException(maxLength, name.Length);

            if (!Regex.IsMatch(name, nameFormat))
                throw new NameFormatException(name, nameFormat);

            Value = name;
        }

        public string Value { get; }
    }
}