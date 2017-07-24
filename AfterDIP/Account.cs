using SOLID.DIP.Model;
using System;

namespace SOLID.DIP.AfterDIP
{
    public class Account
    {
        INotificationSender emailSender = null;
        public Account(INotificationSender sender)
        {
            emailSender = sender;
        }
        public void OpenAccount()
        {
            Customer customer = new Customer()
            {
                FirstName = "Dhanik",
                LastName = "Sahni",
                DateOfBorth = new DateTime(1981, 07, 05),
                Address = new Address
                {
                    Address1 = "SVF",
                    Address2 = "Lal Kuan",
                    City = "Ghaziabad",
                    State = "UP",
                    Zip = "201002"
                },
                Contact = new Contact
                {
                    Email = "dhanik.sahni@yahoo.com",
                    Fax = "3234234242"
                }
            };

            //Concreate Object 
            emailSender.SendNotification(customer);
        }
    }
}