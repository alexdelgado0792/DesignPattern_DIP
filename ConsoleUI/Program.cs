using DemoLibrary.Interfaces;
using System;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPerson owner = Facotory.CreatePerson();
            owner.FirstName = "Ale";
            owner.LastName = "Del";
            owner.EmailAddress = "ale@example.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Facotory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();


            Console.ReadLine();
        }
    }
}
