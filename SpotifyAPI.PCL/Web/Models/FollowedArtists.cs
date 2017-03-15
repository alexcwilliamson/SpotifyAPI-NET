namespace SpotifyAPI.PCL.Web.Models
{
    using Newtonsoft.Json;

    public class FollowedArtists : BasicModel
    {
        [JsonProperty("artists")]
        public CursorPaging<FullArtist> Artists { get; set; }
    }
}