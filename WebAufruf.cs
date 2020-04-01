using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Cache;

namespace DND
{
    public class WebAufruf<T>
    {
        // StringBuilder builder = new StringBuilder();
        private string jsonstring;
        private string uri;

        public static void SetCache(WebRequest request)
        {
            HttpRequestCachePolicy caching = new HttpRequestCachePolicy(HttpRequestCacheLevel.CacheIfAvailable);
            request.CachePolicy = caching;
        }

        public dynamic GetJsonResponse(string requestParameter)
        {
            uri = "http://dnd5eapi.co/api/" + requestParameter;

            // Create WebRequest to URI
            WebRequest request = WebRequest.Create(uri);
            SetCache(request);

            // Get Response from WebRequest
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {

                StreamReader reader = new StreamReader(dataStream);

                // Filter JSON String from Response
                jsonstring = reader.ReadToEnd();

                // response.Close();

                return JsonConvert.DeserializeObject<T>(jsonstring);
            }
        }
    }
}
