using System;

namespace 会議室予約.UseCase.Exceptions
{
    public class UseCaseException: Exception
    {
        public UseCaseException() : base()
        {
        }

        public UseCaseException(string message) : base(message)
        {
        }

        public UseCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public UseCaseException(Exception innerException) : base("", innerException)
        {
        }
    }
}