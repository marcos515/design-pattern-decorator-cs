using Decorator.services.notifier;

namespace Decorator.decorators.notifiers
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(Notifier notifier) : base(notifier)
        {
        }

        public override string Send(string message)
        {
            return base.Send(message) + ", Facebook";
        }
    }
}