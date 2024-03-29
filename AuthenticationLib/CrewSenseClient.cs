﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CrewSenseNet.Authentication
{
    public class CrewSenseClient : ICrewSenseClient
    {
        private readonly HttpClient client = new HttpClient();
        private readonly TokenManager tokenManager;

        public CrewSenseClient(TokenManager tokenManager) => this.tokenManager = tokenManager;

        private async Task Authenticate()
        {
            var token = await tokenManager.GetNewToken();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<HttpResponseMessage> DoGet(Uri uri, Dictionary<string, string> data)
        {
            if (tokenManager.IsExpired())
            {
                await Authenticate();
            }

            var content = new FormUrlEncodedContent(data);
            return await client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> DoPost(Uri uri, Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            return await client.PostAsync(uri, content);
        }

    }
}
