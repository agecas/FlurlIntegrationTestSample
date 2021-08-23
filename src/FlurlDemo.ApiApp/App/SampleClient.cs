using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace FlurlDemo.ApiApp.App
{
    public sealed class SampleClient
    {
        private readonly string _url;

        public SampleClient(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(url));

            _url = url;
        }

        public async Task<IReadOnlyList<Episode>> GetFuturamaInfo() => await _url.AppendPathSegments("futurama", "info").GetJsonAsync<List<Episode>>();
    }
}
