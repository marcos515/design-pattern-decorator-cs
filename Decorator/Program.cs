using System;
using Decorator.services.notifier;
using Decorator.decorators.notifiers;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sendSlack = true;
            bool sendFacebook = true;
            bool sendSms = true;

            Notifier Stack = new Notifier();
            
            if (sendSlack)
                Stack = new SlackDecorator(Stack);
                
            if (sendFacebook)
                Stack = new FacebookDecorator(Stack);

            if (sendSms)
                Stack = new SmsDecorator(Stack);

            app(Stack, "Você tem novas mensagens!");

        }


        static void app(Notifier notifier, string message)
        {
            string result = notifier.Send(message);
            Console.WriteLine(result);
        }
    }
}