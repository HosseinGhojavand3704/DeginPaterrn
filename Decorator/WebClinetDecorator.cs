using System.Net;

namespace DeginPaterrn.Decorator
{
    public class WebClinetDecorator : WebClient
    {
        private readonly WebClient _webClient;
        public WebClinetDecorator(WebClient webClient)
        {
            _webClient = webClient;
        }

        public string DownloadString(string address)
        {
            if (address.StartsWith("https://bugeto.net"))
            {
                return _webClient.DownloadString(address);

            }
            else
            {
                return "Url Invalid";
            }

        }
    }
}
