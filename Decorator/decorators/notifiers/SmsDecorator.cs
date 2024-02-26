using Decorator.services.notifier;

namespace Decorator.decorators.notifiers
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(Notifier notifier) : base(notifier)
        {
        }
        
        public override string Send(string message)
        {
            return base.Send(message) + ", SMS";
        }
    }
}