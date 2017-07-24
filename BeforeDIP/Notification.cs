using SOLID.DIP.Model;
namespace SOLID.DIP.BeforeDIP
{
    public class Notification
    {
        public Notification()
        {

        }
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