using System;

namespace ItemService.Lib.Domain.Exceptions
{
    public class NameFormatException : Exception
    {
        public NameFormatException(string name, string expectedFormat)
        {
            Name = name;
            ExpectedFormat = expectedFormat;
        }

        public string Name { get; }
        public string ExpectedFormat { get; }
    }
}