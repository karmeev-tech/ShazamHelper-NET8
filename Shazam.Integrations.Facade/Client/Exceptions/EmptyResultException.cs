namespace MetaMusic.Integrations.Facade.Client.Exceptions;

public class EmptyResultException : Exception
{
    public EmptyResultException(string message)
    {
        Message = message;
    }

    public new string Message { get; set; }
}