using SOLID.DIP.Model;
using System;

namespace SOLID.DIP.AfterDIP
{
    public class LetterNotification : INotificationSender
    {
        public bool SendNotification(Customer customer)
        {
            return Send(customer.Address);
        }

        private bool Send(Address address)
        {
            //Letter Print Logic 
            return true;
        }
    }
}