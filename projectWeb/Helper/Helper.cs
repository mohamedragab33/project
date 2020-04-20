using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace projectWeb.Helper
{
    public class WizeApi
    {
        public HttpClient intial() {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50327/");
            return client;
        
        }

    }
}
