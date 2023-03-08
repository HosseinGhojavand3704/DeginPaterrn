using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DeginPaterrn.Factory_Method
{

    /// <summary>
    /// Factory Method ISmsSernder
    /// </summary>

    public enum SmsSernderType
    {
        ShahParkSms,
        NavaSms,
        IranSms
    }

    public class SmsSernderCreateor
    {
        private static readonly SmsSernderCreateor _instance = new SmsSernderCreateor();

        private SmsSernderCreateor()
        {
        }

        public static SmsSernderCreateor GetInstance() => _instance;

        public static ISmsSernder SmsSernderFactoryMethod(SmsSernderType? sender = SmsSernderType.IranSms)
        {
            ISmsSernder defultSmsSernder = new IranSms();

            if (sender != null)
                switch (sender)
                {
                    case SmsSernderType.ShahParkSms:
                        defultSmsSernder = new ShahParkSms();
                        break;

                    case SmsSernderType.NavaSms:
                        defultSmsSernder = new NavaSms();
                        break;

                    case SmsSernderType.IranSms:
                        defultSmsSernder = new IranSms();
                        break;
                }

            return defultSmsSernder;
        }
    }

    /// <summary>
    /// Interface ISmsSernder
    /// </summary>

    public struct SmsSernderDto
    {
        public string Line { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Message { get; set; }

        public SmsSernderDto
        (
            string line,
            string sender,
            string receiver,
            string message
        ) {
            Line = line;
            Sender = sender;
            Receiver = receiver;
            Message = message;
        }
    }

    public interface ISmsSernder
    {
        void Send(SmsSernderDto opetion);
        IList<SmsSernderDto> GetList();
    }


    /// <summary>
    /// Classes Impelemation interface ISmsSernder
    /// </summary>

    internal class ShahParkSms : ISmsSernder
    {
        static private readonly IList<SmsSernderDto> _smsSernders = new List<SmsSernderDto>();

        internal ShahParkSms
        (
            
        ) {
        }

        public IList<SmsSernderDto> GetList() => _smsSernders;

        public void Send(SmsSernderDto opetion)
        {
            _smsSernders.Add(opetion);
            Console.WriteLine($"This message contains \"{opetion.Message}\" content and was sent by the sender \"{opetion.Sender}\" and the recipient \"{opetion.Receiver}\" with the sender number \"{opetion.Line}\" was successfully sent by the message service provider \"{nameof(ShahParkSms)}\".");
        }
    }

    internal class NavaSms : ISmsSernder
    {
        static private readonly IList<SmsSernderDto> _smsSernders = new List<SmsSernderDto>();

        internal NavaSms
        (

        )
        {
        }

        public IList<SmsSernderDto> GetList() => _smsSernders;

        public void Send(SmsSernderDto opetion)
        {
            _smsSernders.Add(opetion);
            Console.WriteLine($"This message contains \"{opetion.Message}\" content and was sent by the sender \"{opetion.Sender}\" and the recipient \"{opetion.Receiver}\" with the sender number \"{opetion.Line}\" was successfully sent by the message service provider \"{nameof(NavaSms)}\".");
        }
    }

    internal class IranSms : ISmsSernder
    {
        static private readonly IList<SmsSernderDto> _smsSernders = new List<SmsSernderDto>();

        internal IranSms
        (

        )
        {
        }

        public IList<SmsSernderDto> GetList() => _smsSernders;

        public void Send(SmsSernderDto opetion)
        {
            _smsSernders.Add(opetion);
            Console.WriteLine($"This message contains \"{opetion.Message}\" content and was sent by the sender \"{opetion.Sender}\" and the recipient \"{opetion.Receiver}\" with the sender number \"{opetion.Line}\" was successfully sent by the message service provider \"{nameof(IranSms)}\".");
        }
    }

}
