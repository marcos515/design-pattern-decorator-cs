namespace Decorator.services.notifier {
    public class Notifier
    {
        public virtual string Send(string message){
            return "Enviado '" + message + "' via Email";
        }
    }
}