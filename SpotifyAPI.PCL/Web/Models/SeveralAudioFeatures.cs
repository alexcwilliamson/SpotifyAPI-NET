namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SeveralAudioFeatures : BasicModel
    {
         [JsonProperty("audio_features")]
         public List<AudioFeatures> AudioFeatures { get; set; }
    }
}