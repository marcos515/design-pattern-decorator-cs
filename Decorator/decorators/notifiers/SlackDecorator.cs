using Decorator.services.notifier;

namespace Decorator.decorators.notifiers
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override string Send(string message)
        {
            return base.Send(message) + ", Slack";
        }
    }
}