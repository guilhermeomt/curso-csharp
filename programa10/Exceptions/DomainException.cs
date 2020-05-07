using System;

namespace Application.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}