using SOLID.DIP.Model;

namespace SOLID.DIP.AfterDIP
{
    public interface INotificationSender
    {
        bool SendNotification(Customer customer);
    }
}