namespace DeginPaterrn.Mediator.Services
{
    public class Products: Colleague
    {
        public Products() { }

        public override void Send(string message)
        {
            Console.WriteLine($"Send Message From Class {nameof(Products)} --- Message => ({message})");
            base.Send(message);
        }

        public override void Recevie(string message)
        {
            Console.WriteLine($"Recevie Message From Class {nameof(Products)} --- Message => ({message})");
        }
    }
}
