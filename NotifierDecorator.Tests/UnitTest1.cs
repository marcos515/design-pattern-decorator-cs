namespace NotifierDecorator.Tests;

using Decorator.services.notifier;
using Decorator.decorators.notifiers;

public class UnitTest1
{
    [Fact]
    public void TesteEnvioNotificacaoTodosCanais()
    {
        Notifier Stack = new Notifier();

        Stack = new SlackDecorator(Stack);
        Stack = new FacebookDecorator(Stack);
        Stack = new SmsDecorator(Stack);

        string result = Stack.Send("Você tem novas mensagens!");

        Assert.Contains("Slack", result);
        Assert.Contains("Facebook", result);
        Assert.Contains("SMS", result);
    }
}