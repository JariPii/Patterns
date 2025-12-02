using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
