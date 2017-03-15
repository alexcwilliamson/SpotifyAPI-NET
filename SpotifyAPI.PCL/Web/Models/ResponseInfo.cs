namespace SpotifyAPI.PCL.Web.Models
{
    using System.Net.Http.Headers;

    public class ResponseInfo
    {
        public HttpResponseHeaders Headers { get; set; }

        public static readonly ResponseInfo Empty = new ResponseInfo();
    }
}