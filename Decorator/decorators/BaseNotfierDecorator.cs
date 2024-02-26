using Decorator.services.notifier;

namespace Decorator.decorators
{
    public abstract class BaseDecorator : Notifier
    {
        protected Notifier _notifier;

        public BaseDecorator(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override string Send(string message)
        {
            return _notifier.Send(message);
        }
    }
}