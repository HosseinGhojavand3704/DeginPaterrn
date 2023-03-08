namespace DeginPaterrn.Decorator
{
    public interface ILogger
    {
        void FileLogger(string messageLog);
    }

    public class Logger: ILogger
    {
        private Logger logger;

        public Logger()
        {
        }

        public Logger(Logger logger)
        {
            this.logger = logger;
        }

        public void FileLogger(string messageLog)
        {
            Console.WriteLine(messageLog);
        }
    }

    public class LoggerDecorator: ILogger
    {
        private readonly ILogger _logger;

        public LoggerDecorator
        (
            ILogger logger
        ) {
            _logger = logger;
        }

        public void FileLogger(string messageLog) => _logger.FileLogger(messageLog);

    }

    public class NewFatucherLoggerDecorator : Logger
    {
        private readonly ILogger _logger;

        public NewFatucherLoggerDecorator
        (
            Logger logger
        ): base(logger)
        {
            _logger = logger;
            ConsoleLogger();
        }

        public void FileLogger(string messageLog)
        {
            base.FileLogger(messageLog);
        }

        public void DatabseLogger(string messageLog)
        {
            Console.WriteLine(messageLog);
        }

        public void ConsoleLogger()
        {
            Console.WriteLine("this Logger Is Console.");
        }

    }
}
