using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilt
{
    internal class HttpInstance
    {
        private HttpClient _client = new();
        public HttpClient Client { get => _client; }

        private static HttpInstance _instance = new();
        public static HttpInstance GetInstance { get => _instance; }

        private HttpInstance()
        {
            _client.DefaultRequestHeaders.Add("X-Riot-Token", "Here must be your riot api token");
        }

    }
}
