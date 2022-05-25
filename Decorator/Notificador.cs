
namespace Decorator
{
    public class Notificador : INotificator
    {
        public string SendMessage()
        {
            return "This is a notification, right?";
        }
    }
}
