namespace ChainOfResponsibility.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handler(Order order);
    }
}
