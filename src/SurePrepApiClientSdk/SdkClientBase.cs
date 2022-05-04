using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS1998

namespace SurePrepAPI
{
    public class SdkClientBase
    {
        public string BaseUrl { get; set; }
        public string AuthToken { get; set; }
        public string ParentOperationId { get; set; } = Guid.NewGuid().ToString("N");
        public bool? IsTraceEnable { get; set; }
        public Func<HttpClient> GetHttpClient { get; set; }
        public bool DisposeClient { get; set; } = false;

        protected virtual bool GetDisposeClient()
        {
            return DisposeClient;
        }

        protected virtual async Task PrepareRequestAsync(System.Net.Http.HttpClient httpClient, System.Net.Http.HttpRequestMessage request, StringBuilder urlBuilder)
        {
            if (!string.IsNullOrEmpty(AuthToken))
            {
                request.Headers.TryAddWithoutValidation("AuthToken", AuthToken);
            }
            if (!string.IsNullOrEmpty(ParentOperationId))
            {
                request.Headers.TryAddWithoutValidation("traceparent", ParentOperationId);
            }
            if (IsTraceEnable.HasValue)
            {
                request.Headers.TryAddWithoutValidation("IsTraceEnable", IsTraceEnable.Value.ToString());
            }
            return;
        }
        protected virtual async Task PrepareRequestAsync(System.Net.Http.HttpClient httpClient, System.Net.Http.HttpRequestMessage request, string url)
        {
            return;
        }
        protected virtual async Task ProcessResponseAsync(System.Net.Http.HttpClient httpClient, System.Net.Http.HttpResponseMessage response, System.Threading.CancellationToken cancellationToken)
        {
            return;
        }
        protected virtual async Task<HttpClient> CreateHttpClientAsync(System.Threading.CancellationToken cancellationToken)
        {
            if (GetHttpClient != null)
            {
                return GetHttpClient.Invoke();
            }
            return new HttpClient();
        }
        protected virtual async Task<HttpRequestMessage> CreateHttpRequestMessageAsync(System.Threading.CancellationToken cancellationToken)
        {
            return new HttpRequestMessage();
        }
        protected virtual void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings)
        {
        }
    }
}

#pragma warning restore CS1998