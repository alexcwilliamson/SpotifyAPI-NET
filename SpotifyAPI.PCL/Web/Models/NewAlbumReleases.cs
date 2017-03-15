namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class NewAlbumReleases : BasicModel
    {
        [JsonProperty("albums")]
        public Paging<SimpleAlbum> Albums { get; set; }
    }
}