namespace SpotifyAPI.PCL.Web.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class SeveralAlbums : BasicModel
    {
        [JsonProperty("albums")]
        public List<FullAlbum> Albums { get; set; }
    }
}