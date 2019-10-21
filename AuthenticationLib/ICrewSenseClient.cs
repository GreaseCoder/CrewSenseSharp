using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrewSenseNet.Authentication
{
    public interface ICrewSenseClient
    {
        Task<HttpResponseMessage> DoGet(Uri uri, Dictionary<string, string> data);
        Task<HttpResponseMessage> DoPut(Uri uri, Dictionary<string, string> data);
    }
}
