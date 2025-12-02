using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Coupling
{
    internal class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sms message: " + message);
        }
    }
}
