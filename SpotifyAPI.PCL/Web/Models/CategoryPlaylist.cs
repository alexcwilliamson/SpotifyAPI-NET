namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class CategoryPlaylist : BasicModel
    {
        [JsonProperty("playlists")]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}