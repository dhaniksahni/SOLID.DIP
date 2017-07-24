using SOLID.DIP.Model;
using System;

namespace SOLID.DIP.AfterDIP
{
    public class EmailNotification : INotificationSender
    {

        public bool SendNotification(Customer customer)
        {
            return Send(customer.Contact);
        }

        private bool Send(Contact contact)
        {
            //Send Email
            return true;
        }
    }
}