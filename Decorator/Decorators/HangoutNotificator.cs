namespace Decorator.Decorators
{
    public class HangoutNotificator : NotificatorDecorator
    {
        public HangoutNotificator(INotificator notification) : base(notification)
        {
        }

        public override string SendMessage()
        {
            return "Hangout : " + base.SendMessage();
        }
    }
}
