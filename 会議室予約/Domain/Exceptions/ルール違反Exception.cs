namespace 会議室予約.Domain.Exceptions
{
    public class ルール違反Exception: DomainException
    {
        public ルール違反Exception(string message) : base(message)
        {
            
        }
    }
}