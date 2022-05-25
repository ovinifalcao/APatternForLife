namespace Decorator.Decorators
{
    public class SlackNotificator : NotificatorDecorator
    {
        public SlackNotificator(INotificator notification) : base(notification)
        {
        }

        public override string SendMessage()
        {
            return "Slack : " + base.SendMessage();
        }
    }
}
