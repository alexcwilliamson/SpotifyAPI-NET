namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class FeaturedPlaylists : BasicModel
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}