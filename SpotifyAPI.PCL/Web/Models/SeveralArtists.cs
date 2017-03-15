namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SeveralArtists : BasicModel
    {
        [JsonProperty("artists")]
        public List<FullArtist> Artists { get; set; }
    }
}