namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SeveralTracks : BasicModel
    {
        [JsonProperty("tracks")]
        public List<FullTrack> Tracks { get; set; }
    }
}