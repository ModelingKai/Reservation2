using System;

namespace 会議室予約.Domain.Exceptions
{
    public class DomainException: Exception
    {
        public DomainException() : base()
        {
        }

        public DomainException(string message) : base(message)
        {
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DomainException(Exception innerException) : base("", innerException)
        {
        }
    }
}