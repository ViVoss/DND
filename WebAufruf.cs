using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
