using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OOPPrinciples.Coupling
{
    internal class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sms message: " + message);
        }
    }
}
