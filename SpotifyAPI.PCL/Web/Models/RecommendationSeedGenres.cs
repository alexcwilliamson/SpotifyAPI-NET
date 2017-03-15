namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class RecommendationSeedGenres : BasicModel
    {
         [JsonProperty("genres")]
         public List<string> Genres { get; set; }
    }
}