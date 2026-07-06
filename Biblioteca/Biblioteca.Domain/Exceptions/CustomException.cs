namespace Biblioteca.Domain.Exceptions
{
    public class CustomException : Exception
    {
        public string? Code { get; }
        public CustomException(string Message) : base(Message){ }
        public CustomException(string Message, Exception? InnerException) : base(Message, InnerException) { }
        public CustomException(string Message, Exception? InnerException, string? Code) : base(Message, InnerException) 
        { 
            this.Code = Code;
        }
    }
}
