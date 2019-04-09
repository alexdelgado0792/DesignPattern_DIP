using DemoLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Texting : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting {person.FirstName} to say {message}");
        }
    }
}
