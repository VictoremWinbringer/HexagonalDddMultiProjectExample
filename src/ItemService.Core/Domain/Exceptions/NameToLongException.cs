using System;

namespace ItemService.Core.Domain.Exceptions
{
    public class NameToLongException : Exception
    {
        public NameToLongException(int maxLength, int currentLength)
        {
            MaxLength = maxLength;
            CurrentLength = currentLength;
        }

        public int MaxLength { get; }
        public int CurrentLength { get; }
    }
}