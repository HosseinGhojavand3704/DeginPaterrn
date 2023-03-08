using DeginPaterrn.Mediator.Services;

namespace DeginPaterrn.Mediator
{
    public abstract class Mediator
    {
        public Products? _products { get; set; }
        public Users? _users { get; set; }

        protected Mediator
        (
            Products products,
            Users users
        ) {
            _products = products;
            _users = users;
        }

        public abstract void NotifyChange(string messge, Colleague colleague);
    }

    public class ConcreateMediator : Mediator
    {
        public ConcreateMediator
        (
            Products products,
            Users users
        ): base(products , users) { }

        public override void NotifyChange(string messge, Colleague colleague)
        {
            if (colleague == _products)
            {
                _users.Recevie(messge);
            }
            else if (colleague == _users)
            {
                _products.Recevie(messge);
            }

        }
    }
}
