using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Proxy
{
    public interface ILogger
    {
        void InfoLogger(string message);
        void ErrorLogger(string message);
        void WarningLogger(string message);
    }

    public class VirtualProxyLogger : ILogger
    {
        public void ErrorLogger(string message)
        {
            GetLogger().ErrorLogger(message);
        }

        public void InfoLogger(string message)
        {
            GetLogger().InfoLogger(message);
        }

        public void WarningLogger(string message)
        {
            GetLogger().WarningLogger(message);
        }

        private Logger GetLogger() => new Logger();
    }

    internal class Logger : ILogger
    {
        public Logger()
        {
        }

        public void ErrorLogger(string message)
        {
            Console.Error.WriteLine($"Error Logger: => {message}");
        }

        public void InfoLogger(string message)
        {
            Console.WriteLine($"Info Logger: => {message}");
        }

        public void WarningLogger(string message)
        {
            Console.WriteLine($"Warning Logger: => {message}");

        }
    }
}
