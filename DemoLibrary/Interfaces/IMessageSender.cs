namespace DemoLibrary.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}