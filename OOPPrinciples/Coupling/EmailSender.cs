using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OOPPrinciples.Coupling
{
    internal class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending email: " + message);
        }

    }
}
