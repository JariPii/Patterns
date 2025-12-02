using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OOPPrinciples.Coupling
{
    internal class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            notificationService.SendNotification("Order placed successfully!");
        }
    }
}
