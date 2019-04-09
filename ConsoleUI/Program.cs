using System;
using DemoLibrary;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Ale",
                LastName = "Del",
                EmailAddress ="ale@example.com",
                PhoneNumber = "555-1212"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner

            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();


            Console.ReadLine();
        }
    }
}
