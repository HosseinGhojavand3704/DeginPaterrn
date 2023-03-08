namespace DeginPaterrn.Mediator
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        protected Colleague() { }

        public abstract void Recevie(string message);

        public void SetMediator(Mediator mediator) => _mediator = mediator;

        public virtual void Send(string message)
        {
            _mediator.NotifyChange(message , this);
        }
    }
}
