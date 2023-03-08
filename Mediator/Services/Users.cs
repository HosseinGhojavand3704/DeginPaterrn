namespace DeginPaterrn.Mediator.Services
{
    public class Users: Colleague
    {
        public Users() { }

        public override void Send(string message)
        {
            Console.WriteLine($"Send Message From Class {nameof(Users)} --- Message => ({message})");
            base.Send(message);
        }

        public override void Recevie(string message)
        {
            Console.WriteLine($"Recevie Message From Class {nameof(Users)} --- Message => ({message})");
        }
    }
}
