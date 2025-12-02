using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OOPPrinciples.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
