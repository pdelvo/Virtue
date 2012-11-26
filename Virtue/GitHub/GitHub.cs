using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Threading;
using Newtonsoft.Json;

namespace Virtue.GitHub
{
    public partial class GitHubAPI
    {
        private static string authString;

        public static AuthenticatedUser Login(string username, string password)
        {
            authString = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(
                username + ":" + password));
            AuthenticatedUser user;
            try
            {
                user = GetAuthenticatedUser();
            }
            catch { return null; }
            return user;
        }

        public static AuthenticatedUser GetAuthenticatedUser()
        {
            var request = CreateGet(AuthenticatedUserUrl);
            var response = request.GetResponse();
            var serializer = new JsonSerializer();
            return serializer.Deserialize<AuthenticatedUser>(
                new JsonTextReader(
                new StreamReader(response.GetResponseStream())));
        }

        #region Helpers

        private static WebRequest CreateGet(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add(HttpRequestHeader.Authorization, authString);
            request.ContentType = "application/x-www-form-urlencoded";
            return request;
        }

        private static WebRequest CreatePost(string url)
        {
            var request = CreateGet(url);
            request.Method = "POST";
            return request;
        }

        private static void WriteString(string content, Stream stream)
        {
            var payload = Encoding.UTF8.GetBytes(content);
            stream.Write(payload, 0, payload.Length);
            stream.Flush();
        }

        private static JObject GetJson(Stream stream)
        {
            var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            return JObject.Parse(json);
        }

        private static JArray GetJsonArray(Stream stream)
        {
            var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            return JArray.Parse(json);
        }

        #endregion
    }
}
