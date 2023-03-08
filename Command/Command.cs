using DeginPaterrn.Command.Services;

namespace DeginPaterrn.Command
{

    public abstract class CommandAbstract<T> where T : IServiceOne
    {
        public readonly T _reciver;

        public CommandAbstract
        (
            T reciver
        ) {
            _reciver = reciver;
        }

        public abstract void Excute();
    }

    public class ConcreteCommandOne<T> : CommandAbstract<T> where T: IServiceOne
    {
        public ConcreteCommandOne(T reciver) : base(reciver)
        {
        }

        public override void Excute()
        {
            Console.WriteLine($"This Run The Method => Excute In The Service: {nameof(ConcreteCommandOne<T>)}");

            ////////////////////////////////////////////////
            _reciver.ActionOne1();
        }
    }

    public class InvokerCommand<T> where T : IServiceOne
    {
        private readonly ConcreteCommandOne<T> _commandAbstract;

        public InvokerCommand
        (
            ConcreteCommandOne<T> commandAbstract
        ) {
            _commandAbstract = commandAbstract;
        }

        public void ExcuteCommand()
        {
            _commandAbstract.Excute();
        }
    }

}
