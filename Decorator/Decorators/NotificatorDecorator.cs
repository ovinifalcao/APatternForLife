namespace Decorator.Decorators
{
    public class NotificatorDecorator : INotificator
    {
        private readonly INotificator _notification;

        public NotificatorDecorator(INotificator notification)
        {
            this._notification = notification;
        }

        public virtual string SendMessage()
        {
            return _notification.SendMessage();
        }
    }
}
