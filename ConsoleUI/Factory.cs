using DemoLibrary;
using DemoLibrary.Interfaces;

namespace ConsoleUI
{
    public static class Facotory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(),CreateMessage());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessage()
        {
            return new Emailer();
        }
    }
}
