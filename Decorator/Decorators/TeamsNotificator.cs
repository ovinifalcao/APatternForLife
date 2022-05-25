namespace Decorator.Decorators
{
    public class TeamsNotificator : NotificatorDecorator
    {
        public TeamsNotificator(INotificator notification) : base(notification)
        {
        }

        public override string SendMessage()
        {
            return "Teams : " + base.SendMessage();
        }
    }
}
